using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductionCost
{
    public partial class ProductionCostModule : BaseModuleERP
    {
        #region Constant
        public const string TaiDuLieuButtonEditName = "fld_btnRefresh";
        public const string TinhGiaAllButtonEditName = "fld_btnTinhGiaAll";
        public const string CapNhatAllButtonEditName = "fld_btnCapNhatAll";

        //public const string ProductionCostIngredientCostGridControlName = "fld_dgcMMProductionCostIngredientCosts";
        //public const string ProductionCostIngredientCostSCGridControlName = "fld_dgcMMProductionCostIngredientCostsSC";
        //public const string ProductionCostIngredientCostTCGridControlName = "fld_dgcMMProductionCostIngredientCostsTC";
        //public const string ProductionCostIngredientCostSonGridControlName = "fld_dgcMMProductionCostIngredientCostsSon";
        //public const string ProductionCostIngredientCostLRGridControlName = "fld_dgcMMProductionCostIngredientCostsLR";
        //public const string ProductionCostIngredientCostDGGridControlName = "fld_dgcMMProductionCostIngredientCostsDG";

        public const string ProductionCostIngredientIncompletePhoiGridControlName = "fld_dgcMMProductionCostIngredientIncompletesPhoi";
        public const string ProductionCostIngredientIncompleteSCGridControlName = "fld_dgcMMProductionCostIngredientIncompletesSC";
        public const string ProductionCostIngredientIncompleteTCGridControlName = "fld_dgcMMProductionCostIngredientIncompletesTC";
        public const string ProductionCostIngredientIncompleteSonGridControlName = "fld_dgcMMProductionCostIngredientIncompletesSon";
        public const string ProductionCostIngredientIncompleteLRGridControlName = "fld_dgcMMProductionCostIngredientIncompletesLR";
        public const string ProductionCostIngredientIncompleteDGGridControlName = "fld_dgcMMProductionCostIngredientIncompletesDG";

        #endregion Constants

        #region Variables

        //MMProductionCostIngredientCostsGridControl ProductionCostIngredientCostGridControl;
        //MMProductionCostIngredientCostsGridControl ProductionCostIngredientCostSCGridControl;
        //MMProductionCostIngredientCostsGridControl ProductionCostIngredientCostTCGridControl;
        //MMProductionCostIngredientCostsGridControl ProductionCostIngredientCostSonGridControl;
        //MMProductionCostIngredientCostsGridControl ProductionCostIngredientCostLRGridControl;
        //MMProductionCostIngredientCostsGridControl ProductionCostIngredientCostDGGridControl;

        MMProductionCostIngredientIncompletesGridControl ProductionCostIngredientIncompletePhoiGridControl;
        MMProductionCostIngredientIncompleteSCsGridControl ProductionCostIngredientIncompleteSCGridControl;
        MMProductionCostIngredientIncompleteTCsGridControl ProductionCostIngredientIncompleteTCGridControl;
        MMProductionCostIngredientIncompleteLRsGridControl ProductionCostIngredientIncompleteLRGridControl;
        MMProductionCostIngredientIncompleteSonsGridControl ProductionCostIngredientIncompleteSonGridControl;
        MMProductionCostIngredientIncompleteDGsGridControl ProductionCostIngredientIncompleteDGGridControl;
        #endregion

        #region Property

        BOSButton TaiDuLieuButtonEdit;
        BOSButton TinhGiaAllButtonEdit;
        BOSButton CapNhatAllButtonEdit;

        string CDPhoiNo = "CD-003";
        string CDSoCheNo = "CD-004";
        string CDTinhCheNo = "CD-005";
        string CDLapRapNo = "CD-084";
        string CDSonNo = "CD-006";
        string CDDongGoiNo = "CD-007";
        string CDThanhPhamNo = "CD-110";

        #endregion


        public ProductionCostModule()
        {
            Name = "ProductionCost";
            CurrentModuleEntity = new ProductionCostEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            TaiDuLieuButtonEdit = (BOSButton)Controls[TaiDuLieuButtonEditName];
            TinhGiaAllButtonEdit = (BOSButton)Controls[TinhGiaAllButtonEditName];
            CapNhatAllButtonEdit = (BOSButton)Controls[CapNhatAllButtonEditName];

            ProductionCostIngredientIncompletePhoiGridControl = (MMProductionCostIngredientIncompletesGridControl)Controls[ProductionCostIngredientIncompletePhoiGridControlName];
            ProductionCostIngredientIncompleteSCGridControl = (MMProductionCostIngredientIncompleteSCsGridControl)Controls[ProductionCostIngredientIncompleteSCGridControlName];
            ProductionCostIngredientIncompleteTCGridControl = (MMProductionCostIngredientIncompleteTCsGridControl)Controls[ProductionCostIngredientIncompleteTCGridControlName];
            ProductionCostIngredientIncompleteLRGridControl = (MMProductionCostIngredientIncompleteLRsGridControl)Controls[ProductionCostIngredientIncompleteLRGridControlName];
            ProductionCostIngredientIncompleteSonGridControl = (MMProductionCostIngredientIncompleteSonsGridControl)Controls[ProductionCostIngredientIncompleteSonGridControlName];
            ProductionCostIngredientIncompleteDGGridControl = (MMProductionCostIngredientIncompleteDGsGridControl)Controls[ProductionCostIngredientIncompleteDGGridControlName];

            InitializeOverallProductionCostGridControls();

            TaiDuLieuButtonEdit.Enabled = false;
            TinhGiaAllButtonEdit.Enabled = false;
            CapNhatAllButtonEdit.Enabled = false;
        }

        protected override System.Data.DataSet GetSearchData(ref string searchQuery)
        {
            MMProductionCostsController objProductionCostsController = new MMProductionCostsController();
            MMProductionCostsInfo searchObject = (MMProductionCostsInfo)CurrentModuleEntity.SearchObject;

            DataSet ds = objProductionCostsController.GetProductionCostDataSearch(
                                                                        searchObject.MMProductionCostNo,
                                                                        ProductionCostType.ProductionCost.ToString(),
                                                                        searchObject.MMProductionCostFromDate,
                                                                        searchObject.MMProductionCostToDate);


            return ds;
        }

        public override void ActionEdit()
        {
            base.ActionEdit();
            TaiDuLieuButtonEdit.Enabled = true;
            TinhGiaAllButtonEdit.Enabled = true;
            CapNhatAllButtonEdit.Enabled = true;
        }

        public override void ActionNew()
        {
            base.ActionNew();

            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            objProductionCostsInfo.MMProductionCostFromDate = BOSUtil.GetMonthBeginDate();
            objProductionCostsInfo.MMProductionCostToDate = BOSUtil.GetMonthEndDate();
            objProductionCostsInfo.MMProductionCostStatus = MMProductionCostStatus.New.ToString();
            TaiDuLieuButtonEdit.Enabled = true;
            TinhGiaAllButtonEdit.Enabled = true;
            CapNhatAllButtonEdit.Enabled = true;
        }

        public void ValidateProductionCostByDate(bool isDateChange)
        {
            BOSProgressBar.Start(MESLocalizedResources.LoadingData);
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            objProductionCostsInfo.MMProductionCostStatus = MMProductionCostStatus.New.ToString();

            GetProductionCostItemByDate(objProductionCostsInfo.MMProductionCostFromDate,
                                                  objProductionCostsInfo.MMProductionCostToDate, isDateChange);

            InitializeProductionCostIngredientIncompleteGridControls(isDateChange);

            GetOverallProductionCostAmounts();
            BOSProgressBar.Close();
            TinhGiaAllButtonEdit.Enabled = true;
            CapNhatAllButtonEdit.Enabled = true;
        }

        public void GetProductionCostItemByDate(DateTime fromDate, DateTime toDate, bool isDateChange)
        {
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            MMProductionCostItemsController objProductionCostItemsController = new MMProductionCostItemsController();
            List<MMProductionCostItemsInfo> productionCostItemList = new List<MMProductionCostItemsInfo>();
            productionCostItemList = objProductionCostItemsController.GetProductionCostItemByDate(fromDate, toDate);
            List<MMProductionCostItemsInfo> productionCostItemListToAdd = new List<MMProductionCostItemsInfo>();

            foreach (MMProductionCostItemsInfo item in productionCostItemList)
            {
                productionCostItemListToAdd.Add(item);
            }
            if (isDateChange)
            {
                entity.ProductionCostItemList.Clear();
                entity.ProductionCostIngredientCostListPhoi.Clear();
                entity.ProductionCostIngredientCostListSC.Clear();
                entity.ProductionCostIngredientCostListTC.Clear();
                entity.ProductionCostIngredientCostListLR.Clear();
                entity.ProductionCostIngredientCostListSon.Clear();
                entity.ProductionCostIngredientCostListDG.Clear();
                entity.ProductionCostItemList.AddRange(productionCostItemListToAdd);
            }
            else
            {
                entity.ProductionCostItemList.Invalidate(productionCostItemListToAdd);
            }
            entity.ProductionCostItemList.GridControl.InitGridControlDataSource();
            entity.ProductionCostItemList.GridControl?.RefreshDataSource();

            // Get shipment and receipt by Operation
            MMProductionCostIngredientCostsController objPhoiController = new MMProductionCostIngredientCostsController();
            MMProductionCostIngredientCostSCsController objSCController = new MMProductionCostIngredientCostSCsController();
            MMProductionCostIngredientCostTCsController objTCController = new MMProductionCostIngredientCostTCsController();
            MMProductionCostIngredientCostLRsController objLRController = new MMProductionCostIngredientCostLRsController();
            MMProductionCostIngredientCostSonsController objSonController = new MMProductionCostIngredientCostSonsController();
            MMProductionCostIngredientCostDGsController objDGController = new MMProductionCostIngredientCostDGsController();

            List<int> batchProductList = new List<int>();

            MMOperationsController objOperationsController = new MMOperationsController();
            //List<MMOperationsInfo> operationsList = objOperationsController.GetOperationListForProductionCost2();
            MMOperationsInfo cdPhoi = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDPhoiNo);
            MMOperationsInfo cdSC = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDSoCheNo);
            MMOperationsInfo cdTC = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDTinhCheNo);
            MMOperationsInfo cdLR = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDLapRapNo);
            MMOperationsInfo cdSon = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDSonNo);
            MMOperationsInfo cdDG = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDDongGoiNo);

            //decimal percent = 0;
            //decimal percentStr = 0;
            //foreach (MMProductionCostItemsInfo item in entity.ProductionCostItemList)
            //{
            //    percent++;
            //    percentStr = (percent * 100) / entity.ProductionCostItemList.Count;
            //    BOSProgressBar.Start("Đang tải dữ liệu " + Math.Round(percentStr) + " % ");
            //    if (!batchProductList.Contains(item.FK_MMBatchProductID))
            //    {
            //        entity.ProductionCostIngredientCostListPhoi.AddRange(objPhoiController.GetProductionCostIngredientCostByDateAndBatchIDAndOperationID(fromDate, toDate,
            //                item.FK_MMBatchProductID, cdPhoi.MMOperationID));
            //        entity.ProductionCostIngredientCostListSC.AddRange(objSCController.GetProductionCostIngredientCostByDateAndBatchIDAndOperationID(fromDate, toDate,
            //                item.FK_MMBatchProductID, cdSC.MMOperationID));
            //        entity.ProductionCostIngredientCostListTC.AddRange(objTCController.GetProductionCostIngredientCostByDateAndBatchIDAndOperationID(fromDate, toDate,
            //                item.FK_MMBatchProductID, cdTC.MMOperationID));
            //        entity.ProductionCostIngredientCostListLR.AddRange(objLRController.GetProductionCostIngredientCostByDateAndBatchIDAndOperationID(fromDate, toDate,
            //                item.FK_MMBatchProductID, cdLR.MMOperationID));
            //        entity.ProductionCostIngredientCostListSon.AddRange(objSonController.GetProductionCostIngredientCostByDateAndBatchIDAndOperationID(fromDate, toDate,
            //                item.FK_MMBatchProductID, cdSon.MMOperationID));
            //        entity.ProductionCostIngredientCostListDG.AddRange(objDGController.GetProductionCostIngredientCostByDateAndBatchIDAndOperationID(fromDate, toDate,
            //                item.FK_MMBatchProductID, cdDG.MMOperationID));
            //        batchProductList.Add(item.FK_MMBatchProductID);
            //    }
            //}          

            entity.ProductionCostIngredientCostListPhoi.AddRange(
                objPhoiController.GetProductionCostIngredientCostByDateAndBatchIDAndOperationID(fromDate, toDate, 0, cdPhoi.MMOperationID));
            entity.ProductionCostIngredientCostListSC.AddRange(
                objSCController.GetProductionCostIngredientCostByDateAndBatchIDAndOperationID(fromDate, toDate, 0, cdSC.MMOperationID));
            entity.ProductionCostIngredientCostListTC.AddRange(
                objTCController.GetProductionCostIngredientCostByDateAndBatchIDAndOperationID(fromDate, toDate, 0, cdTC.MMOperationID));
            entity.ProductionCostIngredientCostListLR.AddRange(
                objLRController.GetProductionCostIngredientCostByDateAndBatchIDAndOperationID(fromDate, toDate, 0, cdLR.MMOperationID));
            entity.ProductionCostIngredientCostListSon.AddRange(
                objSonController.GetProductionCostIngredientCostByDateAndBatchIDAndOperationID(fromDate, toDate, 0, cdSon.MMOperationID));
            entity.ProductionCostIngredientCostListDG.AddRange(
                objDGController.GetProductionCostIngredientCostByDateAndBatchIDAndOperationID(fromDate, toDate, 0, cdDG.MMOperationID));

            // Load dở dang tháng trước
            DateTime prevFrom = objProductionCostsInfo.MMProductionCostFromDate.AddMonths(-1);
            DateTime prevTo = prevFrom.AddMonths(1).AddDays(-1);
            MMProductionCostsController objProductionCostsController = new MMProductionCostsController();
            MMProductionCostsInfo prevProductionCostsInfo = objProductionCostsController.GetProductionCostByDate(prevFrom, prevTo);
            MMProductionCostIngredientCostsController objDDPhoi = new MMProductionCostIngredientCostsController();
            MMProductionCostIngredientCostSCsController objDDSC = new MMProductionCostIngredientCostSCsController();
            MMProductionCostIngredientCostTCsController objDDTC = new MMProductionCostIngredientCostTCsController();
            MMProductionCostIngredientCostLRsController objDDLR = new MMProductionCostIngredientCostLRsController();
            MMProductionCostIngredientCostSonsController objDDSon = new MMProductionCostIngredientCostSonsController();
            MMProductionCostIngredientCostDGsController objDDDG = new MMProductionCostIngredientCostDGsController();
            if (prevProductionCostsInfo != null)
            {
                List<MMProductionCostIngredientCostsInfo> ddPhoi = objDDPhoi.GetDDPhoiByProductionCostID(prevProductionCostsInfo.MMProductionCostID);
                entity.ProductionCostIngredientCostListPhoi.AddRange(ddPhoi);

                List<MMProductionCostIngredientCostSCsInfo> ddSC = objDDSC.GetDDSCByProductionCostID(prevProductionCostsInfo.MMProductionCostID);
                entity.ProductionCostIngredientCostListSC.AddRange(ddSC);

                List<MMProductionCostIngredientCostTCsInfo> ddTC = objDDTC.GetDDTCByProductionCostID(prevProductionCostsInfo.MMProductionCostID);
                entity.ProductionCostIngredientCostListTC.AddRange(ddTC);

                List<MMProductionCostIngredientCostLRsInfo> ddLR = objDDLR.GetDDLRByProductionCostID(prevProductionCostsInfo.MMProductionCostID);
                entity.ProductionCostIngredientCostListLR.AddRange(ddLR);

                List<MMProductionCostIngredientCostSonsInfo> ddSon = objDDSon.GetDDSonByProductionCostID(prevProductionCostsInfo.MMProductionCostID);
                entity.ProductionCostIngredientCostListSon.AddRange(ddSon);

                List<MMProductionCostIngredientCostDGsInfo> ddDG = objDDDG.GetDDDGByProductionCostID(prevProductionCostsInfo.MMProductionCostID);
                entity.ProductionCostIngredientCostListDG.AddRange(ddDG);
            }

            //InitializeProductionCostIngredientIncompleteGridControls(isDateChange);

            entity.ProductionCostIngredientCostListPhoi.GridControl.InitGridControlDataSource();
            entity.ProductionCostIngredientCostListSC.GridControl.InitGridControlDataSource();
            entity.ProductionCostIngredientCostListTC.GridControl.InitGridControlDataSource();
            entity.ProductionCostIngredientCostListLR.GridControl.InitGridControlDataSource();
            entity.ProductionCostIngredientCostListSon.GridControl.InitGridControlDataSource();
            entity.ProductionCostIngredientCostListDG.GridControl.InitGridControlDataSource();

            if (isDateChange)
            {
                List<MMProductionCostIngredientCostsInfo> klList = entity.ProductionCostIngredientCostListPhoi.Where(t => t.MMProductionCostIngredientCostReferenceType == ProductionCostIngredientCostReferenceType.NhapKho
                                                            && t.MMProductionCostIngredientCostReferenceTypeCombo == ReceiptType.SemiProductReceipt.ToString()).ToList();
                if (klList != null)
                {
                    objProductionCostsInfo.MMProductionCostWoodQtyPhoi = klList.Sum(i => i.MMProductionCostIngredientCostProductWoodQty);
                }
                objProductionCostsInfo.MMProductionCostDepreciationFeePhoi = entity.ProductionCostIngredientCostListPhoi.Sum(i => i.MMProductionCostIngredientCostDepreciationFee);
                objProductionCostsInfo.MMProductionCostElecFeePhoi = entity.ProductionCostIngredientCostListPhoi.Sum(i => i.MMProductionCostIngredientCostElecFee);
                objProductionCostsInfo.MMProductionCostHardwareFeePhoi = entity.ProductionCostIngredientCostListPhoi.Sum(i => i.MMProductionCostIngredientCostHardwareFee);
                objProductionCostsInfo.MMProductionCostOtherFeePhoi = entity.ProductionCostIngredientCostListPhoi.Sum(i => i.MMProductionCostIngredientCostOtherFee);
                objProductionCostsInfo.MMProductionCostPackagingFeePhoi = entity.ProductionCostIngredientCostListPhoi.Sum(i => i.MMProductionCostIngredientCostMaintainFee);
                objProductionCostsInfo.MMProductionCostPaintFeePhoi = entity.ProductionCostIngredientCostListPhoi.Sum(i => i.MMProductionCostIngredientCostPaintFee);
                objProductionCostsInfo.MMProductionCostWoodFeePhoi = entity.ProductionCostIngredientCostListPhoi.Sum(i => i.MMProductionCostIngredientCostWoodFee);

                List<MMProductionCostIngredientCostSCsInfo> klscList = entity.ProductionCostIngredientCostListSC.Where(t => t.MMProductionCostIngredientCostSCReferenceType == ProductionCostIngredientCostReferenceType.NhapKho).ToList();
                if (klscList != null)
                {
                    objProductionCostsInfo.MMProductionCostWoodQtySoChe = klscList.Sum(i => i.MMProductionCostIngredientCostSCProductWoodQty);
                }
                objProductionCostsInfo.MMProductionCostDepreciationFeeSoChe = entity.ProductionCostIngredientCostListSC.Sum(i => i.MMProductionCostIngredientCostSCDepreciationFee);
                objProductionCostsInfo.MMProductionCostElecFeeSoChe = entity.ProductionCostIngredientCostListSC.Sum(i => i.MMProductionCostIngredientCostSCElecFee);
                objProductionCostsInfo.MMProductionCostHardwareFeeSoChe = entity.ProductionCostIngredientCostListSC.Sum(i => i.MMProductionCostIngredientCostSCHardwareFee);
                objProductionCostsInfo.MMProductionCostOtherFeeSoChe = entity.ProductionCostIngredientCostListSC.Sum(i => i.MMProductionCostIngredientCostSCOtherFee);
                objProductionCostsInfo.MMProductionCostPackagingFeeSoChe = entity.ProductionCostIngredientCostListSC.Sum(i => i.MMProductionCostIngredientCostSCMaintainFee);
                objProductionCostsInfo.MMProductionCostPaintFeeSoChe = entity.ProductionCostIngredientCostListSC.Sum(i => i.MMProductionCostIngredientCostSCPaintFee);
                objProductionCostsInfo.MMProductionCostWoodFeeSoChe = entity.ProductionCostIngredientCostListSC.Sum(i => i.MMProductionCostIngredientCostSCWoodFee);

                List<MMProductionCostIngredientCostTCsInfo> kltcList = entity.ProductionCostIngredientCostListTC.Where(t => t.MMProductionCostIngredientCostTCReferenceType == ProductionCostIngredientCostReferenceType.NhapKho).ToList();
                if (kltcList != null)
                {
                    objProductionCostsInfo.MMProductionCostWoodQtyTinhChe = kltcList.Sum(i => i.MMProductionCostIngredientCostTCProductWoodQty);
                }
                objProductionCostsInfo.MMProductionCostDepreciationFeeTinhChe = entity.ProductionCostIngredientCostListTC.Sum(i => i.MMProductionCostIngredientCostTCDepreciationFee);
                objProductionCostsInfo.MMProductionCostElecFeeTinhChe = entity.ProductionCostIngredientCostListTC.Sum(i => i.MMProductionCostIngredientCostTCElecFee);
                objProductionCostsInfo.MMProductionCostHardwareFeeTinhChe = entity.ProductionCostIngredientCostListTC.Sum(i => i.MMProductionCostIngredientCostTCHardwareFee);
                objProductionCostsInfo.MMProductionCostOtherFeeTinhChe = entity.ProductionCostIngredientCostListTC.Sum(i => i.MMProductionCostIngredientCostTCOtherFee);
                objProductionCostsInfo.MMProductionCostPackagingFeeTinhChe = entity.ProductionCostIngredientCostListTC.Sum(i => i.MMProductionCostIngredientCostTCMaintainFee);
                objProductionCostsInfo.MMProductionCostPaintFeeTinhChe = entity.ProductionCostIngredientCostListTC.Sum(i => i.MMProductionCostIngredientCostTCPaintFee);
                objProductionCostsInfo.MMProductionCostWoodFeeTinhChe = entity.ProductionCostIngredientCostListTC.Sum(i => i.MMProductionCostIngredientCostTCWoodFee);

                List<MMProductionCostIngredientCostSonsInfo> klSonList = entity.ProductionCostIngredientCostListSon.Where(t => t.MMProductionCostIngredientCostSonReferenceType == ProductionCostIngredientCostReferenceType.NhapKho).ToList();
                if (klSonList != null)
                {
                    objProductionCostsInfo.MMProductionCostWoodQtySon = klSonList.Sum(i => i.MMProductionCostIngredientCostSonProductWoodQty);
                }
                objProductionCostsInfo.MMProductionCostDepreciationFeeSon = entity.ProductionCostIngredientCostListSon.Sum(i => i.MMProductionCostIngredientCostSonDepreciationFee);
                objProductionCostsInfo.MMProductionCostElecFeeSon = entity.ProductionCostIngredientCostListSon.Sum(i => i.MMProductionCostIngredientCostSonElecFee);
                objProductionCostsInfo.MMProductionCostHardwareFeeSon = entity.ProductionCostIngredientCostListSon.Sum(i => i.MMProductionCostIngredientCostSonHardwareFee);
                objProductionCostsInfo.MMProductionCostOtherFeeSon = entity.ProductionCostIngredientCostListSon.Sum(i => i.MMProductionCostIngredientCostSonOtherFee);
                objProductionCostsInfo.MMProductionCostPackagingFeeSon = entity.ProductionCostIngredientCostListSon.Sum(i => i.MMProductionCostIngredientCostSonMaintainFee);
                objProductionCostsInfo.MMProductionCostPaintFeeSon = entity.ProductionCostIngredientCostListSon.Sum(i => i.MMProductionCostIngredientCostSonPaintFee);
                objProductionCostsInfo.MMProductionCostWoodFeeSon = entity.ProductionCostIngredientCostListSon.Sum(i => i.MMProductionCostIngredientCostSonWoodFee);

                List<MMProductionCostIngredientCostLRsInfo> klLRList = entity.ProductionCostIngredientCostListLR.Where(t => t.MMProductionCostIngredientCostLRReferenceType == ProductionCostIngredientCostReferenceType.NhapKho).ToList();
                if (klLRList != null)
                {
                    objProductionCostsInfo.MMProductionCostWoodQtyLapRap = klLRList.Sum(i => i.MMProductionCostIngredientCostLRProductWoodQty);
                }
                objProductionCostsInfo.MMProductionCostDepreciationFeeLapRap = entity.ProductionCostIngredientCostListLR.Sum(i => i.MMProductionCostIngredientCostLRDepreciationFee);
                objProductionCostsInfo.MMProductionCostElecFeeLapRap = entity.ProductionCostIngredientCostListLR.Sum(i => i.MMProductionCostIngredientCostLRElecFee);
                objProductionCostsInfo.MMProductionCostHardwareFeeLapRap = entity.ProductionCostIngredientCostListLR.Sum(i => i.MMProductionCostIngredientCostLRHardwareFee);
                objProductionCostsInfo.MMProductionCostOtherFeeLapRap = entity.ProductionCostIngredientCostListLR.Sum(i => i.MMProductionCostIngredientCostLROtherFee);
                objProductionCostsInfo.MMProductionCostPackagingFeeLapRap = entity.ProductionCostIngredientCostListLR.Sum(i => i.MMProductionCostIngredientCostLRMaintainFee);
                objProductionCostsInfo.MMProductionCostPaintFeeLapRap = entity.ProductionCostIngredientCostListLR.Sum(i => i.MMProductionCostIngredientCostLRPaintFee);
                objProductionCostsInfo.MMProductionCostWoodFeeLapRap = entity.ProductionCostIngredientCostListLR.Sum(i => i.MMProductionCostIngredientCostLRWoodFee);

                List<MMProductionCostIngredientCostDGsInfo> klDGList = entity.ProductionCostIngredientCostListDG.Where(t => t.MMProductionCostIngredientCostDGReferenceType == ProductionCostIngredientCostReferenceType.NhapKho).ToList();
                if (klDGList != null)
                {
                    objProductionCostsInfo.MMProductionCostWoodQtyDongGoi = klDGList.Sum(i => i.MMProductionCostIngredientCostDGProductWoodQty);
                }
                objProductionCostsInfo.MMProductionCostDepreciationFeeDongGoi = entity.ProductionCostIngredientCostListDG.Sum(i => i.MMProductionCostIngredientCostDGDepreciationFee);
                objProductionCostsInfo.MMProductionCostElecFeeDongGoi = entity.ProductionCostIngredientCostListDG.Sum(i => i.MMProductionCostIngredientCostDGElecFee);
                objProductionCostsInfo.MMProductionCostHardwareFeeDongGoi = entity.ProductionCostIngredientCostListDG.Sum(i => i.MMProductionCostIngredientCostDGHardwareFee);
                objProductionCostsInfo.MMProductionCostOtherFeeDongGoi = entity.ProductionCostIngredientCostListDG.Sum(i => i.MMProductionCostIngredientCostDGOtherFee);
                objProductionCostsInfo.MMProductionCostPackagingFeeDongGoi = entity.ProductionCostIngredientCostListDG.Sum(i => i.MMProductionCostIngredientCostDGMaintainFee);
                objProductionCostsInfo.MMProductionCostPaintFeeDongGoi = entity.ProductionCostIngredientCostListDG.Sum(i => i.MMProductionCostIngredientCostDGPaintFee);
                objProductionCostsInfo.MMProductionCostWoodFeeDongGoi = entity.ProductionCostIngredientCostListDG.Sum(i => i.MMProductionCostIngredientCostDGWoodFee);

                objProductionCostsInfo.MMProductionCostWoodQty = objProductionCostsInfo.MMProductionCostWoodQtyPhoi
                                                    + objProductionCostsInfo.MMProductionCostWoodQtySoChe
                                                    + objProductionCostsInfo.MMProductionCostWoodQtyTinhChe
                                                    + objProductionCostsInfo.MMProductionCostWoodQtyLapRap
                                                    + objProductionCostsInfo.MMProductionCostWoodQtySon
                                                    + objProductionCostsInfo.MMProductionCostWoodQtyDongGoi;
            }

        }

        public string GetReferenceTypeText(string group, string value)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ADConfigValuesInfo objADConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue(group, value);
            if (objADConfigValuesInfo != null)
                return objADConfigValuesInfo.ADConfigText;
            return string.Empty;
        }

        public void AdjustCostOfGoodsSold()
        {
            ExecUpdateCostOprationPhoi();
            ExecUpdateCostOprationSC();
            ExecUpdateCostOprationTC();
            ExecUpdateCostOprationLR();
            ExecUpdateCostOprationSon();
            ExecUpdateCostOprationDG();
        }

        private void InitializeProductionCostIngredientIncompleteGridControls(bool isCal)
        {
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;

            List<int> batchProductIDList = entity.ProductionCostItemList.Select(item => item.FK_MMBatchProductID).Distinct().ToList();
            BindingDataSourceIncompletePhoi(isCal, batchProductIDList);
            BindingDataSourceIncompleteSC(isCal, batchProductIDList);
            BindingDataSourceIncompleteTC(isCal, batchProductIDList);
            BindingDataSourceIncompleteLR(isCal, batchProductIDList);
            BindingDataSourceIncompleteSon(isCal, batchProductIDList);
            BindingDataSourceIncompleteDG(isCal, batchProductIDList);
        }


        public override int ActionSave()
        {
            int id = base.ActionSave();
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            MMProductionCostItemsController objProductionCostItemsController = new MMProductionCostItemsController();
            MMProductionCostIngredientCostsController objPhoi = new MMProductionCostIngredientCostsController();
            MMProductionCostIngredientCostSCsController objSC = new MMProductionCostIngredientCostSCsController();
            MMProductionCostIngredientCostTCsController objTC = new MMProductionCostIngredientCostTCsController();
            MMProductionCostIngredientCostLRsController objLR = new MMProductionCostIngredientCostLRsController();
            MMProductionCostIngredientCostSonsController objSon = new MMProductionCostIngredientCostSonsController();
            MMProductionCostIngredientCostDGsController objDG = new MMProductionCostIngredientCostDGsController();

            MMProductionCostIngredientCostDDsController objDDPhoi = new MMProductionCostIngredientCostDDsController();
            MMProductionCostIngredientCostDDSCsController objDDSC = new MMProductionCostIngredientCostDDSCsController();
            MMProductionCostIngredientCostDDTCsController objDDTC = new MMProductionCostIngredientCostDDTCsController();
            MMProductionCostIngredientCostDDLRsController objDDLR = new MMProductionCostIngredientCostDDLRsController();
            MMProductionCostIngredientCostDDSonsController objDDSon = new MMProductionCostIngredientCostDDSonsController();
            MMProductionCostIngredientCostDDDGsController objDDDG = new MMProductionCostIngredientCostDDDGsController();

            BOSDbUtil dbUtil = new BOSDbUtil();
            dbUtil.ExecuteNonQuery("ResetAllDataByProductionCostID", id);

            BOSProgressBar.Start("Đang lưu dữ liệu");
            foreach (MMProductionCostItemsInfo item in entity.ProductionCostItemList)
            {
                item.FK_MMProductionCostID = id;
                if (item.MMProductionCostItemID > 0)
                {
                    objProductionCostItemsController.UpdateObject(item);
                }
                else
                {
                    objProductionCostItemsController.CreateObject(item);
                }
            }

            BOSProgressBar.Start("Đang lưu dữ liệu dở dang");
            foreach (MMProductionCostIngredientCostDDsInfo item in entity.ProductionCostIngredientCostListDDPhoi)
            {
                item.FK_MMProductionCostID = id;
                if (item.MMProductionCostIngredientCostDDID > 0)
                {
                    objDDPhoi.UpdateObject(item);
                }
                else
                {
                    objDDPhoi.CreateObject(item);
                }
            }

            foreach (MMProductionCostIngredientCostDDSCsInfo item in entity.ProductionCostIngredientCostListDDSC)
            {
                item.FK_MMProductionCostID = id;
                if (item.MMProductionCostIngredientCostDDSCID > 0)
                {
                    objDDSC.UpdateObject(item);
                }
                else
                {
                    objDDSC.CreateObject(item);
                }
            }

            foreach (MMProductionCostIngredientCostDDTCsInfo item in entity.ProductionCostIngredientCostListDDTC)
            {
                item.FK_MMProductionCostID = id;
                if (item.MMProductionCostIngredientCostDDTCID > 0)
                {
                    objDDTC.UpdateObject(item);
                }
                else
                {
                    objDDTC.CreateObject(item);
                }
            }

            foreach (MMProductionCostIngredientCostDDLRsInfo item in entity.ProductionCostIngredientCostListDDLR)
            {
                item.FK_MMProductionCostID = id;
                if (item.MMProductionCostIngredientCostDDLRID > 0)
                {
                    objDDLR.UpdateObject(item);
                }
                else
                {
                    objDDLR.CreateObject(item);
                }
            }
            BOSProgressBar.Start("Đang lưu dữ liệu TGT");
            foreach (MMProductionCostIngredientCostDDSonsInfo item in entity.ProductionCostIngredientCostListDDSon)
            {
                //decimal value = 0;
                //decimal.TryParse (item.MMProductionCostIngredientCostDDSonProductUnitCost.ToString(), out value);
                //item.MMProductionCostIngredientCostDDSonProductUnitCost = value;
                item.FK_MMProductionCostID = id;
                if (item.MMProductionCostIngredientCostDDSonID > 0)
                {
                    objDDSon.UpdateObject(item);
                }
                else
                {
                    objDDSon.CreateObject(item);
                }
            }

            foreach (MMProductionCostIngredientCostDDDGsInfo item in entity.ProductionCostIngredientCostListDDDG)
            {
                item.FK_MMProductionCostID = id;
                if (item.MMProductionCostIngredientCostDDDGID > 0)
                {
                    objDDDG.UpdateObject(item);
                }
                else
                {
                    objDDDG.CreateObject(item);
                }
            }

            foreach (MMProductionCostIngredientCostsInfo item in entity.ProductionCostIngredientCostListPhoi)
            {
                item.FK_MMProductionCostID = id;
                if (item.MMProductionCostIngredientCostID > 0)
                {
                    objPhoi.UpdateObject(item);
                }
                else
                {
                    objPhoi.CreateObject(item);
                }
            }

            foreach (MMProductionCostIngredientCostSCsInfo item in entity.ProductionCostIngredientCostListSC)
            {
                item.FK_MMProductionCostID = id;
                if (item.MMProductionCostIngredientCostSCID > 0)
                {
                    objSC.UpdateObject(item);
                }
                else
                {
                    objSC.CreateObject(item);
                }
            }

            foreach (MMProductionCostIngredientCostTCsInfo item in entity.ProductionCostIngredientCostListTC)
            {
                item.FK_MMProductionCostID = id;
                if (item.MMProductionCostIngredientCostTCID > 0)
                {
                    objTC.UpdateObject(item);
                }
                else
                {
                    objTC.CreateObject(item);
                }
            }

            foreach (MMProductionCostIngredientCostLRsInfo item in entity.ProductionCostIngredientCostListLR)
            {
                item.FK_MMProductionCostID = id;
                if (item.MMProductionCostIngredientCostLRID > 0)
                {
                    objLR.UpdateObject(item);
                }
                else
                {
                    objLR.CreateObject(item);
                }
            }

            foreach (MMProductionCostIngredientCostSonsInfo item in entity.ProductionCostIngredientCostListSon)
            {
                item.FK_MMProductionCostID = id;
                if (item.MMProductionCostIngredientCostSonID > 0)
                {
                    objSon.UpdateObject(item);
                }
                else
                {
                    objSon.CreateObject(item);
                }
            }

            foreach (MMProductionCostIngredientCostDGsInfo item in entity.ProductionCostIngredientCostListDG)
            {
                item.FK_MMProductionCostID = id;
                if (item.MMProductionCostIngredientCostDGID > 0)
                {
                    objDG.UpdateObject(item);
                }
                else
                {
                    objDG.CreateObject(item);
                }
            }

            BOSProgressBar.Close();
            return id;
        }

        private List<int> CompletedBatchProductIDs_Phoi()
        {
            List<int> collection = new List<int>();

            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            string[] separators = { ",", ";", " " };
            List<string> batchProductNos = new List<string>();
            if (!string.IsNullOrEmpty(objProductionCostsInfo.BatchProductNo_Phoi))
                batchProductNos = objProductionCostsInfo.BatchProductNo_Phoi.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (string batchProductNo in batchProductNos)
            {
                int batchProductID = entity.ProductionCostItemList.Where(item => item.MMBatchProductNo == batchProductNo)
                                                        .Select(item => item.FK_MMBatchProductID).FirstOrDefault();
                if (batchProductID != 0)
                    collection.Add(batchProductID);
            }

            return collection;
        }

        private void BindingDataSourceIncompletePhoi(bool isCal, List<int> batchProductIDList)
        {
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;

            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDPhoiNo);

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            //List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            //List<ICReceiptItemsInfo> receiptItemList = new List<ICReceiptItemsInfo>();

            //List<int> batchProductIDList = new List<int>();
            MMProductionCostIngredientCostDDsInfo objProductionCostIngredientCostsInfo = null;
            ICShipmentsController objShipmentController = new ICShipmentsController();
            List<MMProductionCostIngredientCostDDsInfo> incompleteList = new List<MMProductionCostIngredientCostDDsInfo>();
            MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();
            MMWoodPlanItemDetailsController objWoodPlanItemDetailsController = new MMWoodPlanItemDetailsController();

            List<MMProductionCostIngredientCostsInfo> xuatPhoi = new List<MMProductionCostIngredientCostsInfo>();
            ICShipmentItemsInfo itemShipment = null;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo = null;
            List<MMProductionCostIngredientCostsInfo> receiptItemList;
            List<MMProductionCostIngredientCostsInfo> shipmentItemList = new List<MMProductionCostIngredientCostsInfo>();

            Dictionary<int, MMProductionCostIngredientCostsInfo> collection = new Dictionary<int, MMProductionCostIngredientCostsInfo>();

            List<int> completedBatchProductIDs = CompletedBatchProductIDs_Phoi();

            //foreach (MMProductionCostItemsInfo productPrice in entity.ProductionCostItemList)
            foreach (int batchProductID in batchProductIDList)
            {
                //if (!batchProductIDList.Contains(productPrice.FK_MMBatchProductID))
                {
                    if (batchProductID == 1356 || batchProductID == 1391)
                    {
                        string a = "";
                    }


                    //if (batchProductID == 573 || batchProductID == 745 || batchProductID == 772 || batchProductID == 776 || batchProductID == 784)
                    //{
                    //    //continue;
                    //    string a = "a";
                    //}
                    //shipmentItemList = objShipmentItemsController.GetShipmentItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    //shipmentItemList.Clear();
                    xuatPhoi = entity.ProductionCostIngredientCostListPhoi.Where(p => p.FK_MMBatchProductID == batchProductID
                        && p.MMProductionCostIngredientCostReferenceType == ProductionCostIngredientCostReferenceType.XuatKho)
                        .OrderBy(item => item.FK_ICProductSerieID).ToList();
                    //foreach (MMProductionCostIngredientCostsInfo item in xuatPhoi)
                    //{

                    //    itemShipment = new ICShipmentItemsInfo();
                    //    BOSUtil.CopyObject(item, itemShipment);                        
                    //    //objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.MMProductionCostIngredientCostProductSerialNo);
                    //    //if (objProductSeriesInfo != null)
                    //    //{
                    //    //    itemShipment.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                    //    //}
                    //    itemShipment.FK_ICProductID = item.FK_ICProductID;
                    //    itemShipment.FK_MMBatchProductID = item.FK_MMBatchProductID;
                    //    itemShipment.ICShipmentItemProductQty = item.MMProductionCostIngredientCostProductQty;
                    //    itemShipment.ICShipmentItemWoodQty = item.MMProductionCostIngredientCostProductWoodQty;
                    //    itemShipment.ICShipmentItemProductUnitPrice = item.MMProductionCostIngredientCostProductUnitCost;
                    //    itemShipment.ICShipmentItemTotalAmount = item.MMProductionCostIngredientCostTotalCost;
                    //    itemShipment.ICShipmentNo = item.MMProductionCostIngredientCostReferenceNo;
                    //    itemShipment.MMBatchProductNo = item.MMProductionCostIngredientCostBatchProductNo;
                    //    itemShipment.MMOperationName = item.MMProductionCostIngredientCostOperationName;
                    //    itemShipment.ICMeasureUnitName = item.MMProductionCostIngredientCostMeasureUnitName;
                    //    itemShipment.ICStockName = item.MMProductionCostIngredientCostStockName;
                    //    itemShipment.ICProductNo = item.MMProductionCostIngredientCostProductNo;
                    //    itemShipment.FK_ICShipmentID = item.FK_ICReferenceID;
                    //    //ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByNo(item.MMProductionCostIngredientCostReferenceNo);
                    //    //if (objShipmentInfo!=null)
                    //    //{
                    //    //    itemShipment.FK_ICShipmentID = objShipmentInfo.ICShipmentID;
                    //    //    itemShipment.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                    //    //    itemShipment.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                    //    //}
                    //    shipmentItemList.Add(itemShipment);
                    //}
                    //receiptItemList = objReceiptItemsController.GetReceiptItemByBatchProductIDAndOperationIDAndDate(batchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    receiptItemList = entity.ProductionCostIngredientCostListPhoi.Where(item => item.FK_MMBatchProductID == batchProductID
                                                                                    && item.FK_MMOperationID == objOperationsInfo.MMOperationID
                                                                                    && item.MMProductionCostIngredientCostReferenceNo.IndexOf("NKPK") >= 0).ToList();

                    collection.Clear();
                    shipmentItemList.Clear();

                    foreach (MMProductionCostIngredientCostsInfo receiptItem in receiptItemList)
                    {
                        //if (receiptItem.MMProductionCostIngredientCostProductUnitCost != 0)
                        {
                            //string key = receiptItem.FK_ICProductID + "-" + receiptItem.FK_ICProductSerieID;
                            if (!collection.Keys.Contains(receiptItem.FK_ICProductID))
                                collection.Add(receiptItem.FK_ICProductID, new MMProductionCostIngredientCostsInfo());
                            collection[receiptItem.FK_ICProductID].MMProductionCostIngredientCostProductQty += receiptItem.MMProductionCostIngredientCostProductQty;
                            collection[receiptItem.FK_ICProductID].MMProductionCostIngredientCostTotalCost += receiptItem.MMProductionCostIngredientCostTotalCost;
                        }
                    }

                    foreach (int key in collection.Keys)
                    {
                        if (collection[key].MMProductionCostIngredientCostProductQty != 0)
                            collection[key].MMProductionCostIngredientCostProductUnitCost = collection[key].MMProductionCostIngredientCostTotalCost / collection[key].MMProductionCostIngredientCostProductQty;
                    }

                    foreach (MMProductionCostIngredientCostsInfo shipmentItem in xuatPhoi)
                    {
                        int key = shipmentItem.FK_ICProductID;
                        decimal remainQty = 0;
                        decimal value = 0;
                        if (collection.Keys.Contains(key) &&
                            (collection[key].MMProductionCostIngredientCostProductQty > 0 ||
                            collection[key].MMProductionCostIngredientCostTotalCost > 0))
                        {
                            remainQty = Math.Min(shipmentItem.MMProductionCostIngredientCostProductQty, collection[key].MMProductionCostIngredientCostProductQty);
                            value = Math.Min(shipmentItem.MMProductionCostIngredientCostTotalCost, collection[key].MMProductionCostIngredientCostTotalCost);
                            collection[key].MMProductionCostIngredientCostProductQty -= remainQty;
                            collection[key].MMProductionCostIngredientCostTotalCost -= value;
                        }
                        if (shipmentItem.MMProductionCostIngredientCostProductQty != remainQty ||
                            shipmentItem.MMProductionCostIngredientCostTotalCost != value)
                        {
                            MMProductionCostIngredientCostsInfo shipmentItem1 = new MMProductionCostIngredientCostsInfo();
                            BOSUtil.CopyObject(shipmentItem, shipmentItem1);
                            shipmentItem1.MMProductionCostIngredientCostProductQty = shipmentItem.MMProductionCostIngredientCostProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostProductWoodQty = shipmentItem.MMProductionCostIngredientCostProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostTotalCost = shipmentItem1.MMProductionCostIngredientCostTotalCost - value;
                            //shipmentItem1.MMProductionCostIngredientCostTotalCost = shipmentItem1.MMProductionCostIngredientCostProductQty * shipmentItem1.MMProductionCostIngredientCostProductUnitCost;
                            if (shipmentItem1.MMProductionCostIngredientCostProductQty != 0)
                                shipmentItem1.MMProductionCostIngredientCostProductUnitCost = shipmentItem1.MMProductionCostIngredientCostTotalCost / shipmentItem1.MMProductionCostIngredientCostProductQty;
                            shipmentItemList.Add(shipmentItem1);
                        }

                        //if (shipmentItem.MMProductionCostIngredientCostProductQty > remainQty)
                        //{
                        //    MMProductionCostIngredientCostsInfo shipmentItem1 = new MMProductionCostIngredientCostsInfo();
                        //    BOSUtil.CopyObject(shipmentItem, shipmentItem1);
                        //    shipmentItem1.MMProductionCostIngredientCostProductQty = shipmentItem.MMProductionCostIngredientCostProductQty - remainQty;
                        //    shipmentItem1.MMProductionCostIngredientCostProductWoodQty = shipmentItem.MMProductionCostIngredientCostProductQty - remainQty;
                        //    shipmentItem1.MMProductionCostIngredientCostTotalCost = shipmentItem1.MMProductionCostIngredientCostTotalCost - value;
                        //    //shipmentItem1.MMProductionCostIngredientCostTotalCost = shipmentItem1.MMProductionCostIngredientCostProductQty * shipmentItem1.MMProductionCostIngredientCostProductUnitCost;
                        //    if (shipmentItem1.MMProductionCostIngredientCostProductQty != 0)
                        //        shipmentItem1.MMProductionCostIngredientCostProductUnitCost = shipmentItem1.MMProductionCostIngredientCostTotalCost / shipmentItem1.MMProductionCostIngredientCostProductQty;
                        //    shipmentItemList.Add(shipmentItem1);
                        //}
                    }


                    receiptItemList = entity.ProductionCostIngredientCostListPhoi.Where(item => item.FK_MMBatchProductID == batchProductID
                                                                                    //&& item.FK_MMOperationID == objOperationsInfo.MMOperationID
                                                                                    && item.MMProductionCostIngredientCostReferenceTypeCombo == ReceiptType.SemiProductReceipt.ToString()).ToList();

                    //List<string> productIDList = new List<string>();
                    if (receiptItemList.Count == 0)
                    {
                        //foreach (ICShipmentItemsInfo shipmentItem in shipmentItemList)
                        foreach (MMProductionCostIngredientCostsInfo shipmentItem in shipmentItemList)
                        {
                            //if (!productIDList.Contains(shipmentItem.FK_ICProductID + "-" + shipmentItem.FK_ICProductSerieID))
                            //{
                            //    //decimal tongSLXuat = shipmentItemList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID 
                            //    //    && p.FK_ICProductSerieID == shipmentItem.FK_ICProductSerieID).Sum(e => e.ICShipmentItemProductQty);
                            //    decimal tongSLXuat = xuatPhoi.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID
                            //        && p.FK_ICProductSerieID == shipmentItem.FK_ICProductSerieID).Sum(e => e.MMProductionCostIngredientCostProductQty);

                            //    objProductionCostIngredientCostsInfo = new MMProductionCostIngredientCostDDsInfo();
                            //    BOSUtil.CopyObject(shipmentItem, objProductionCostIngredientCostsInfo);

                            //    //ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByID(shipmentItem.FK_ICShipmentID);
                            //    //if (objShipmentInfo != null)
                            //    //{
                            //    //    objProductionCostIngredientCostsInfo.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                            //    //    objProductionCostIngredientCostsInfo.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                            //    //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDReferenceNo = objShipmentInfo.ICShipmentNo;
                            //    //}

                            //    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDReferenceNo = shipmentItem.ICShipmentNo;
                            //    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDBatchProductNo = shipmentItem.MMBatchProductNo;
                            //    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDOperationName = shipmentItem.MMOperationName;
                            //    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDMeasureUnitName = shipmentItem.ICMeasureUnitName;
                            //    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDStockName = shipmentItem.ICStockName;
                            //    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductNo = shipmentItem.ICProductNo;

                            //    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductQty = tongSLXuat;
                            //    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductSerialNo = shipmentItem.ICShipmentItemProductSerialNo;
                            //    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductUnitCost = shipmentItem.ICShipmentItemProductUnitPrice;


                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDReferenceNo = shipmentItem.MMProductionCostIngredientCostReferenceNo;
                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDBatchProductNo = shipmentItem.MMProductionCostIngredientCostBatchProductNo;
                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDOperationName = shipmentItem.MMProductionCostIngredientCostOperationName;
                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDMeasureUnitName = shipmentItem.MMProductionCostIngredientCostMeasureUnitName;
                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDStockName = shipmentItem.MMProductionCostIngredientCostStockName;
                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductNo = shipmentItem.MMProductionCostIngredientCostProductNo;

                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductQty = tongSLXuat;
                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductSerialNo = shipmentItem.MMProductionCostIngredientCostProductSerialNo;
                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductUnitCost = shipmentItem.MMProductionCostIngredientCostProductUnitCost;
                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductUnitCost;
                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDReferenceType = ProductionCostIngredientCostReferenceType.XuatKho;
                            //    BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                            //    incompleteList.Add(objProductionCostIngredientCostsInfo);
                            //    productIDList.Add(shipmentItem.FK_ICProductID + "-" + shipmentItem.FK_ICProductSerieID);
                            //}


                            objProductionCostIngredientCostsInfo = new MMProductionCostIngredientCostDDsInfo();
                            BOSUtil.CopyObject(shipmentItem, objProductionCostIngredientCostsInfo);
                            objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductUnitCost;
                            objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDReferenceType = ProductionCostIngredientCostReferenceType.XuatKho;
                            BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                            incompleteList.Add(objProductionCostIngredientCostsInfo);
                        }
                    }
                    else
                    {
                        if (!completedBatchProductIDs.Contains(batchProductID))
                        {
                            decimal klXUat = shipmentItemList.Sum(e => e.MMProductionCostIngredientCostProductQty);
                            decimal tongGTXuat = shipmentItemList.Sum(e => e.MMProductionCostIngredientCostTotalCost);
                            decimal klNhapLai = receiptItemList.Where(p => p.MMProductionCostIngredientCostReferenceNo.IndexOf("NKPK") >= 0).Sum(e => e.MMProductionCostIngredientCostProductQty);
                            decimal tongGTNhapLai = receiptItemList.Where(p => p.MMProductionCostIngredientCostReferenceNo.IndexOf("NKPK") >= 0).Sum(e => e.MMProductionCostIngredientCostTotalCost);
                            decimal klNhapLSX = receiptItemList.Where(p => p.MMProductionCostIngredientCostReferenceNo.IndexOf("NKBTP") >= 0).Sum(e => e.MMProductionCostIngredientCostProductWoodQty);
                            //List<MMBatchProductProductionNormItemsInfo> ppniList = objBPPNIsController.GetProductionNormItemsByGroupTypeAndBatchProductID(ProductType.Product.ToString(), batchProductID);
                            //decimal klLSX = ppniList.Sum(e => e.MMBatchProductProductionNormItemBlocks);
                            decimal klLSX = objBPPNIsController.GetTotalManafacturingBatchProductBlocks(batchProductID);
                            //List<MMWoodPlanItemDetailsInfo> wpiList = objWoodPlanItemDetailsController.GetWoodPlanItemByBatchProductID(batchProductID);
                            // m3 LSX theo hoạch định
                            //decimal klHDSX = wpiList.Sum(e => e.MMWoodPlanItemDetailBlocks);
                            decimal klHDSX = objWoodPlanItemDetailsController.GetTotalWoodPlanItemBlocksByBatchProductID(batchProductID);
                            //decimal dodang = (klXUat - klNhap) - (klXUat / klHDSX) * klNhapLSX;
                            //receiptItemList = objReceiptItemsController.GetAllReceiptItemByBatchProductIDAndOperationIDAndDate(batchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate.AddDays(-1));
                            //decimal klTongNhapLSX = receiptItemList.Sum(e => e.ICReceiptItemWoodQty);
                            decimal klTongNhapLSX = objReceiptItemsController.GetTotalReceiptBlocksByBatchProductIDAndOperationIDAndDate(batchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate.AddDays(-1));
                            decimal dodang = 0;
                            if (klHDSX == 0)
                            {
                                dodang = klXUat;
                            }
                            else
                            {
                                //dodang = (klXUat - klNhapLai) - ((klXUat - klNhapLai) / (klHDSX - klTongNhapLSX)) * klNhapLSX;
                                dodang = (klXUat - klNhapLai) - ((klXUat - klNhapLai) / (klLSX - klTongNhapLSX)) * klNhapLSX;
                            }
                            if (dodang > 0)
                            {

                                foreach (MMProductionCostIngredientCostsInfo shipmentItem in shipmentItemList)
                                {
                                    decimal value = Math.Min(shipmentItem.MMProductionCostIngredientCostProductQty, dodang);

                                    objProductionCostIngredientCostsInfo = new MMProductionCostIngredientCostDDsInfo();
                                    BOSUtil.CopyObject(shipmentItem, objProductionCostIngredientCostsInfo);

                                    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductQty = value;
                                    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductWoodQty = value;
                                    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTotalCost = value * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductUnitCost;
                                    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDReferenceType = ProductionCostIngredientCostReferenceType.XuatKho;
                                    BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                    incompleteList.Add(objProductionCostIngredientCostsInfo);
                                    dodang -= value;
                                    if (dodang == 0)
                                        break;
                                }

                                //objProductionCostIngredientCostsInfo = new MMProductionCostIngredientCostDDsInfo();
                                //BOSUtil.CopyObject(productPrice, objProductionCostIngredientCostsInfo);
                                //objProductionCostIngredientCostsInfo.FK_ICProductID = shipmentItemList[0].FK_ICProductID;
                                //objProductionCostIngredientCostsInfo.FK_MMBatchProductID = productPrice.FK_MMBatchProductID;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDBatchProductNo = productPrice.MMBatchProductNo;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDOperationName = objOperationsInfo.MMOperationName;
                                ////objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductNo = productPrice.ICProductNo;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductNo = shipmentItemList[0].ICProductNo;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductName = shipmentItemList[0].ICShipmentItemProductName;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductDesc = shipmentItemList[0].ICShipmentItemProductDesc;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductQty = dodang;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductWoodQty = dodang;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductUnitCost = (tongGTXuat - tongGTNhapLai) / klXUat;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTotalCost = dodang * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDProductUnitCost;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDReferenceType = ProductionCostIngredientCostReferenceType.XuatKho;
                                //BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                //incompleteList.Add(objProductionCostIngredientCostsInfo);
                            }
                        }
                    }
                    //batchProductIDList.Add(productPrice.FK_MMBatchProductID);
                }
            }

            entity.ProductionCostIngredientCostListDDPhoi.Clear();
            entity.ProductionCostIngredientCostListDDPhoi.Invalidate(incompleteList);
            ProductionCostIngredientIncompletePhoiGridControl.InitGridControlDataSource();
            //ProductionCostIngredientIncompletePhoiGridControl.DataSource = incompleteList;
            //ProductionCostIngredientIncompletePhoiGridControl.RefreshDataSource();
        }

        private void BindingDataSourceIncompleteSC(bool isCal, List<int> batchProductIDList)
        {
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;

            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDSoCheNo);

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            //List<ICReceiptItemsInfo> receiptItemList = new List<ICReceiptItemsInfo>();

            //List<int> batchProductIDList = new List<int>();
            MMProductionCostIngredientCostDDSCsInfo objProductionCostIngredientCostsInfo = null;

            List<MMProductionCostIngredientCostDDSCsInfo> incompleteList = new List<MMProductionCostIngredientCostDDSCsInfo>();


            List<MMProductionCostIngredientCostSCsInfo> xuatSC = new List<MMProductionCostIngredientCostSCsInfo>();
            ICShipmentItemsInfo itemShipment = null;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo = null;
            ICShipmentsController objShipmentController = new ICShipmentsController();
            List<MMProductionCostIngredientCostSCsInfo> receiptItemList;
            List<MMProductionCostIngredientCostSCsInfo> shipmentProductList;
            List<int> productIDList = new List<int>();
            //foreach (MMProductionCostItemsInfo productPrice in entity.ProductionCostItemList)
            foreach (int batchProductID in batchProductIDList)
            {
                //if (!batchProductIDList.Contains(productPrice.FK_MMBatchProductID))
                {
                    //if (batchProductID == 368 || batchProductID == 426)
                    //{
                    //    string a = "";
                    //}
                    //shipmentItemList = objShipmentItemsController.GetShipmentItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    shipmentItemList.Clear();
                    xuatSC = entity.ProductionCostIngredientCostListSC.Where(p => p.FK_MMBatchProductID == batchProductID
                        && p.MMProductionCostIngredientCostSCReferenceType == ProductionCostIngredientCostReferenceType.XuatKho).ToList();
                    //foreach (MMProductionCostIngredientCostSCsInfo item in xuatSC)
                    //{
                    //    itemShipment = new ICShipmentItemsInfo();
                    //    BOSUtil.CopyObject(item, itemShipment);
                    //    objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.MMProductionCostIngredientCostSCProductSerialNo);
                    //    if (objProductSeriesInfo != null)
                    //    {
                    //        itemShipment.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                    //    }
                    //    itemShipment.FK_ICProductID = item.FK_ICProductID;
                    //    itemShipment.FK_MMBatchProductID = item.FK_MMBatchProductID;
                    //    itemShipment.ICShipmentItemProductQty = item.MMProductionCostIngredientCostSCProductQty;
                    //    itemShipment.ICShipmentItemProductUnitPrice = item.MMProductionCostIngredientCostSCProductUnitCost;
                    //    itemShipment.ICShipmentItemWoodQty = item.MMProductionCostIngredientCostSCProductWoodQty;
                    //    itemShipment.ICShipmentItemTotalAmount = item.MMProductionCostIngredientCostSCTotalCost;
                    //    itemShipment.ICShipmentNo = item.MMProductionCostIngredientCostSCReferenceNo;
                    //    itemShipment.MMBatchProductNo = item.MMProductionCostIngredientCostSCBatchProductNo;
                    //    itemShipment.MMOperationName = item.MMProductionCostIngredientCostSCOperationName;
                    //    itemShipment.ICMeasureUnitName = item.MMProductionCostIngredientCostSCMeasureUnitName;
                    //    itemShipment.ICStockName = item.MMProductionCostIngredientCostSCStockName;
                    //    itemShipment.ICProductNo = item.MMProductionCostIngredientCostSCProductNo;

                    //    ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByNo(item.MMProductionCostIngredientCostSCReferenceNo);
                    //    if (objShipmentInfo != null)
                    //    {
                    //        itemShipment.FK_ICShipmentID = objShipmentInfo.ICShipmentID;
                    //        itemShipment.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                    //        itemShipment.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                    //    }
                    //    shipmentItemList.Add(itemShipment);
                    //}
                    //receiptItemList = objReceiptItemsController.GetReceiptItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    receiptItemList = entity.ProductionCostIngredientCostListSC.Where(p => p.FK_MMBatchProductID == batchProductID
                                            && p.MMProductionCostIngredientCostSCReferenceType == ProductionCostIngredientCostReferenceType.NhapKho).ToList();
                    productIDList.Clear();
                    //foreach (ICShipmentItemsInfo shipmentItem in shipmentItemList)
                    foreach (MMProductionCostIngredientCostSCsInfo shipmentItem in xuatSC)
                    {
                        if (!productIDList.Contains(shipmentItem.FK_ICProductID))
                        {
                            shipmentProductList = xuatSC.Where(x => x.FK_ICProductID == shipmentItem.FK_ICProductID).OrderByDescending(x => x.FK_ICProductSerieID).ToList();
                            decimal tongSLXuat = shipmentProductList.Sum(e => e.MMProductionCostIngredientCostSCProductQty);
                            decimal tongSLNhap = receiptItemList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.MMProductionCostIngredientCostSCProductQty);
                            decimal dodang = tongSLXuat - tongSLNhap;


                            if (dodang > 0)
                            {
                                if (shipmentProductList.Count > 0)
                                {
                                    //decimal remainQty = tongSLNhap;
                                    foreach (MMProductionCostIngredientCostSCsInfo subShipmentItem in shipmentProductList)
                                    {
                                        objProductionCostIngredientCostsInfo = new MMProductionCostIngredientCostDDSCsInfo();
                                        BOSUtil.CopyObject(subShipmentItem, objProductionCostIngredientCostsInfo);
                                        //ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByID(subShipmentItem.FK_ICShipmentID);

                                        //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCBatchProductNo = subShipmentItem.MMBatchProductNo;
                                        //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCOperationName = subShipmentItem.MMOperationName;
                                        //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCMeasureUnitName = subShipmentItem.ICMeasureUnitName;
                                        //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCStockName = subShipmentItem.ICStockName;
                                        //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCProductNo = subShipmentItem.ICProductNo;
                                        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCReferenceType = ProductionCostIngredientCostReferenceType.XuatKho;

                                        //if (objShipmentInfo != null)
                                        //{
                                        //    objProductionCostIngredientCostsInfo.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                                        //    objProductionCostIngredientCostsInfo.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                                        //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCReferenceNo = objShipmentInfo.ICShipmentNo;
                                        //}


                                        decimal value = Math.Min(dodang, subShipmentItem.MMProductionCostIngredientCostSCProductQty);
                                        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCProductQty = value;
                                        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCProductUnitCost;
                                        BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                        incompleteList.Add(objProductionCostIngredientCostsInfo);

                                        dodang -= value;
                                        if (dodang == 0)
                                            break;

                                        //if (remainQty > 0)
                                        //{
                                        //    if (subShipmentItem.ICShipmentItemProductQty - remainQty >= 0)
                                        //    {
                                        //        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCProductQty = subShipmentItem.ICShipmentItemProductQty - remainQty;
                                        //        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCProductUnitCost = subShipmentItem.ICShipmentItemProductUnitPrice;
                                        //        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCProductUnitCost;
                                        //        BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                        //        incompleteList.Add(objProductionCostIngredientCostsInfo);
                                        //    }
                                        //    remainQty = remainQty - subShipmentItem.ICShipmentItemProductQty;
                                        //}
                                        //else
                                        //{
                                        //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCProductQty = subShipmentItem.ICShipmentItemProductQty;
                                        //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCProductUnitCost = subShipmentItem.ICShipmentItemProductUnitPrice;
                                        //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCProductUnitCost;
                                        //    BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                        //    incompleteList.Add(objProductionCostIngredientCostsInfo);
                                        //}
                                    }
                                }
                            }
                            else if (dodang < 0)
                            {
                                //ICShipmentItemsInfo objShipmentItemsInfo = shipmentProductList[0];
                                objProductionCostIngredientCostsInfo = new MMProductionCostIngredientCostDDSCsInfo();
                                BOSUtil.CopyObject(shipmentProductList[0], objProductionCostIngredientCostsInfo);
                                //ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByID(objShipmentItemsInfo.FK_ICShipmentID);
                                //if (objShipmentInfo != null)
                                //{
                                //    objProductionCostIngredientCostsInfo.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                                //    objProductionCostIngredientCostsInfo.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                                //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCReferenceNo = objShipmentInfo.ICShipmentNo;
                                //}
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCBatchProductNo = shipmentItem.MMBatchProductNo;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCOperationName = shipmentItem.MMOperationName;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCMeasureUnitName = shipmentItem.ICMeasureUnitName;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCStockName = shipmentItem.ICStockName;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCProductNo = shipmentItem.ICProductNo;

                                objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCProductQty = dodang;
                                objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCProductUnitCost = shipmentProductList[0].MMProductionCostIngredientCostSCProductUnitCost;
                                objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCProductUnitCost;
                                objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSCReferenceType = ProductionCostIngredientCostReferenceType.XuatKho;
                                BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                incompleteList.Add(objProductionCostIngredientCostsInfo);
                            }
                            productIDList.Add(shipmentItem.FK_ICProductID);
                        }

                    }
                    //batchProductIDList.Add(productPrice.FK_MMBatchProductID);
                }
            }

            entity.ProductionCostIngredientCostListDDSC.Clear();
            entity.ProductionCostIngredientCostListDDSC.Invalidate(incompleteList);
            ProductionCostIngredientIncompleteSCGridControl.InitGridControlDataSource();
            //ProductionCostIngredientIncompleteSCGridControl.DataSource = incompleteList;
            //ProductionCostIngredientIncompleteSCGridControl.RefreshDataSource();
        }

        private void BindingDataSourceIncompleteTC(bool isCal, List<int> batchProductIDList)
        {
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;

            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDTinhCheNo);

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            //List<ICReceiptItemsInfo> receiptItemList = new List<ICReceiptItemsInfo>();

            //List<int> batchProductIDList = new List<int>();
            MMProductionCostIngredientCostDDTCsInfo objProductionCostIngredientCostsInfo = null;

            List<MMProductionCostIngredientCostDDTCsInfo> incompleteList = new List<MMProductionCostIngredientCostDDTCsInfo>();


            List<MMProductionCostIngredientCostTCsInfo> xuatTC = new List<MMProductionCostIngredientCostTCsInfo>();
            ICShipmentItemsInfo itemShipment = null;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo = null;
            ICShipmentsController objShipmentController = new ICShipmentsController();
            List<MMProductionCostIngredientCostTCsInfo> receiptItemList;
            List<MMProductionCostIngredientCostTCsInfo> shipmentProductList = new List<MMProductionCostIngredientCostTCsInfo>();
            List<int> productIDList = new List<int>();
            //foreach (MMProductionCostItemsInfo productPrice in entity.ProductionCostItemList)
            foreach (int batchProductID in batchProductIDList)
            {
                //if (!batchProductIDList.Contains(productPrice.FK_MMBatchProductID))
                {
                    //if (batchProductID == 573)
                    //{
                    //    string a = "";
                    //}
                    //shipmentItemList = objShipmentItemsController.GetShipmentItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    //shipmentItemList.Clear();
                    xuatTC = entity.ProductionCostIngredientCostListTC.Where(p => p.FK_MMBatchProductID == batchProductID
                        && p.MMProductionCostIngredientCostTCReferenceType == ProductionCostIngredientCostReferenceType.XuatKho).ToList();
                    //foreach (MMProductionCostIngredientCostTCsInfo item in xuatTC)
                    //{
                    //    itemShipment = new ICShipmentItemsInfo();
                    //    BOSUtil.CopyObject(item, itemShipment);
                    //    objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.MMProductionCostIngredientCostTCProductSerialNo);
                    //    if (objProductSeriesInfo != null)
                    //    {
                    //        itemShipment.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                    //    }
                    //    itemShipment.FK_ICProductID = item.FK_ICProductID;
                    //    itemShipment.FK_MMBatchProductID = item.FK_MMBatchProductID;
                    //    itemShipment.ICShipmentItemProductQty = item.MMProductionCostIngredientCostTCProductQty;
                    //    itemShipment.ICShipmentItemProductUnitPrice = item.MMProductionCostIngredientCostTCProductUnitCost;
                    //    itemShipment.ICShipmentItemWoodQty = item.MMProductionCostIngredientCostTCProductWoodQty;
                    //    itemShipment.ICShipmentItemTotalAmount = item.MMProductionCostIngredientCostTCTotalCost;
                    //    itemShipment.ICShipmentNo = item.MMProductionCostIngredientCostTCReferenceNo;
                    //    itemShipment.MMBatchProductNo = item.MMProductionCostIngredientCostTCBatchProductNo;
                    //    itemShipment.MMOperationName = item.MMProductionCostIngredientCostTCOperationName;
                    //    itemShipment.ICMeasureUnitName = item.MMProductionCostIngredientCostTCMeasureUnitName;
                    //    itemShipment.ICStockName = item.MMProductionCostIngredientCostTCStockName;
                    //    itemShipment.ICProductNo = item.MMProductionCostIngredientCostTCProductNo;

                    //    ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByNo(item.MMProductionCostIngredientCostTCReferenceNo);
                    //    if (objShipmentInfo != null)
                    //    {
                    //        itemShipment.FK_ICShipmentID = objShipmentInfo.ICShipmentID;
                    //        itemShipment.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                    //        itemShipment.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                    //    }
                    //    shipmentItemList.Add(itemShipment);
                    //}
                    //receiptItemList = objReceiptItemsController.GetReceiptItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);

                    receiptItemList = entity.ProductionCostIngredientCostListTC.Where(p => p.FK_MMBatchProductID == batchProductID
                       && p.MMProductionCostIngredientCostTCReferenceType == ProductionCostIngredientCostReferenceType.NhapKho).ToList();

                    productIDList.Clear();
                    //foreach (ICShipmentItemsInfo shipmentItem in shipmentItemList)
                    foreach (MMProductionCostIngredientCostTCsInfo shipmentItem in xuatTC)
                    {
                        if (!productIDList.Contains(shipmentItem.FK_ICProductID))
                        {
                            shipmentProductList = xuatTC.Where(x => x.FK_ICProductID == shipmentItem.FK_ICProductID).OrderByDescending(item => item.FK_ICProductSerieID).ToList();

                            decimal tongSLXuat = shipmentProductList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.MMProductionCostIngredientCostTCProductQty);
                            decimal tongSLNhap = receiptItemList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.MMProductionCostIngredientCostTCProductQty);
                            decimal dodang = tongSLXuat - tongSLNhap;

                            if (dodang > 0)
                            {
                                if (shipmentProductList.Count > 0)
                                {
                                    //decimal remainQty = tongSLNhap;
                                    //foreach (ICShipmentItemsInfo subShipmentItem in shipmentProductList)
                                    foreach (MMProductionCostIngredientCostTCsInfo subShipmentItem in shipmentProductList)
                                    {
                                        objProductionCostIngredientCostsInfo = new MMProductionCostIngredientCostDDTCsInfo();
                                        BOSUtil.CopyObject(subShipmentItem, objProductionCostIngredientCostsInfo);
                                        //ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByID(subShipmentItem.FK_ICShipmentID);

                                        //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCBatchProductNo = subShipmentItem.MMBatchProductNo;
                                        //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCOperationName = subShipmentItem.MMOperationName;
                                        //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCMeasureUnitName = subShipmentItem.ICMeasureUnitName;
                                        //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCStockName = subShipmentItem.ICStockName;
                                        //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCProductNo = subShipmentItem.ICProductNo;
                                        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCReferenceType = ProductionCostIngredientCostReferenceType.XuatKho;

                                        decimal value = Math.Min(dodang, subShipmentItem.MMProductionCostIngredientCostTCProductQty);
                                        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCProductQty = value;
                                        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCProductUnitCost;
                                        BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                        incompleteList.Add(objProductionCostIngredientCostsInfo);

                                        dodang -= value;
                                        if (dodang == 0)
                                            break;


                                        //    if (objShipmentInfo != null)
                                        //    {
                                        //        objProductionCostIngredientCostsInfo.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                                        //        objProductionCostIngredientCostsInfo.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                                        //        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCReferenceNo = objShipmentInfo.ICShipmentNo;
                                        //    }
                                        //    if (remainQty > 0)
                                        //    {
                                        //        if (subShipmentItem.ICShipmentItemProductQty - remainQty >= 0)
                                        //        {
                                        //            objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCProductQty = subShipmentItem.ICShipmentItemProductQty - remainQty;
                                        //            objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCProductUnitCost = subShipmentItem.ICShipmentItemProductUnitPrice;
                                        //            objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCProductUnitCost;
                                        //            BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                        //            incompleteList.Add(objProductionCostIngredientCostsInfo);
                                        //        }
                                        //        remainQty = remainQty - subShipmentItem.ICShipmentItemProductQty;
                                        //    }
                                        //    else
                                        //    {
                                        //        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCProductQty = subShipmentItem.ICShipmentItemProductQty;
                                        //        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCProductUnitCost = subShipmentItem.ICShipmentItemProductUnitPrice;
                                        //        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCProductUnitCost;
                                        //        BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                        //        incompleteList.Add(objProductionCostIngredientCostsInfo);
                                        //    }
                                    }
                                }
                            }
                            else if (dodang < 0)
                            {
                                //ICShipmentItemsInfo objShipmentItemsInfo = shipmentProductList[0];
                                objProductionCostIngredientCostsInfo = new MMProductionCostIngredientCostDDTCsInfo();
                                BOSUtil.CopyObject(shipmentProductList[0], objProductionCostIngredientCostsInfo);
                                //ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByID(objShipmentItemsInfo.FK_ICShipmentID);
                                //if (objShipmentInfo != null)
                                //{
                                //    objProductionCostIngredientCostsInfo.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                                //    objProductionCostIngredientCostsInfo.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                                //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCReferenceNo = objShipmentInfo.ICShipmentNo;
                                //}
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCBatchProductNo = shipmentItem.MMBatchProductNo;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCOperationName = shipmentItem.MMOperationName;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCMeasureUnitName = shipmentItem.ICMeasureUnitName;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCStockName = shipmentItem.ICStockName;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCProductNo = shipmentItem.ICProductNo;

                                objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCProductQty = dodang;
                                //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCProductUnitCost = objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
                                objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCProductUnitCost;
                                objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDTCReferenceType = ProductionCostIngredientCostReferenceType.XuatKho;
                                BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                incompleteList.Add(objProductionCostIngredientCostsInfo);
                            }
                            productIDList.Add(shipmentItem.FK_ICProductID);
                        }

                    }
                    //batchProductIDList.Add(productPrice.FK_MMBatchProductID);
                }
            }

            entity.ProductionCostIngredientCostListDDTC.Clear();
            entity.ProductionCostIngredientCostListDDTC.Invalidate(incompleteList);
            ProductionCostIngredientIncompleteTCGridControl.InitGridControlDataSource();
            //ProductionCostIngredientIncompleteTCGridControl.DataSource = incompleteList;
        }

        private void BindingDataSourceIncompleteLR(bool isCal, List<int> batchProductIDList)
        {
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;

            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDLapRapNo);

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();

            ICReceiptsController objReceiptsController = new ICReceiptsController();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            //List<ICReceiptItemsInfo> receiptItemList = new List<ICReceiptItemsInfo>();

            //List<int> batchProductIDList = new List<int>();            

            MMProductionCostIngredientCostDDLRsInfo objProductionCostIngredientCostsInfo = null;

            List<MMProductionCostIngredientCostDDLRsInfo> incompleteList = new List<MMProductionCostIngredientCostDDLRsInfo>();

            MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();
            //List<ICReceiptItemsInfo> receiptItemDetailList = new List<ICReceiptItemsInfo>();


            List<MMProductionCostIngredientCostLRsInfo> xuatLR = new List<MMProductionCostIngredientCostLRsInfo>();
            ICShipmentItemsInfo itemShipment = null;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo = null;
            ICShipmentsController objShipmentController = new ICShipmentsController();
            List<MMProductionCostIngredientCostLRsInfo> receiptItemList;
            List<MMProductionCostIngredientCostLRsInfo> receiptItemDetailList = new List<MMProductionCostIngredientCostLRsInfo>();
            List<MMProductionCostIngredientCostLRsInfo> shipmentItemList = new List<MMProductionCostIngredientCostLRsInfo>();
            List<MMProductionCostIngredientCostLRsInfo> shipmentProductList = new List<MMProductionCostIngredientCostLRsInfo>();
            Dictionary<int, MMProductionCostIngredientCostLRsInfo> collection = new Dictionary<int, MMProductionCostIngredientCostLRsInfo>();
            //foreach (MMProductionCostItemsInfo productPrice in entity.ProductionCostItemList)
            foreach (int batchProductID in batchProductIDList)
            {
                //if (!batchProductIDList.Contains(productPrice.FK_MMBatchProductID))
                {
                    //if (batchProductID == 752)
                    //{
                    //    //continue;
                    //    string a = "a";
                    //}
                    //shipmentItemList = objShipmentItemsController.GetShipmentItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    shipmentItemList.Clear();
                    xuatLR = entity.ProductionCostIngredientCostListLR.Where(p => p.FK_MMBatchProductID == batchProductID
                        && p.MMProductionCostIngredientCostLRReferenceType == ProductionCostIngredientCostReferenceType.XuatKho
                        //&& p.MMProductionCostIngredientCostLRReferenceTypeCombo == "MaterialShipment"
                        ).OrderBy(item => item.FK_ICProductSerieID).ToList();
                    //foreach (MMProductionCostIngredientCostLRsInfo item in xuatLR)
                    //{
                    //    itemShipment = new ICShipmentItemsInfo();
                    //    BOSUtil.CopyObject(item, itemShipment);
                    //    objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.MMProductionCostIngredientCostLRProductSerialNo);
                    //    if (objProductSeriesInfo != null)
                    //    {
                    //        itemShipment.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                    //    }
                    //    itemShipment.FK_ICProductID = item.FK_ICProductID;
                    //    itemShipment.FK_MMBatchProductID = item.FK_MMBatchProductID;
                    //    itemShipment.ICShipmentItemProductQty = item.MMProductionCostIngredientCostLRProductQty;
                    //    itemShipment.ICShipmentItemProductUnitPrice = item.MMProductionCostIngredientCostLRProductUnitCost;
                    //    itemShipment.ICShipmentItemWoodQty = item.MMProductionCostIngredientCostLRProductWoodQty;
                    //    itemShipment.ICShipmentItemTotalAmount = item.MMProductionCostIngredientCostLRTotalCost;
                    //    itemShipment.ICShipmentNo = item.MMProductionCostIngredientCostLRReferenceNo;
                    //    itemShipment.MMBatchProductNo = item.MMProductionCostIngredientCostLRBatchProductNo;
                    //    itemShipment.MMOperationName = item.MMProductionCostIngredientCostLROperationName;
                    //    itemShipment.ICMeasureUnitName = item.MMProductionCostIngredientCostLRMeasureUnitName;
                    //    itemShipment.ICStockName = item.MMProductionCostIngredientCostLRStockName;
                    //    itemShipment.ICProductNo = item.MMProductionCostIngredientCostLRProductNo;

                    //    ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByNo(item.MMProductionCostIngredientCostLRReferenceNo);
                    //    if (objShipmentInfo != null)
                    //    {
                    //        itemShipment.FK_ICShipmentID = objShipmentInfo.ICShipmentID;
                    //        itemShipment.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                    //        itemShipment.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                    //        itemShipment.ICShipmentType = objShipmentInfo.ICShipmentTypeCombo;
                    //    }

                    //    shipmentItemList.Add(itemShipment);
                    //}
                    //receiptItemList = objReceiptItemsController.GetReceiptItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);


                    receiptItemList = entity.ProductionCostIngredientCostListLR.Where(p => p.FK_MMBatchProductID == batchProductID
                        //&& p.MMProductionCostIngredientCostLRReferenceType == ProductionCostIngredientCostReferenceType.NhapKho
                        && (p.MMProductionCostIngredientCostLRReferenceTypeCombo == "MaterialRedundantReceipt"
                            || p.MMProductionCostIngredientCostLRReferenceTypeCombo == "MaterialReturnReceipt")).ToList();

                    collection.Clear();
                    if (receiptItemList != null && receiptItemList.Count > 0)
                    {
                        foreach (MMProductionCostIngredientCostLRsInfo receiptItem in receiptItemList)
                        {
                            int key = receiptItem.FK_ICProductID;
                            if (!collection.Keys.Contains(key))
                                collection.Add(key, new MMProductionCostIngredientCostLRsInfo());
                            collection[key].MMProductionCostIngredientCostLRProductQty += receiptItem.MMProductionCostIngredientCostLRProductQty;
                            collection[key].MMProductionCostIngredientCostLRTotalCost += receiptItem.MMProductionCostIngredientCostLRTotalCost;
                        }

                    }

                    foreach (int key in collection.Keys)
                    {
                        if (collection[key].MMProductionCostIngredientCostLRProductQty != 0)
                            collection[key].MMProductionCostIngredientCostLRProductUnitCost = collection[key].MMProductionCostIngredientCostLRTotalCost / collection[key].MMProductionCostIngredientCostLRProductQty;
                    }

                    foreach (MMProductionCostIngredientCostLRsInfo shipmentItem in xuatLR)
                    {
                        int key = shipmentItem.FK_ICProductID;
                        decimal remainQty = 0;
                        decimal value = 0;
                        if (collection.Keys.Contains(key) &&
                            (collection[key].MMProductionCostIngredientCostLRProductQty > 0 ||
                            collection[key].MMProductionCostIngredientCostLRTotalCost > 0))
                        {
                            remainQty = Math.Min(shipmentItem.MMProductionCostIngredientCostLRProductQty, collection[key].MMProductionCostIngredientCostLRProductQty);
                            value = Math.Min(shipmentItem.MMProductionCostIngredientCostLRTotalCost, collection[key].MMProductionCostIngredientCostLRTotalCost);
                            collection[key].MMProductionCostIngredientCostLRProductQty -= remainQty;
                            collection[key].MMProductionCostIngredientCostLRTotalCost -= value;
                        }
                        if (shipmentItem.MMProductionCostIngredientCostLRProductQty != remainQty ||
                            shipmentItem.MMProductionCostIngredientCostLRTotalCost != value)
                        {
                            MMProductionCostIngredientCostLRsInfo shipmentItem1 = new MMProductionCostIngredientCostLRsInfo();
                            BOSUtil.CopyObject(shipmentItem, shipmentItem1);
                            shipmentItem1.MMProductionCostIngredientCostLRProductQty = shipmentItem.MMProductionCostIngredientCostLRProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostLRProductWoodQty = shipmentItem.MMProductionCostIngredientCostLRProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostLRTotalCost -= value;
                            if (shipmentItem1.MMProductionCostIngredientCostLRProductQty != 0)
                                shipmentItem1.MMProductionCostIngredientCostLRProductUnitCost = shipmentItem1.MMProductionCostIngredientCostLRTotalCost / shipmentItem1.MMProductionCostIngredientCostLRProductQty;
                            shipmentItemList.Add(shipmentItem1);
                        }
                    }

                    receiptItemList = entity.ProductionCostIngredientCostListLR.Where(p => p.FK_MMBatchProductID == batchProductID
                        //&& p.MMProductionCostIngredientCostLRReferenceType == ProductionCostIngredientCostReferenceType.NhapKho
                        && (p.MMProductionCostIngredientCostLRReferenceTypeCombo == "SemiProductReceipt"
                            || p.MMProductionCostIngredientCostLRReferenceTypeCombo == "ProductionReceipt")).ToList();


                    if (receiptItemList == null || receiptItemList.Count == 0)
                    {
                        foreach (MMProductionCostIngredientCostLRsInfo shipmentItem in shipmentItemList)
                        {
                            objProductionCostIngredientCostsInfo = new MMProductionCostIngredientCostDDLRsInfo();
                            BOSUtil.CopyObject(shipmentItem, objProductionCostIngredientCostsInfo);

                            objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRReferenceType = ProductionCostIngredientCostReferenceType.XuatKho;
                            BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                            incompleteList.Add(objProductionCostIngredientCostsInfo);
                        }
                    }
                    else
                    {
                        List<MMBatchProductProductionNormItemsInfo> bppniList = objBPPNIsController.GetBatchProductProductionNormItemsByBatchProductIDAndProductGroup(batchProductID, "SemiProduct");

                        // Kiểm tra chi tiết theo cụm
                        //if (receiptItemList.Count > 0)
                        //{
                        receiptItemDetailList.Clear();
                        //foreach (ICReceiptItemsInfo item in receiptItemList)
                        foreach (MMProductionCostIngredientCostLRsInfo item in receiptItemList)
                        {
                            if (item.FK_ICProductGroupID == 1 || item.MMProductionCostIngredientCostLRProductDesc.Contains("Cụm"))
                            {
                                //ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)objReceiptsController.GetObjectByID(item.FK_ICReferenceID);
                                List<MMBatchProductProductionNormItemsInfo> bppniList1 = bppniList.Where(pni => pni.MMBatchProductProductionNormItemParentID == item.FK_MMBatchProductProductionNormItemID).ToList();
                                if (bppniList1.Count == 0)
                                {
                                    bppniList1 = bppniList.Where(pni =>
                                                    bppniList.Where(pni1 => pni1.FK_MMBatchProductID == item.FK_MMBatchProductID
                                                        && pni1.FK_ICProductID == item.FK_ICProductID
                                                        && pni1.FK_MMBatchProductItemID == item.FK_MMBatchProductItemID)
                                                        .Any(pni2 => pni2.MMBatchProductProductionNormItemID == pni.MMBatchProductProductionNormItemParentID)).ToList();
                                }
                                foreach (MMBatchProductProductionNormItemsInfo bppni in bppniList1)
                                {
                                    MMProductionCostIngredientCostLRsInfo objItem = new MMProductionCostIngredientCostLRsInfo();
                                    BOSUtil.CopyObject(bppni, objItem);
                                    objItem.FK_ICProductID = bppni.FK_ICProductID;
                                    objItem.FK_MMBatchProductItemID = bppni.FK_MMBatchProductItemID;
                                    //objItem.ICReceiptItemProductQty = bppni.MMBatchProductProductionNormItemQuantity;
                                    objItem.MMProductionCostIngredientCostLRProductQty = (bppni.MMBatchProductProductionNormItemQuantity / bppni.SoLuongCum) * item.MMProductionCostIngredientCostLRProductQty;
                                    receiptItemDetailList.Add(objItem);
                                }
                            }
                            else
                            {
                                receiptItemDetailList.Add(item);
                            }
                        }
                        //}
                        //else
                        //{
                        //    receiptItemDetailList.Clear();
                        //}
                        List<int> productIDList = new List<int>();
                        //foreach (ICShipmentItemsInfo shipmentItem in shipmentItemList)
                        foreach (MMProductionCostIngredientCostLRsInfo shipmentItem in shipmentItemList)
                        {
                            if (!productIDList.Contains(shipmentItem.FK_ICProductID))
                            {
                                if (shipmentItem.MMProductionCostIngredientCostLRReferenceTypeCombo == ShipmentType.MaterialShipment.ToString())
                                {
                                    continue;
                                }
                                decimal tongSLXuat = shipmentItemList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.MMProductionCostIngredientCostLRProductQty);
                                decimal tongSLNhap = receiptItemDetailList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID
                                    //&& p.FK_MMBatchProductItemID == shipmentItem.FK_MMBatchProductItemID
                                    ).Sum(e => e.MMProductionCostIngredientCostLRProductQty);
                                // Trừ số lượng NLP nhập lại
                                //List<ICReceiptItemsInfo> receiptItemNLPList = objReceiptItemsController.GetReceiptItemVLPByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                                //tongSLNhap += receiptItemNLPList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.ICReceiptItemProductQty);

                                decimal dodang = tongSLXuat - tongSLNhap;

                                shipmentProductList = shipmentItemList.Where(x => x.FK_ICProductID == shipmentItem.FK_ICProductID).OrderByDescending(x => x.FK_ICProductSerieID).ToList();

                                if (dodang > 0)
                                {
                                    //if (shipmentProductList.Count > 0)
                                    //{
                                    //decimal remainQty = tongSLNhap;
                                    foreach (MMProductionCostIngredientCostLRsInfo subShipmentItem in shipmentProductList)
                                    {
                                        objProductionCostIngredientCostsInfo = new MMProductionCostIngredientCostDDLRsInfo();
                                        BOSUtil.CopyObject(subShipmentItem, objProductionCostIngredientCostsInfo);
                                        //ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByID(subShipmentItem.FK_ICShipmentID);

                                        //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRBatchProductNo = subShipmentItem.MMBatchProductNo;
                                        //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLROperationName = subShipmentItem.MMOperationName;
                                        //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRMeasureUnitName = subShipmentItem.ICMeasureUnitName;
                                        //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRStockName = subShipmentItem.ICStockName;
                                        //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRProductNo = subShipmentItem.ICProductNo;
                                        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRReferenceType = ProductionCostIngredientCostReferenceType.XuatKho;
                                        //if (objShipmentInfo != null)
                                        //{
                                        //    objProductionCostIngredientCostsInfo.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                                        //    objProductionCostIngredientCostsInfo.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                                        //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRReferenceNo = objShipmentInfo.ICShipmentNo;
                                        //}

                                        decimal value = Math.Min(dodang, subShipmentItem.MMProductionCostIngredientCostLRProductQty);
                                        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRProductQty = value;
                                        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRProductQty
                                                                                                                            * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRProductUnitCost;
                                        BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                        incompleteList.Add(objProductionCostIngredientCostsInfo);

                                        dodang -= value;
                                        if (dodang == 0)
                                            break;

                                        //if (remainQty > 0)
                                        //{
                                        //    if (subShipmentItem.ICShipmentItemProductQty - remainQty >= 0)
                                        //    {
                                        //        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRProductQty = subShipmentItem.ICShipmentItemProductQty - remainQty;
                                        //        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRProductUnitCost = subShipmentItem.ICShipmentItemProductUnitPrice;
                                        //        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRProductUnitCost;
                                        //        BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                        //        incompleteList.Add(objProductionCostIngredientCostsInfo);
                                        //    }
                                        //    remainQty = remainQty - subShipmentItem.ICShipmentItemProductQty;
                                        //}
                                        //else
                                        //{
                                        //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRProductQty = subShipmentItem.ICShipmentItemProductQty;
                                        //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRProductUnitCost = subShipmentItem.ICShipmentItemProductUnitPrice;
                                        //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRProductUnitCost;
                                        //    BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                        //    incompleteList.Add(objProductionCostIngredientCostsInfo);
                                        //}
                                    }
                                    //}
                                }
                                else if (dodang < 0)
                                {
                                    MMProductionCostIngredientCostLRsInfo objShipmentItemsInfo = shipmentProductList[0];
                                    objProductionCostIngredientCostsInfo = new MMProductionCostIngredientCostDDLRsInfo();
                                    BOSUtil.CopyObject(objShipmentItemsInfo, objProductionCostIngredientCostsInfo);
                                    //ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByID(objShipmentItemsInfo.FK_ICShipmentID);
                                    //if (objShipmentInfo != null)
                                    //{
                                    //    objProductionCostIngredientCostsInfo.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                                    //    objProductionCostIngredientCostsInfo.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                                    //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRReferenceNo = objShipmentInfo.ICShipmentNo;
                                    //}
                                    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRBatchProductNo = objShipmentItemsInfo.MMBatchProductNo;
                                    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLROperationName = objShipmentItemsInfo.MMOperationName;
                                    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRMeasureUnitName = objShipmentItemsInfo.ICMeasureUnitName;
                                    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRStockName = objShipmentItemsInfo.ICStockName;
                                    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRProductNo = objShipmentItemsInfo.ICProductNo;

                                    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRProductQty = dodang;
                                    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRProductUnitCost = objShipmentItemsInfo.MMProductionCostIngredientCostLRProductUnitCost;
                                    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRProductUnitCost;
                                    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDLRReferenceType = ProductionCostIngredientCostReferenceType.XuatKho;
                                    BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                    incompleteList.Add(objProductionCostIngredientCostsInfo);
                                }
                                productIDList.Add(shipmentItem.FK_ICProductID);
                            }

                        }

                        // Dở dang vật liệu phụ
                        //productIDList.Clear();
                        //foreach (ICShipmentItemsInfo shipmentItem in shipmentItemList)
                        //{
                        //    if (!productIDList.Contains(shipmentItem.FK_ICProductID))
                        //    {
                        //        decimal tongSLXuat = shipmentItemList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.ICShipmentItemProductQty);
                        //        receiptItemList = objReceiptItemsController.GetReceiptItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);

                        //        ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)objReceiptsController.GetObjectByID(item.FK_ICReceiptID);
                        //        List<MMBatchProductProductionNormItemsInfo> bppniList = objBPPNIsController.GetItemByParentID(item.FK_MMBatchProductProductionNormItemID, objReceiptsInfo.FK_MMBatchProductID, objReceiptsInfo.FK_MMOperationID, objReceiptsInfo.FK_ICProductID);
                        //        if (bppniList.Count == 0)
                        //        {
                        //            bppniList = objBPPNIsController.GetItemBySomeCriteria(item.FK_MMBatchProductItemID, item.FK_MMBatchProductID, item.FK_ICProductID);
                        //        }
                        //        foreach (MMBatchProductProductionNormItemsInfo bppni in bppniList)
                        //        {
                        //            ICReceiptItemsInfo objItem = new ICReceiptItemsInfo();
                        //            BOSUtil.CopyObject(bppni, objItem);
                        //            objItem.FK_ICProductID = bppni.FK_ICProductID;
                        //            objItem.FK_MMBatchProductItemID = bppni.FK_MMBatchProductItemID;
                        //            objItem.ICReceiptItemProductQty = (bppni.MMBatchProductProductionNormItemQuantity / bppni.SoLuongCum) * item.ICReceiptItemProductQty;
                        //            receiptItemDetailList.Add(objItem);
                        //        }

                        //        incompleteList.Add(objProductionCostIngredientCostsInfo);
                        //        productIDList.Add(shipmentItem.FK_ICProductID);
                        //    }
                        //}

                        //batchProductIDList.Add(productPrice.FK_MMBatchProductID);
                    }
                }
            }

            entity.ProductionCostIngredientCostListDDLR.Clear();
            entity.ProductionCostIngredientCostListDDLR.Invalidate(incompleteList);
            ProductionCostIngredientIncompleteLRGridControl.InitGridControlDataSource();
            //ProductionCostIngredientIncompleteLRGridControl.DataSource = incompleteList;
        }

        private void BindingDataSourceIncompleteSon(bool isCal, List<int> batchProductIDList)
        {
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;

            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDSonNo);

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<MMProductionCostIngredientCostSonsInfo> shipmentItemList = new List<MMProductionCostIngredientCostSonsInfo>();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<MMProductionCostIngredientCostSonsInfo> receiptItemList = new List<MMProductionCostIngredientCostSonsInfo>();

            //List<int> batchProductIDList = new List<int>();
            MMProductionCostIngredientCostDDSonsInfo objProductionCostIngredientCostsInfo = null;

            List<MMProductionCostIngredientCostDDSonsInfo> incompleteList = new List<MMProductionCostIngredientCostDDSonsInfo>();
            List<MMProductionCostIngredientCostSonsInfo> shipmentProductList = new List<MMProductionCostIngredientCostSonsInfo>();

            List<MMProductionCostIngredientCostSonsInfo> xuatSon = new List<MMProductionCostIngredientCostSonsInfo>();
            ICShipmentItemsInfo itemShipment = null;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo = null;
            ICShipmentsController objShipmentController = new ICShipmentsController();
            Dictionary<int, MMProductionCostIngredientCostSonsInfo> collection = new Dictionary<int, MMProductionCostIngredientCostSonsInfo>();
            //foreach (MMProductionCostItemsInfo productPrice in entity.ProductionCostItemList)
            foreach (int batchProductID in batchProductIDList)
            {
                //if (!batchProductIDList.Contains(productPrice.FK_MMBatchProductID))
                {
                    //if (productPrice.FK_MMBatchProductID == 432)
                    //{
                    //    //continue;
                    //    string a = "a";
                    //}
                    //shipmentItemList = objShipmentItemsController.GetShipmentItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    shipmentItemList.Clear();
                    xuatSon = entity.ProductionCostIngredientCostListSon.Where(p => p.FK_MMBatchProductID == batchProductID
                        && p.MMProductionCostIngredientCostSonReferenceType == ProductionCostIngredientCostReferenceType.XuatKho)
                        .OrderBy(item => item.FK_ICProductSerieID).ToList();
                    //foreach (MMProductionCostIngredientCostSonsInfo item in xuatSon)
                    //{
                    //    itemShipment = new ICShipmentItemsInfo();
                    //    BOSUtil.CopyObject(item, itemShipment);
                    //    objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.MMProductionCostIngredientCostSonProductSerialNo);
                    //    if (objProductSeriesInfo != null)
                    //    {
                    //        itemShipment.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                    //    }
                    //    itemShipment.FK_ICProductID = item.FK_ICProductID;
                    //    itemShipment.FK_MMBatchProductID = item.FK_MMBatchProductID;
                    //    itemShipment.ICShipmentItemProductQty = item.MMProductionCostIngredientCostSonProductQty;
                    //    itemShipment.ICShipmentItemProductUnitPrice = item.MMProductionCostIngredientCostSonProductUnitCost;
                    //    itemShipment.ICShipmentItemWoodQty = item.MMProductionCostIngredientCostSonProductWoodQty;
                    //    itemShipment.ICShipmentItemTotalAmount = item.MMProductionCostIngredientCostSonTotalCost;
                    //    itemShipment.ICShipmentNo = item.MMProductionCostIngredientCostSonReferenceNo;
                    //    itemShipment.MMBatchProductNo = item.MMProductionCostIngredientCostSonBatchProductNo;
                    //    itemShipment.MMOperationName = item.MMProductionCostIngredientCostSonOperationName;
                    //    itemShipment.ICMeasureUnitName = item.MMProductionCostIngredientCostSonMeasureUnitName;
                    //    itemShipment.ICStockName = item.MMProductionCostIngredientCostSonStockName;
                    //    itemShipment.ICProductNo = item.MMProductionCostIngredientCostSonProductNo;

                    //    ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByNo(item.MMProductionCostIngredientCostSonReferenceNo);
                    //    if (objShipmentInfo != null)
                    //    {
                    //        itemShipment.FK_ICShipmentID = objShipmentInfo.ICShipmentID;
                    //        itemShipment.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                    //        itemShipment.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                    //        itemShipment.ICShipmentType = objShipmentInfo.ICShipmentTypeCombo;
                    //    }
                    //    shipmentItemList.Add(itemShipment);
                    //}
                    //receiptItemList = objReceiptItemsController.GetReceiptItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    collection.Clear();
                    receiptItemList = entity.ProductionCostIngredientCostListSon.Where(p => p.FK_MMBatchProductID == batchProductID
                        && (p.MMProductionCostIngredientCostSonReferenceTypeCombo == ReceiptType.MaterialRedundantReceipt.ToString()
                        || p.MMProductionCostIngredientCostSonReferenceTypeCombo == ReceiptType.MaterialReturnReceipt.ToString())).ToList();

                    if (receiptItemList != null && receiptItemList.Count != 0)
                    {
                        foreach (MMProductionCostIngredientCostSonsInfo receiptItem in receiptItemList)
                        {
                            int key = receiptItem.FK_ICProductID;
                            if (!collection.Keys.Contains(key))
                                collection.Add(key, new MMProductionCostIngredientCostSonsInfo());
                            collection[key].MMProductionCostIngredientCostSonProductQty += receiptItem.MMProductionCostIngredientCostSonProductQty;
                            collection[key].MMProductionCostIngredientCostSonTotalCost += receiptItem.MMProductionCostIngredientCostSonTotalCost;
                        }
                    }

                    foreach (int key in collection.Keys)
                    {
                        if (collection[key].MMProductionCostIngredientCostSonProductQty != 0)
                            collection[key].MMProductionCostIngredientCostSonProductUnitCost = collection[key].MMProductionCostIngredientCostSonTotalCost / collection[key].MMProductionCostIngredientCostSonProductQty;
                    }

                    foreach (MMProductionCostIngredientCostSonsInfo shipmentItem in xuatSon)
                    {
                        int key = shipmentItem.FK_ICProductID;
                        decimal remainQty = 0;
                        decimal value = 0;
                        if (collection.Keys.Contains(key) &&
                            (collection[key].MMProductionCostIngredientCostSonProductQty > 0 ||
                            collection[key].MMProductionCostIngredientCostSonTotalCost > 0))
                        {
                            remainQty = Math.Min(shipmentItem.MMProductionCostIngredientCostSonProductQty, collection[key].MMProductionCostIngredientCostSonProductQty);
                            value = Math.Min(shipmentItem.MMProductionCostIngredientCostSonTotalCost, collection[key].MMProductionCostIngredientCostSonTotalCost);
                            collection[key].MMProductionCostIngredientCostSonProductQty -= remainQty;
                            collection[key].MMProductionCostIngredientCostSonTotalCost -= value;
                        }
                        if (shipmentItem.MMProductionCostIngredientCostSonProductQty != remainQty
                            || shipmentItem.MMProductionCostIngredientCostSonTotalCost != value)
                        {
                            MMProductionCostIngredientCostSonsInfo shipmentItem1 = new MMProductionCostIngredientCostSonsInfo();
                            BOSUtil.CopyObject(shipmentItem, shipmentItem1);
                            shipmentItem1.MMProductionCostIngredientCostSonProductQty = shipmentItem.MMProductionCostIngredientCostSonProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostSonProductWoodQty = shipmentItem.MMProductionCostIngredientCostSonProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostSonTotalCost -= value;
                            if (shipmentItem.MMProductionCostIngredientCostSonProductQty != 0)
                                shipmentItem1.MMProductionCostIngredientCostSonProductUnitCost = shipmentItem1.MMProductionCostIngredientCostSonTotalCost / shipmentItem1.MMProductionCostIngredientCostSonProductQty;
                            shipmentItemList.Add(shipmentItem1);
                        }
                    }

                    receiptItemList = entity.ProductionCostIngredientCostListSon.Where(p => p.FK_MMBatchProductID == batchProductID
                        //&& p.MMProductionCostIngredientCostLRReferenceType == ProductionCostIngredientCostReferenceType.NhapKho
                        && (p.MMProductionCostIngredientCostSonReferenceTypeCombo == ReceiptType.SemiProductReceipt.ToString()
                            || p.MMProductionCostIngredientCostSonReferenceTypeCombo == ReceiptType.ProductionReceipt.ToString())).ToList();


                    if (receiptItemList == null || receiptItemList.Count == 0)
                    {
                        foreach (MMProductionCostIngredientCostSonsInfo shipmentItem in shipmentItemList)
                        {
                            objProductionCostIngredientCostsInfo = new MMProductionCostIngredientCostDDSonsInfo();
                            BOSUtil.CopyObject(shipmentItem, objProductionCostIngredientCostsInfo);

                            objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonReferenceType = ProductionCostIngredientCostReferenceType.XuatKho;
                            BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                            incompleteList.Add(objProductionCostIngredientCostsInfo);
                        }
                    }
                    else
                    {
                        List<int> productIDList = new List<int>();
                        //foreach (ICShipmentItemsInfo shipmentItem in shipmentItemList)
                        foreach (MMProductionCostIngredientCostSonsInfo shipmentItem in shipmentItemList)
                        {
                            if (!productIDList.Contains(shipmentItem.FK_ICProductID))
                            {
                                if (shipmentItem.MMProductionCostIngredientCostSonReferenceTypeCombo == ShipmentType.MaterialShipment.ToString())
                                {
                                    continue;
                                }
                                decimal tongSLXuat = shipmentItemList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.MMProductionCostIngredientCostSonProductQty);
                                decimal tongSLNhap = receiptItemList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.MMProductionCostIngredientCostSonProductQty);
                                // Trừ số lượng NLP nhập lại
                                //List<ICReceiptItemsInfo> receiptItemNLPList = objReceiptItemsController.GetReceiptItemVLPByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                                //tongSLNhap += receiptItemNLPList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.ICReceiptItemProductQty);

                                decimal dodang = tongSLXuat - tongSLNhap;
                                shipmentProductList = shipmentItemList.Where(x => x.FK_ICProductID == shipmentItem.FK_ICProductID).OrderByDescending(item => item.FK_ICProductSerieID).ToList();

                                if (dodang > 0)
                                {
                                    //if (shipmentProductList.Count > 0)
                                    {
                                        //decimal remainQty = tongSLNhap;
                                        //foreach (ICShipmentItemsInfo subShipmentItem in shipmentProductList)
                                        foreach (MMProductionCostIngredientCostSonsInfo subShipmentItem in shipmentProductList)
                                        {
                                            objProductionCostIngredientCostsInfo = new MMProductionCostIngredientCostDDSonsInfo();
                                            BOSUtil.CopyObject(subShipmentItem, objProductionCostIngredientCostsInfo);
                                            //ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByID(subShipmentItem.FK_ICShipmentID);

                                            //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonBatchProductNo = subShipmentItem.MMBatchProductNo;
                                            //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonOperationName = subShipmentItem.MMOperationName;
                                            //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonMeasureUnitName = subShipmentItem.ICMeasureUnitName;
                                            //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonStockName = subShipmentItem.ICStockName;
                                            //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductNo = subShipmentItem.ICProductNo;
                                            //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonReferenceType = ProductionCostIngredientCostReferenceType.XuatKho;
                                            //if (objShipmentInfo != null)
                                            //{
                                            //    objProductionCostIngredientCostsInfo.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                                            //    objProductionCostIngredientCostsInfo.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonReferenceNo = objShipmentInfo.ICShipmentNo;
                                            //}
                                            decimal value = Math.Min(dodang, subShipmentItem.MMProductionCostIngredientCostSonProductQty);
                                            objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductQty = value;
                                            //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductUnitCost = subShipmentItem.ICShipmentItemProductUnitPrice;
                                            objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductUnitCost;
                                            BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                            incompleteList.Add(objProductionCostIngredientCostsInfo);
                                            if (Double.IsInfinity(Convert.ToDouble(objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductUnitCost)))
                                            {
                                                string a = "";
                                            }
                                            dodang -= value;
                                            if (dodang == 0)
                                                break;

                                            //if (remainQty > 0)
                                            //{
                                            //    if (subShipmentItem.ICShipmentItemProductQty - remainQty >= 0)
                                            //    {
                                            //        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductQty = subShipmentItem.ICShipmentItemProductQty - remainQty;
                                            //        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductUnitCost = subShipmentItem.ICShipmentItemProductUnitPrice;
                                            //        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductUnitCost;
                                            //        BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                            //        incompleteList.Add(objProductionCostIngredientCostsInfo);
                                            //    }
                                            //    remainQty = remainQty - subShipmentItem.ICShipmentItemProductQty;
                                            //}
                                            //else
                                            //{
                                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductQty = subShipmentItem.ICShipmentItemProductQty;
                                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductUnitCost = subShipmentItem.ICShipmentItemProductUnitPrice;
                                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductUnitCost;
                                            //    BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                            //    incompleteList.Add(objProductionCostIngredientCostsInfo);
                                            //}
                                        }
                                    }
                                }
                                else if (dodang < 0)
                                {
                                    MMProductionCostIngredientCostSonsInfo objShipmentItemsInfo = shipmentProductList[0];
                                    objProductionCostIngredientCostsInfo = new MMProductionCostIngredientCostDDSonsInfo();
                                    BOSUtil.CopyObject(objShipmentItemsInfo, objProductionCostIngredientCostsInfo);
                                    //ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByID(objShipmentItemsInfo.FK_ICShipmentID);
                                    //if (objShipmentInfo != null)
                                    //{
                                    //    objProductionCostIngredientCostsInfo.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                                    //    objProductionCostIngredientCostsInfo.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                                    //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonReferenceNo = objShipmentInfo.ICShipmentNo;
                                    //}
                                    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonBatchProductNo = objShipmentItemsInfo.MMBatchProductNo;
                                    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonOperationName = objShipmentItemsInfo.MMOperationName;
                                    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonMeasureUnitName = objShipmentItemsInfo.ICMeasureUnitName;
                                    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonStockName = objShipmentItemsInfo.ICStockName;
                                    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductNo = objShipmentItemsInfo.ICProductNo;

                                    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductQty = dodang;
                                    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductUnitCost = objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
                                    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductUnitCost;
                                    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonReferenceType = ProductionCostIngredientCostReferenceType.XuatKho;
                                    BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                    incompleteList.Add(objProductionCostIngredientCostsInfo);
                                    if (Double.IsInfinity(Convert.ToDouble(objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDSonProductUnitCost)))
                                    {
                                        string a = "";
                                    }
                                }
                                productIDList.Add(shipmentItem.FK_ICProductID);
                            }

                        }
                    }
                    //batchProductIDList.Add(productPrice.FK_MMBatchProductID);
                }
            }

            entity.ProductionCostIngredientCostListDDSon.Clear();
            entity.ProductionCostIngredientCostListDDSon.Invalidate(incompleteList);
            ProductionCostIngredientIncompleteSonGridControl.InitGridControlDataSource();
            //ProductionCostIngredientIncompleteSonGridControl.DataSource = incompleteList;
        }

        private void BindingDataSourceIncompleteDG(bool isCal, List<int> batchProductIDList)
        {
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;

            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDDongGoiNo);

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<MMProductionCostIngredientCostDGsInfo> shipmentItemList = new List<MMProductionCostIngredientCostDGsInfo>();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<MMProductionCostIngredientCostDGsInfo> receiptItemList = new List<MMProductionCostIngredientCostDGsInfo>();

            //List<int> batchProductIDList = new List<int>();
            MMProductionCostIngredientCostDDDGsInfo objProductionCostIngredientCostsInfo = null;

            List<MMProductionCostIngredientCostDDDGsInfo> incompleteList = new List<MMProductionCostIngredientCostDDDGsInfo>();
            ICReceiptsController objReceiptsController = new ICReceiptsController();

            MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();
            List<MMProductionCostIngredientCostDGsInfo> receiptItemDetailList = new List<MMProductionCostIngredientCostDGsInfo>();
            List<MMProductionCostIngredientCostDGsInfo> shipmentProductList = new List<MMProductionCostIngredientCostDGsInfo>();

            List<MMProductionCostIngredientCostDGsInfo> xuatDG = new List<MMProductionCostIngredientCostDGsInfo>();
            ICShipmentItemsInfo itemShipment = null;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo = null;
            ICShipmentsController objShipmentController = new ICShipmentsController();
            Dictionary<int, MMProductionCostIngredientCostDGsInfo> collection = new Dictionary<int, MMProductionCostIngredientCostDGsInfo>();

            //foreach (MMProductionCostItemsInfo productPrice in entity.ProductionCostItemList)
            foreach (int batchProductID in batchProductIDList)
            {
                //if (!batchProductIDList.Contains(productPrice.FK_MMBatchProductID))
                {
                    //if (batchProductID != 685)
                    //{
                    //    continue;
                    //}
                    //shipmentItemList = objShipmentItemsController.GetShipmentItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    shipmentItemList.Clear();
                    xuatDG = entity.ProductionCostIngredientCostListDG.Where(p => p.FK_MMBatchProductID == batchProductID
                        && p.MMProductionCostIngredientCostDGReferenceType == ProductionCostIngredientCostReferenceType.XuatKho).ToList();
                    //foreach (MMProductionCostIngredientCostDGsInfo item in xuatDG)
                    //{
                    //    itemShipment = new ICShipmentItemsInfo();
                    //    BOSUtil.CopyObject(item, itemShipment);
                    //    objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.MMProductionCostIngredientCostDGProductSerialNo);
                    //    if (objProductSeriesInfo != null)
                    //    {
                    //        itemShipment.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                    //    }
                    //    itemShipment.FK_ICProductID = item.FK_ICProductID;
                    //    itemShipment.FK_MMBatchProductID = item.FK_MMBatchProductID;
                    //    itemShipment.ICShipmentItemProductQty = item.MMProductionCostIngredientCostDGProductQty;
                    //    itemShipment.ICShipmentItemProductUnitPrice = item.MMProductionCostIngredientCostDGProductUnitCost;
                    //    itemShipment.ICShipmentItemWoodQty = item.MMProductionCostIngredientCostDGProductWoodQty;
                    //    itemShipment.ICShipmentItemTotalAmount = item.MMProductionCostIngredientCostDGTotalCost;
                    //    itemShipment.ICShipmentNo = item.MMProductionCostIngredientCostDGReferenceNo;
                    //    itemShipment.MMBatchProductNo = item.MMProductionCostIngredientCostDGBatchProductNo;
                    //    itemShipment.MMOperationName = item.MMProductionCostIngredientCostDGOperationName;
                    //    itemShipment.ICMeasureUnitName = item.MMProductionCostIngredientCostDGMeasureUnitName;
                    //    itemShipment.ICStockName = item.MMProductionCostIngredientCostDGStockName;
                    //    itemShipment.ICProductNo = item.MMProductionCostIngredientCostDGProductNo;

                    //    ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByNo(item.MMProductionCostIngredientCostDGReferenceNo);
                    //    if (objShipmentInfo != null)
                    //    {
                    //        itemShipment.FK_ICShipmentID = objShipmentInfo.ICShipmentID;
                    //        itemShipment.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                    //        itemShipment.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                    //        itemShipment.ICShipmentType = objShipmentInfo.ICShipmentTypeCombo;
                    //    }
                    //    shipmentItemList.Add(itemShipment);
                    //}
                    //receiptItemList = objReceiptItemsController.GetReceiptItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);

                    collection.Clear();
                    receiptItemList = entity.ProductionCostIngredientCostListDG.Where(p => p.FK_MMBatchProductID == batchProductID
                        && (p.MMProductionCostIngredientCostDGReferenceTypeCombo == ReceiptType.MaterialRedundantReceipt.ToString()
                        || p.MMProductionCostIngredientCostDGReferenceTypeCombo == ReceiptType.MaterialReturnReceipt.ToString())).ToList();

                    foreach (MMProductionCostIngredientCostDGsInfo receiptItem in receiptItemList)
                    {
                        int key = receiptItem.FK_ICProductID;
                        if (!collection.Keys.Contains(key))
                            collection.Add(key, new MMProductionCostIngredientCostDGsInfo());
                        collection[key].MMProductionCostIngredientCostDGProductQty += receiptItem.MMProductionCostIngredientCostDGProductQty;
                        collection[key].MMProductionCostIngredientCostDGTotalCost += receiptItem.MMProductionCostIngredientCostDGTotalCost;
                    }

                    foreach (int key in collection.Keys)
                    {
                        if (collection[key].MMProductionCostIngredientCostDGProductQty != 0)
                            collection[key].MMProductionCostIngredientCostDGProductUnitCost = collection[key].MMProductionCostIngredientCostDGTotalCost / collection[key].MMProductionCostIngredientCostDGProductQty;
                    }

                    foreach (MMProductionCostIngredientCostDGsInfo shipmentItem in xuatDG)
                    {
                        int key = shipmentItem.FK_ICProductID;
                        decimal remainQty = 0;
                        decimal value = 0;
                        if (collection.Keys.Contains(key) &&
                            (collection[key].MMProductionCostIngredientCostDGProductQty > 0 ||
                            collection[key].MMProductionCostIngredientCostDGTotalCost > 0))
                        {
                            remainQty = Math.Min(shipmentItem.MMProductionCostIngredientCostDGProductQty, collection[key].MMProductionCostIngredientCostDGProductQty);
                            value = Math.Min(shipmentItem.MMProductionCostIngredientCostDGTotalCost, collection[key].MMProductionCostIngredientCostDGTotalCost);
                            collection[key].MMProductionCostIngredientCostDGProductQty -= remainQty;
                            collection[key].MMProductionCostIngredientCostDGTotalCost -= value;
                        }
                        if (shipmentItem.MMProductionCostIngredientCostDGProductQty != remainQty ||
                            shipmentItem.MMProductionCostIngredientCostDGTotalCost != value)
                        {
                            MMProductionCostIngredientCostDGsInfo shipmentItem1 = new MMProductionCostIngredientCostDGsInfo();
                            BOSUtil.CopyObject(shipmentItem, shipmentItem1);
                            shipmentItem1.MMProductionCostIngredientCostDGProductQty = shipmentItem.MMProductionCostIngredientCostDGProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostDGProductWoodQty = shipmentItem.MMProductionCostIngredientCostDGProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostDGTotalCost -= value;
                            if (shipmentItem1.MMProductionCostIngredientCostDGProductQty != 0)
                                shipmentItem1.MMProductionCostIngredientCostDGProductUnitCost = shipmentItem1.MMProductionCostIngredientCostDGTotalCost / shipmentItem1.MMProductionCostIngredientCostDGProductQty;
                            shipmentItemList.Add(shipmentItem1);
                        }
                    }

                    receiptItemList = entity.ProductionCostIngredientCostListDG.Where(p => p.FK_MMBatchProductID == batchProductID
                        && (p.MMProductionCostIngredientCostDGReferenceTypeCombo == ReceiptType.SemiProductReceipt.ToString()
                        || p.MMProductionCostIngredientCostDGReferenceTypeCombo == ReceiptType.ProductionReceipt.ToString())).ToList();


                    if (receiptItemList == null || receiptItemList.Count == 0)
                    {
                        foreach (MMProductionCostIngredientCostDGsInfo shipmentItem in shipmentItemList)
                        {
                            objProductionCostIngredientCostsInfo = new MMProductionCostIngredientCostDDDGsInfo();
                            BOSUtil.CopyObject(shipmentItem, objProductionCostIngredientCostsInfo);

                            objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGReferenceType = ProductionCostIngredientCostReferenceType.XuatKho;
                            BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                            incompleteList.Add(objProductionCostIngredientCostsInfo);
                        }
                    }
                    else
                    {

                        // Kiểm tra chi tiết theo thành phẩm
                        //if (receiptItemList.Count > 0)
                        //{
                        receiptItemDetailList.Clear();
                        List<MMBatchProductProductionNormItemsInfo> bppniList = objBPPNIsController.GetBatchProductProductionNormItemsByBatchProductIDAndProductGroup(batchProductID, "SemiProduct");

                        foreach (MMProductionCostIngredientCostDGsInfo item in receiptItemList)
                        {
                            //ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)objReceiptsController.GetObjectByID(item.FK_ICReceiptID);
                            //List<MMBatchProductProductionNormItemsInfo> bppniList1 = bppniList.Where(pni => pni.MMBatchProductProductionNormItemParentID == item.FK_MMBatchProductProductionNormItemID).ToList();
                            List<MMBatchProductProductionNormItemsInfo> bppniList1 = bppniList.Where(pni =>
                                                bppniList.Where(pni1 => pni1.FK_MMBatchProductID == item.FK_MMBatchProductID
                                                    && pni1.FK_ICProductID == item.FK_ICProductID
                                                    && pni1.FK_MMBatchProductItemID == item.FK_MMBatchProductItemID)
                                                    .Any(pni2 => pni2.MMBatchProductProductionNormItemID == pni.MMBatchProductProductionNormItemParentID)).ToList();

                            foreach (MMBatchProductProductionNormItemsInfo bppni in bppniList1)
                            {
                                MMProductionCostIngredientCostDGsInfo objItem = new MMProductionCostIngredientCostDGsInfo();
                                BOSUtil.CopyObject(bppni, objItem);
                                objItem.FK_ICProductID = bppni.FK_ICProductID;
                                //objItem.ICReceiptItemProductQty = bppni.MMBatchProductProductionNormItemQuantity;
                                objItem.MMProductionCostIngredientCostDGProductQty = (bppni.MMBatchProductProductionNormItemQuantity / bppni.MMBatchProductItemProductQty) * item.MMProductionCostIngredientCostDGProductQty;
                                receiptItemDetailList.Add(objItem);
                            }
                        }
                        //}
                        //else
                        //{
                        //    receiptItemDetailList.Clear();
                        //}
                        List<int> productIDList = new List<int>();
                        foreach (MMProductionCostIngredientCostDGsInfo shipmentItem in shipmentItemList)
                        {
                            if (!productIDList.Contains(shipmentItem.FK_ICProductID))
                            {
                                if (shipmentItem.MMProductionCostIngredientCostDGReferenceTypeCombo == ShipmentType.MaterialShipment.ToString())
                                {
                                    continue;
                                }
                                decimal tongSLXuat = shipmentItemList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.MMProductionCostIngredientCostDGProductQty);
                                decimal tongSLNhap = receiptItemDetailList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.MMProductionCostIngredientCostDGProductQty);
                                //// Trừ số lượng NLP nhập lại
                                //List<ICReceiptItemsInfo> receiptItemNLPList = objReceiptItemsController.GetReceiptItemVLPByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                                //tongSLNhap += receiptItemNLPList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.ICReceiptItemProductQty);

                                decimal dodang = tongSLXuat - tongSLNhap;

                                shipmentProductList = shipmentItemList.Where(x => x.FK_ICProductID == shipmentItem.FK_ICProductID).OrderByDescending(x => x.FK_ICProductSerieID).ToList();

                                if (dodang > 0)
                                {
                                    if (shipmentProductList.Count > 0)
                                    {
                                        //decimal remainQty = tongSLNhap;
                                        foreach (MMProductionCostIngredientCostDGsInfo subShipmentItem in shipmentProductList)
                                        {
                                            objProductionCostIngredientCostsInfo = new MMProductionCostIngredientCostDDDGsInfo();
                                            BOSUtil.CopyObject(subShipmentItem, objProductionCostIngredientCostsInfo);
                                            //ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByID(subShipmentItem.FK_ICShipmentID);
                                            //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGBatchProductNo = subShipmentItem.MMBatchProductNo;
                                            //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGOperationName = subShipmentItem.MMOperationName;
                                            //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGMeasureUnitName = subShipmentItem.ICMeasureUnitName;
                                            //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGStockName = subShipmentItem.ICStockName;
                                            //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGProductNo = subShipmentItem.ICProductNo;
                                            objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGReferenceType = ProductionCostIngredientCostReferenceType.XuatKho;

                                            //if (objShipmentInfo != null)
                                            //{
                                            //    objProductionCostIngredientCostsInfo.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                                            //    objProductionCostIngredientCostsInfo.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGReferenceNo = objShipmentInfo.ICShipmentNo;
                                            //}

                                            decimal value = Math.Min(dodang, subShipmentItem.MMProductionCostIngredientCostDGProductQty);
                                            objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGProductQty = value;
                                            objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGProductQty
                                                                                                                                * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGProductUnitCost;
                                            BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                            incompleteList.Add(objProductionCostIngredientCostsInfo);

                                            dodang -= value;
                                            if (dodang == 0)
                                                break;

                                            //if (remainQty > 0)
                                            //{
                                            //    if (subShipmentItem.ICShipmentItemProductQty - remainQty >= 0)
                                            //    {
                                            //        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGProductQty = subShipmentItem.ICShipmentItemProductQty - remainQty;
                                            //        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGProductUnitCost = subShipmentItem.ICShipmentItemProductUnitPrice;
                                            //        objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGProductUnitCost;
                                            //        BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                            //        incompleteList.Add(objProductionCostIngredientCostsInfo);
                                            //    }
                                            //    remainQty = remainQty - subShipmentItem.ICShipmentItemProductQty;
                                            //}
                                            //else
                                            //{
                                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGProductQty = subShipmentItem.ICShipmentItemProductQty;
                                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGProductUnitCost = subShipmentItem.ICShipmentItemProductUnitPrice;
                                            //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGProductUnitCost;
                                            //    BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                            //    incompleteList.Add(objProductionCostIngredientCostsInfo);
                                            //}
                                        }
                                    }
                                }
                                else if (dodang < 0)
                                {
                                    MMProductionCostIngredientCostDGsInfo objShipmentItemsInfo = shipmentProductList[0];
                                    objProductionCostIngredientCostsInfo = new MMProductionCostIngredientCostDDDGsInfo();
                                    BOSUtil.CopyObject(objShipmentItemsInfo, objProductionCostIngredientCostsInfo);
                                    //ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByID(objShipmentItemsInfo.FK_ICShipmentID);
                                    //if (objShipmentInfo != null)
                                    //{
                                    //    objProductionCostIngredientCostsInfo.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                                    //    objProductionCostIngredientCostsInfo.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                                    //    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGReferenceNo = objShipmentInfo.ICShipmentNo;
                                    //}
                                    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGBatchProductNo = objShipmentItemsInfo.MMBatchProductNo;
                                    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGOperationName = objShipmentItemsInfo.MMOperationName;
                                    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGMeasureUnitName = objShipmentItemsInfo.ICMeasureUnitName;
                                    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGStockName = objShipmentItemsInfo.ICStockName;
                                    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGProductNo = objShipmentItemsInfo.ICProductNo;

                                    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGProductQty = dodang;
                                    //objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGProductUnitCost = objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
                                    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGTotalCost = objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGProductQty * objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGProductUnitCost;
                                    objProductionCostIngredientCostsInfo.MMProductionCostIngredientCostDDDGReferenceType = ProductionCostIngredientCostReferenceType.XuatKho;
                                    BOSApp.RoundByCurrency(objProductionCostIngredientCostsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                    incompleteList.Add(objProductionCostIngredientCostsInfo);
                                }
                                productIDList.Add(shipmentItem.FK_ICProductID);
                            }
                        }
                    }
                    //batchProductIDList.Add(productPrice.FK_MMBatchProductID);
                }
            }

            entity.ProductionCostIngredientCostListDDDG.Clear();
            entity.ProductionCostIngredientCostListDDDG.Invalidate(incompleteList);
            ProductionCostIngredientIncompleteDGGridControl.InitGridControlDataSource();
            //ProductionCostIngredientIncompleteDGGridControl.DataSource = incompleteList;
        }

        //private void BindingDataSource2(bool isCal)
        //{
        //    ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
        //    MMProductionCostsInfo mainObject = (MMProductionCostsInfo)entity.MainObject;
        //    BindingSource bds = new BindingSource();

        //    MMOperationsController objOperationsController = new MMOperationsController();
        //    MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDPhoiNo);
        //    if (objOperationsInfo != null)
        //    {
        //        List<MMProductionCostIngredientCostsInfo> phoiList = entity.ProductionCostIngredientCostList.Where(p => p.FK_MMOperationID == objOperationsInfo.MMOperationID).ToList();
        //        List<int> batchProductList = new List<int>();
        //        List<int> batchProductList2 = new List<int>();
        //        foreach (MMProductionCostItemsInfo item in entity.ProductionCostItemList)
        //        {
        //            if (!batchProductList.Contains(item.FK_MMBatchProductID))
        //            {
        //                List<MMProductionCostIngredientCostsInfo> phoiByBatchIDList = phoiList.Where(p => p.FK_MMBatchProductID == item.FK_MMBatchProductID).ToList();
        //                if (phoiByBatchIDList.Where(p => p.MMProductionCostIngredientCostReferenceType.Equals("2. Nhập kho")).ToList().Count == 0)
        //                {
        //                    batchProductList2.Add(item.FK_MMBatchProductID);
        //                }


        //                batchProductList.Add(item.FK_MMBatchProductID);
        //            }
        //        }

        //        foreach (int id in batchProductList2)
        //        {
        //            for (int index = 0; index < phoiList.Count(); index++)
        //            {
        //                if (id == phoiList[index].FK_MMBatchProductID)
        //                {
        //                    phoiList.RemoveAt(index);
        //                    index--;
        //                }
        //            }
        //        }
        //        entity.ProductionCostIngredientCostList1.Invalidate(phoiList);
        //        ProductionCostIngredientCostGridControl.DataSource = phoiList;
        //        if (isCal)
        //        {
        //            List<MMProductionCostIngredientCostsInfo> klList = phoiList.Where(t => t.MMProductionCostIngredientCostReferenceType == ProductionCostIngredientCostReferenceType.NhapKho).ToList();
        //            if (klList != null)
        //            {
        //                mainObject.MMProductionCostWoodQtyPhoi = klList.Sum(i => i.MMProductionCostIngredientCostProductWoodQty);
        //            }
        //            mainObject.MMProductionCostDepreciationFeePhoi = phoiList.Sum(i => i.MMProductionCostIngredientCostDepreciationFee);
        //            mainObject.MMProductionCostElecFeePhoi = phoiList.Sum(i => i.MMProductionCostIngredientCostElecFee);
        //            mainObject.MMProductionCostHardwareFeePhoi = phoiList.Sum(i => i.MMProductionCostIngredientCostHardwareFee);
        //            mainObject.MMProductionCostOtherFeePhoi = phoiList.Sum(i => i.MMProductionCostIngredientCostOtherFee);
        //            mainObject.MMProductionCostPackagingFeePhoi = phoiList.Sum(i => i.MMProductionCostIngredientCostMaintainFee);
        //            mainObject.MMProductionCostPaintFeePhoi = phoiList.Sum(i => i.MMProductionCostIngredientCostPaintFee);
        //            mainObject.MMProductionCostWoodFeePhoi = phoiList.Sum(i => i.MMProductionCostIngredientCostWoodFee);

        //        }
        //    }

        //    objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDSoCheNo);
        //    if (objOperationsInfo != null)
        //    {
        //        List<MMProductionCostIngredientCostsInfo> phoiList = entity.ProductionCostIngredientCostList.Where(p => p.FK_MMOperationID == objOperationsInfo.MMOperationID).ToList();
        //        List<int> batchProductList = new List<int>();
        //        List<int> batchProductList2 = new List<int>();
        //        foreach (MMProductionCostItemsInfo item in entity.ProductionCostItemList)
        //        {
        //            if (!batchProductList.Contains(item.FK_MMBatchProductID))
        //            {
        //                List<MMProductionCostIngredientCostsInfo> phoiByBatchIDList = phoiList.Where(p => p.FK_MMBatchProductID == item.FK_MMBatchProductID).ToList();
        //                if (phoiByBatchIDList.Where(p => p.MMProductionCostIngredientCostReferenceType.Equals("2. Nhập kho")).ToList().Count == 0)
        //                {
        //                    batchProductList2.Add(item.FK_MMBatchProductID);
        //                }
        //                batchProductList.Add(item.FK_MMBatchProductID);
        //            }
        //        }
        //        foreach (int id in batchProductList2)
        //        {
        //            for (int index = 0; index < phoiList.Count(); index++)
        //            {
        //                if (id == phoiList[index].FK_MMBatchProductID)
        //                {
        //                    phoiList.RemoveAt(index);
        //                    index--;
        //                }
        //            }
        //        }
        //        entity.ProductionCostIngredientCostList2.Invalidate(phoiList);
        //        ProductionCostIngredientCostSCGridControl.DataSource = phoiList;
        //        if (isCal)
        //        {
        //            List<MMProductionCostIngredientCostsInfo> klList = phoiList.Where(t => t.MMProductionCostIngredientCostReferenceType == ProductionCostIngredientCostReferenceType.NhapKho).ToList();
        //            if (klList != null)
        //            {
        //                mainObject.MMProductionCostWoodQtySoChe = klList.Sum(i => i.MMProductionCostIngredientCostProductWoodQty);
        //            }
        //            mainObject.MMProductionCostDepreciationFeeSoChe = phoiList.Sum(i => i.MMProductionCostIngredientCostDepreciationFee);
        //            mainObject.MMProductionCostElecFeeSoChe = phoiList.Sum(i => i.MMProductionCostIngredientCostElecFee);
        //            mainObject.MMProductionCostHardwareFeeSoChe = phoiList.Sum(i => i.MMProductionCostIngredientCostHardwareFee);
        //            mainObject.MMProductionCostOtherFeeSoChe = phoiList.Sum(i => i.MMProductionCostIngredientCostOtherFee);
        //            mainObject.MMProductionCostPackagingFeeSoChe = phoiList.Sum(i => i.MMProductionCostIngredientCostMaintainFee);
        //            mainObject.MMProductionCostPaintFeeSoChe = phoiList.Sum(i => i.MMProductionCostIngredientCostPaintFee);
        //            mainObject.MMProductionCostWoodFeeSoChe = phoiList.Sum(i => i.MMProductionCostIngredientCostWoodFee);

        //        }
        //    }

        //    objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDTinhCheNo);
        //    if (objOperationsInfo != null)
        //    {
        //        List<MMProductionCostIngredientCostsInfo> phoiList = entity.ProductionCostIngredientCostList.Where(p => p.FK_MMOperationID == objOperationsInfo.MMOperationID).ToList();
        //        List<int> batchProductList = new List<int>();
        //        List<int> batchProductList2 = new List<int>();
        //        foreach (MMProductionCostItemsInfo item in entity.ProductionCostItemList)
        //        {
        //            if (!batchProductList.Contains(item.FK_MMBatchProductID))
        //            {
        //                List<MMProductionCostIngredientCostsInfo> phoiByBatchIDList = phoiList.Where(p => p.FK_MMBatchProductID == item.FK_MMBatchProductID).ToList();
        //                if (phoiByBatchIDList.Where(p => p.MMProductionCostIngredientCostReferenceType.Equals("2. Nhập kho")).ToList().Count == 0)
        //                {
        //                    batchProductList2.Add(item.FK_MMBatchProductID);
        //                }
        //                batchProductList.Add(item.FK_MMBatchProductID);
        //            }
        //        }
        //        foreach (int id in batchProductList2)
        //        {
        //            for (int index = 0; index < phoiList.Count(); index++)
        //            {
        //                if (id == phoiList[index].FK_MMBatchProductID)
        //                {
        //                    phoiList.RemoveAt(index);
        //                    index--;
        //                }
        //            }
        //        }
        //        entity.ProductionCostIngredientCostList3.Invalidate(phoiList);
        //        ProductionCostIngredientCostTCGridControl.DataSource = phoiList;
        //        if (isCal)
        //        {
        //            List<MMProductionCostIngredientCostsInfo> klList = phoiList.Where(t => t.MMProductionCostIngredientCostReferenceType == ProductionCostIngredientCostReferenceType.NhapKho).ToList();
        //            if (klList != null)
        //            {
        //                mainObject.MMProductionCostWoodQtyTinhChe = klList.Sum(i => i.MMProductionCostIngredientCostProductWoodQty);
        //            }
        //            mainObject.MMProductionCostDepreciationFeeTinhChe = phoiList.Sum(i => i.MMProductionCostIngredientCostDepreciationFee);
        //            mainObject.MMProductionCostElecFeeTinhChe = phoiList.Sum(i => i.MMProductionCostIngredientCostElecFee);
        //            mainObject.MMProductionCostHardwareFeeTinhChe = phoiList.Sum(i => i.MMProductionCostIngredientCostHardwareFee);
        //            mainObject.MMProductionCostOtherFeeTinhChe = phoiList.Sum(i => i.MMProductionCostIngredientCostOtherFee);
        //            mainObject.MMProductionCostPackagingFeeTinhChe = phoiList.Sum(i => i.MMProductionCostIngredientCostMaintainFee);
        //            mainObject.MMProductionCostPaintFeeTinhChe = phoiList.Sum(i => i.MMProductionCostIngredientCostPaintFee);
        //            mainObject.MMProductionCostWoodFeeTinhChe = phoiList.Sum(i => i.MMProductionCostIngredientCostWoodFee);
        //        }
        //    }
        //    objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDLapRapNo);
        //    if (objOperationsInfo != null)
        //    {
        //        List<MMProductionCostIngredientCostsInfo> phoiList = entity.ProductionCostIngredientCostList.Where(p => p.FK_MMOperationID == objOperationsInfo.MMOperationID).ToList();
        //        List<int> batchProductList = new List<int>();
        //        List<int> batchProductList2 = new List<int>();
        //        foreach (MMProductionCostItemsInfo item in entity.ProductionCostItemList)
        //        {
        //            if (!batchProductList.Contains(item.FK_MMBatchProductID))
        //            {
        //                List<MMProductionCostIngredientCostsInfo> phoiByBatchIDList = phoiList.Where(p => p.FK_MMBatchProductID == item.FK_MMBatchProductID).ToList();
        //                if (phoiByBatchIDList.Where(p => p.MMProductionCostIngredientCostReferenceType.Equals("2. Nhập kho")).ToList().Count == 0)
        //                {
        //                    batchProductList2.Add(item.FK_MMBatchProductID);
        //                }
        //                batchProductList.Add(item.FK_MMBatchProductID);
        //            }
        //        }
        //        foreach (int id in batchProductList2)
        //        {
        //            for (int index = 0; index < phoiList.Count(); index++)
        //            {
        //                if (id == phoiList[index].FK_MMBatchProductID)
        //                {
        //                    phoiList.RemoveAt(index);
        //                    index--;
        //                }
        //            }
        //        }
        //        entity.ProductionCostIngredientCostList4.Invalidate(phoiList);
        //        ProductionCostIngredientCostLRGridControl.DataSource = phoiList;
        //        if (isCal)
        //        {
        //            List<MMProductionCostIngredientCostsInfo> klList = phoiList.Where(t => t.MMProductionCostIngredientCostReferenceType == ProductionCostIngredientCostReferenceType.NhapKho).ToList();
        //            if (klList != null)
        //            {
        //                mainObject.MMProductionCostWoodQtyLapRap = klList.Sum(i => i.MMProductionCostIngredientCostProductWoodQty);
        //            }
        //            mainObject.MMProductionCostDepreciationFeeLapRap = phoiList.Sum(i => i.MMProductionCostIngredientCostDepreciationFee);
        //            mainObject.MMProductionCostElecFeeLapRap = phoiList.Sum(i => i.MMProductionCostIngredientCostElecFee);
        //            mainObject.MMProductionCostHardwareFeeLapRap = phoiList.Sum(i => i.MMProductionCostIngredientCostHardwareFee);
        //            mainObject.MMProductionCostOtherFeeLapRap = phoiList.Sum(i => i.MMProductionCostIngredientCostOtherFee);
        //            mainObject.MMProductionCostPackagingFeeLapRap = phoiList.Sum(i => i.MMProductionCostIngredientCostMaintainFee);
        //            mainObject.MMProductionCostPaintFeeLapRap = phoiList.Sum(i => i.MMProductionCostIngredientCostPaintFee);
        //            mainObject.MMProductionCostWoodFeeLapRap = phoiList.Sum(i => i.MMProductionCostIngredientCostWoodFee);
        //        }
        //    }
        //    objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDSonNo);
        //    if (objOperationsInfo != null)
        //    {
        //        List<MMProductionCostIngredientCostsInfo> phoiList = entity.ProductionCostIngredientCostList.Where(p => p.FK_MMOperationID == objOperationsInfo.MMOperationID).ToList();
        //        List<int> batchProductList = new List<int>();
        //        List<int> batchProductList2 = new List<int>();
        //        foreach (MMProductionCostItemsInfo item in entity.ProductionCostItemList)
        //        {
        //            if (!batchProductList.Contains(item.FK_MMBatchProductID))
        //            {
        //                List<MMProductionCostIngredientCostsInfo> phoiByBatchIDList = phoiList.Where(p => p.FK_MMBatchProductID == item.FK_MMBatchProductID).ToList();
        //                if (phoiByBatchIDList.Where(p => p.MMProductionCostIngredientCostReferenceType.Equals("2. Nhập kho")).ToList().Count == 0)
        //                {
        //                    batchProductList2.Add(item.FK_MMBatchProductID);
        //                }
        //                batchProductList.Add(item.FK_MMBatchProductID);
        //            }
        //        }
        //        foreach (int id in batchProductList2)
        //        {
        //            for (int index = 0; index < phoiList.Count(); index++)
        //            {
        //                if (id == phoiList[index].FK_MMBatchProductID)
        //                {
        //                    phoiList.RemoveAt(index);
        //                    index--;
        //                }
        //            }
        //        }
        //        entity.ProductionCostIngredientCostList5.Invalidate(phoiList);
        //        ProductionCostIngredientCostSonGridControl.DataSource = phoiList;
        //        if (isCal)
        //        {
        //            List<MMProductionCostIngredientCostsInfo> klList = phoiList.Where(t => t.MMProductionCostIngredientCostReferenceType == ProductionCostIngredientCostReferenceType.NhapKho).ToList();
        //            if (klList != null)
        //            {
        //                mainObject.MMProductionCostWoodQtySon = klList.Sum(i => i.MMProductionCostIngredientCostProductWoodQty);
        //            }
        //            mainObject.MMProductionCostDepreciationFeeSon = phoiList.Sum(i => i.MMProductionCostIngredientCostDepreciationFee);
        //            mainObject.MMProductionCostElecFeeSon = phoiList.Sum(i => i.MMProductionCostIngredientCostElecFee);
        //            mainObject.MMProductionCostHardwareFeeSon = phoiList.Sum(i => i.MMProductionCostIngredientCostHardwareFee);
        //            mainObject.MMProductionCostOtherFeeSon = phoiList.Sum(i => i.MMProductionCostIngredientCostOtherFee);
        //            mainObject.MMProductionCostPackagingFeeSon = phoiList.Sum(i => i.MMProductionCostIngredientCostMaintainFee);
        //            mainObject.MMProductionCostPaintFeeSon = phoiList.Sum(i => i.MMProductionCostIngredientCostPaintFee);
        //            mainObject.MMProductionCostWoodFeeSon = phoiList.Sum(i => i.MMProductionCostIngredientCostWoodFee);
        //        }
        //    }

        //    objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDDongGoiNo);
        //    if (objOperationsInfo != null)
        //    {
        //        List<MMProductionCostIngredientCostsInfo> phoiList = entity.ProductionCostIngredientCostList.Where(p => p.FK_MMOperationID == objOperationsInfo.MMOperationID).ToList();
        //        List<int> batchProductList = new List<int>();
        //        List<int> batchProductList2 = new List<int>();
        //        foreach (MMProductionCostItemsInfo item in entity.ProductionCostItemList)
        //        {
        //            if (!batchProductList.Contains(item.FK_MMBatchProductID))
        //            {
        //                List<MMProductionCostIngredientCostsInfo> phoiByBatchIDList = phoiList.Where(p => p.FK_MMBatchProductID == item.FK_MMBatchProductID).ToList();
        //                if (phoiByBatchIDList.Where(p => p.MMProductionCostIngredientCostReferenceType.Equals("2. Nhập kho")).ToList().Count == 0)
        //                {
        //                    batchProductList2.Add(item.FK_MMBatchProductID);
        //                }
        //                batchProductList.Add(item.FK_MMBatchProductID);
        //            }
        //        }
        //        foreach (int id in batchProductList2)
        //        {
        //            for (int index = 0; index < phoiList.Count(); index++)
        //            {
        //                if (id == phoiList[index].FK_MMBatchProductID)
        //                {
        //                    phoiList.RemoveAt(index);
        //                    index--;
        //                }
        //            }
        //        }
        //        entity.ProductionCostIngredientCostList6.Invalidate(phoiList);
        //        ProductionCostIngredientCostDGGridControl.DataSource = phoiList;

        //        if (isCal)
        //        {
        //            List<MMProductionCostIngredientCostsInfo> klList = phoiList.Where(t => t.MMProductionCostIngredientCostReferenceType == ProductionCostIngredientCostReferenceType.NhapKho).ToList();
        //            if (klList != null)
        //            {
        //                mainObject.MMProductionCostWoodQtyDongGoi = klList.Sum(i => i.MMProductionCostIngredientCostProductWoodQty);
        //            }
        //            mainObject.MMProductionCostDepreciationFeeDongGoi = phoiList.Sum(i => i.MMProductionCostIngredientCostDepreciationFee);
        //            mainObject.MMProductionCostElecFeeDongGoi = phoiList.Sum(i => i.MMProductionCostIngredientCostElecFee);
        //            mainObject.MMProductionCostHardwareFeeDongGoi = phoiList.Sum(i => i.MMProductionCostIngredientCostHardwareFee);
        //            mainObject.MMProductionCostOtherFeeDongGoi = phoiList.Sum(i => i.MMProductionCostIngredientCostOtherFee);
        //            mainObject.MMProductionCostPackagingFeeDongGoi = phoiList.Sum(i => i.MMProductionCostIngredientCostMaintainFee);
        //            mainObject.MMProductionCostPaintFeeDongGoi = phoiList.Sum(i => i.MMProductionCostIngredientCostPaintFee);
        //            mainObject.MMProductionCostWoodFeeDongGoi = phoiList.Sum(i => i.MMProductionCostIngredientCostWoodFee);
        //        }
        //    }
        //    if (isCal)
        //    {
        //        mainObject.MMProductionCostWoodQty = mainObject.MMProductionCostWoodQtyPhoi
        //                                            + mainObject.MMProductionCostWoodQtySoChe
        //                                            + mainObject.MMProductionCostWoodQtyTinhChe
        //                                            + mainObject.MMProductionCostWoodQtyLapRap
        //                                            + mainObject.MMProductionCostWoodQtySon
        //                                            + mainObject.MMProductionCostWoodQtyDongGoi;
        //    }

        //}

        public void ExecUpdateCostOprationPhoi()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            List<ICReceiptItemsInfo> receiptItemList = new List<ICReceiptItemsInfo>();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDPhoiNo);
            receiptItemList = objReceiptItemsController.GetReceiptItemByOperationIDAndDate(objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            int percent = 0;
            foreach (ICReceiptItemsInfo receiptItem in receiptItemList)
            {
                percent++;
                decimal pct = (percent * 100) / receiptItemList.Count;
                BOSProgressBar.Start("Đang cập nhật hạch toán phôi  " + Math.Round(pct) + " % ");

                if (receiptItem.ICReceiptItemProductUnitCost > 0 && receiptItem.FK_ICProductSerieID > 0)
                {
                CHAYLAI:
                    try
                    {
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B3", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B7", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B8", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        // Receipt Accounting
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B4", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B5", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B6", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                    }
                    catch (Exception ex)
                    {
                        goto CHAYLAI;
                    }
                }
            }
            BOSProgressBar.Close();
        }

        public void ExecUpdateCostOprationSC()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            List<ICReceiptItemsInfo> receiptItemList = new List<ICReceiptItemsInfo>();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDSoCheNo);
            receiptItemList = objReceiptItemsController.GetReceiptItemByOperationIDAndDate(objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            int percent = 0;
            foreach (ICReceiptItemsInfo receiptItem in receiptItemList)
            {
                percent++;
                decimal pct = (percent * 100) / receiptItemList.Count;
                BOSProgressBar.Start("Đang cập nhật hạch toán sơ chế  " + Math.Round(pct) + " % ");

                if (receiptItem.ICReceiptItemProductUnitCost > 0 && receiptItem.FK_ICProductSerieID > 0)
                {
                CHAYLAI:
                    try
                    {
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B3", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B7", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B8", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        // Receipt Accounting
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B4", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B5", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B6", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                    }
                    catch (Exception ex)
                    {
                        goto CHAYLAI;
                    }
                }
            }
            BOSProgressBar.Close();
        }

        public void ExecUpdateCostOprationTC()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            List<ICReceiptItemsInfo> receiptItemList = new List<ICReceiptItemsInfo>();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDTinhCheNo);

            receiptItemList = objReceiptItemsController.GetReceiptItemByOperationIDAndDate(objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            int percent = 0;
            foreach (ICReceiptItemsInfo receiptItem in receiptItemList)
            {
                percent++;
                decimal pct = (percent * 100) / receiptItemList.Count;
                BOSProgressBar.Start("Đang cập nhật hạch toán tinh chế  " + Math.Round(pct) + " % ");

                if (receiptItem.ICReceiptItemProductUnitCost > 0 && receiptItem.FK_ICProductSerieID > 0)
                {
                CHAYLAI:
                    try
                    {
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B3", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B7", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B8", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        // Receipt Accounting
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B4", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B5", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B6", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                    }
                    catch (Exception ex)
                    {
                        goto CHAYLAI;
                    }
                }
            }
            BOSProgressBar.Close();
        }

        public void ExecUpdateCostOprationLR()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            List<ICReceiptItemsInfo> receiptItemList = new List<ICReceiptItemsInfo>();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDLapRapNo);

            receiptItemList = objReceiptItemsController.GetReceiptItemByOperationIDAndDate(objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            int percent = 0;
            foreach (ICReceiptItemsInfo receiptItem in receiptItemList)
            {
                percent++;
                decimal pct = (percent * 100) / receiptItemList.Count;
                BOSProgressBar.Start("Đang cập nhật hạch toán lắp ráp  " + Math.Round(pct) + " % ");

                if (receiptItem.ICReceiptItemProductUnitCost > 0 && receiptItem.FK_ICProductSerieID > 0)
                {
                CHAYLAI:
                    try
                    {
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B3", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B7", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B8", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        // Receipt Accounting
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B4", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B5", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B6", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                    }
                    catch (Exception ex)
                    {
                        goto CHAYLAI;
                    }
                }
            }
            BOSProgressBar.Close();
        }

        public void ExecUpdateCostOprationSon()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            List<ICReceiptItemsInfo> receiptItemList = new List<ICReceiptItemsInfo>();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();

            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDSonNo);

            receiptItemList = objReceiptItemsController.GetReceiptItemByOperationIDAndDate(objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            int percent = 0;
            foreach (ICReceiptItemsInfo receiptItem in receiptItemList)
            {
                percent++;
                decimal pct = (percent * 100) / receiptItemList.Count;
                BOSProgressBar.Start("Đang cập nhật hạch toán sơn  " + Math.Round(pct) + " % ");

                //if (!receiptItem.MMBatchProductNo.Equals("LSX.M-16.0312"))
                //{
                //    continue;
                //}

                if (receiptItem.ICReceiptItemProductUnitCost > 0 && receiptItem.FK_ICProductSerieID > 0)
                {
                CHAYLAI:
                    try
                    {
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B3", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B7", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B8", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        // Receipt Accounting
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B4", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B5", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B6", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                    }
                    catch (Exception ex)
                    {
                        goto CHAYLAI;
                    }
                }
            }
            BOSProgressBar.Close();
        }

        public void ExecUpdateCostOprationDG()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            List<ICReceiptItemsInfo> receiptItemList = new List<ICReceiptItemsInfo>();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();

            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDDongGoiNo);

            receiptItemList = objReceiptItemsController.GetReceiptItemByOperationIDAndDate(objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            int percent = 0;
            foreach (ICReceiptItemsInfo receiptItem in receiptItemList)
            {
                percent++;
                decimal pct = (percent * 100) / receiptItemList.Count;
                BOSProgressBar.Start("Đang cập nhật hạch toán đóng gói  " + Math.Round(pct) + " % ");

                if (receiptItem.ICReceiptItemProductUnitCost > 0 && receiptItem.FK_ICProductSerieID > 0)
                {
                CHAYLAI:
                    try
                    {
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B3", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B7", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B8", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        // Receipt Accounting
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B4", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B5", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_B6", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                    }
                    catch (Exception ex)
                    {
                        goto CHAYLAI;
                    }
                }
            }
            BOSProgressBar.Close();
        }

        public void ExecCostOprationPhoi(bool isChange)
        {
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            string CPNCTTAccountNo = "6224";
            string CPChungTTAccountNo = "6273";
            decimal chiPhiNhanCongTT = GetDocumentEntryAmountByAccountNo(CPNCTTAccountNo)
                - GetDocumentEntryCreditAmountByAccountNo(CPNCTTAccountNo);
            decimal chiPhiChungTT = GetDocumentEntryAmountByAccountNo(CPChungTTAccountNo)
                - GetDocumentEntryCreditAmountByAccountNo(CPChungTTAccountNo);
            decimal chiPhiChungNhaMay = GetDocumentEntryAmountByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay6279)
                    - GetDocumentEntryCreditAmountByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay6279);
            if (chiPhiNhanCongTT == 0 || chiPhiChungTT == 0 || chiPhiChungNhaMay == 0)
            {
                if (MessageBox.Show("Có chi phí sản xuất không xác định được, bạn có muốn tiếp tục?", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    BOSProgressBar.Close();
                    return;
                }
            }
            decimal chiPhi6279 = chiPhiChungNhaMay;
            objProductionCostsInfo.MMProductionCost6279FeeP = 0;
            decimal chiPhiKhauHao = GetDocumentEntryAmountByAccountNo("62732");
            decimal chiPhiTienDien = GetDocumentEntryAmountByAccountNo("62794");
            decimal chiPhiHW = 0;
            decimal chiPhiSon = 0;
            decimal chiPhiBaoBi = 0;


            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDPhoiNo);

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<MMProductionCostIngredientCostsInfo> shipmentItemList = new List<MMProductionCostIngredientCostsInfo>();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> receiptItemList = new List<ICReceiptItemsInfo>();
            List<ICReceiptItemsInfo> receiptItemList1;
            List<MMProductionCostIngredientCostsInfo> shipmentItemOtherList;
            BOSDbUtil dbUtil = new BOSDbUtil();
            decimal chiPhiXuatKhoGo = 0;
            decimal chiPhiXuatKhoKhac = 0;
            decimal chiPhiKhac = 0;
            decimal TongM3TinhLSX = 0;
            decimal TongM3Tinh = 0;
            decimal tongM3TinhToanNhaMay = 0;
            ICShipmentItemsInfo objShipmentItemsInfo;

            receiptItemList = objReceiptItemsController.GetReceiptItemByOperationIDAndDate(objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            List<ICReceiptItemsInfo> receiptItems = objReceiptItemsController.GetReceiptItemByAllOperationIDAndDate(objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            TongM3Tinh = receiptItemList.Sum(e => e.ICReceiptItemWoodQty);
            tongM3TinhToanNhaMay = receiptItems.Sum(e => e.ICReceiptItemWoodQty);
            //TongM3Tinh = receiptItemList.Sum(e => e.ICReceiptItemProductHeight * e.ICReceiptItemProductWidth * e.ICReceiptItemProductLength * e.ICReceiptItemProductQty / 1000000000);
            //tongM3TinhToanNhaMay = receiptItems.Sum(e => e.ICReceiptItemProductHeight * e.ICReceiptItemProductWidth * e.ICReceiptItemProductLength * e.ICReceiptItemProductQty / 1000000000);
            //List<int> batchProductIDList = new List<int>();
            dbUtil.ExecuteNonQuery("ResetInventoryCostByOperationID", objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);

            MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();
            MMWoodPlanItemDetailsController objWoodPlanItemDetailsController = new MMWoodPlanItemDetailsController();
            int percent = 0;

            List<MMProductionCostIngredientCostsInfo> xuatPhoi = new List<MMProductionCostIngredientCostsInfo>();
            List<MMProductionCostIngredientCostsInfo> nhapPhoi;
            ICShipmentItemsInfo itemShipment = null;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo = null;
            ICShipmentsController objShipmentController = new ICShipmentsController();

            List<int> batchProductIDList = entity.ProductionCostItemList.Select(item => item.FK_MMBatchProductID).Distinct().ToList();
            Dictionary<int, MMProductionCostIngredientCostsInfo> collection = new Dictionary<int, MMProductionCostIngredientCostsInfo>();

            //foreach (MMProductionCostItemsInfo productPrice in entity.ProductionCostItemList)
            foreach (int batchProductID in batchProductIDList)
            {
                percent++;
                decimal pct = (percent * 100) / batchProductIDList.Count;
                BOSProgressBar.Start("Đang tính giá thành phôi  " + Math.Round(pct) + " % ");

                //if (!batchProductIDList.Contains(productPrice.FK_MMBatchProductID))
                {
                    //if (batchProductID == 573 || batchProductID == 745 || batchProductID == 772 || batchProductID == 776 || batchProductID == 784)
                    if (batchProductID == 1356 || batchProductID == 1391)
                    {
                        string a = "";
                    }
                    chiPhiXuatKhoKhac = 0;
                    chiPhiHW = 0;
                    chiPhiSon = 0;
                    chiPhiBaoBi = 0;
                    //shipmentItemOtherList = objShipmentItemsController.GetShipmentItemOtherBySomeCriteria(productPrice.FK_ICProductIDForBatch, productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    shipmentItemOtherList = entity.ProductionCostIngredientCostListPhoi.Where(item => item.FK_MMBatchProductID == batchProductID
                                                                        && item.MMProductionCostIngredientCostReferenceTypeCombo == ShipmentType.MaterialShipment.ToString()).ToList();

                    //foreach (ICShipmentItemsInfo shipmentItem in shipmentItemOtherList)
                    foreach (MMProductionCostIngredientCostsInfo shipmentItem in shipmentItemOtherList)
                    {
                        chiPhiXuatKhoKhac += shipmentItem.MMProductionCostIngredientCostTotalCost;
                        ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(i => i.ICProductID == shipmentItem.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            if (objProductsInfo.ICProductType == ProductType.Hardware.ToString())
                            {
                                chiPhiHW += shipmentItem.MMProductionCostIngredientCostTotalCost;
                            }
                            else if (objProductsInfo.ICProductType == ProductType.IngredientPackaging.ToString())
                            {
                                chiPhiBaoBi += shipmentItem.MMProductionCostIngredientCostTotalCost;
                            }
                            else if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString())
                            {
                                chiPhiSon += shipmentItem.MMProductionCostIngredientCostTotalCost;
                            }
                            else
                            {
                                chiPhiHW += shipmentItem.MMProductionCostIngredientCostTotalCost;
                            }
                        }
                    }

                    chiPhiKhac = 0;
                    foreach (MMProductionCostOtherFeesInfo item in entity.ProductionCostOtherFeesList)
                    {
                        if (item.FK_MMBatchProductID == batchProductID
                            && item.FK_MMOperationID == objOperationsInfo.MMOperationID)
                        {
                            chiPhiKhac += item.MMProductionCostOtherFeeTotalAmount;
                        }
                    }

                    chiPhiXuatKhoGo = 0;

                    //shipmentItemList = objShipmentItemsController.GetShipmentItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    shipmentItemList.Clear();
                    xuatPhoi = entity.ProductionCostIngredientCostListPhoi.Where(p => p.FK_MMBatchProductID == batchProductID
                        && p.MMProductionCostIngredientCostReferenceTypeCombo == ShipmentType.DryLumber.ToString())
                                                                .OrderBy(item => item.FK_ICProductSerieID).ToList();


                    nhapPhoi = entity.ProductionCostIngredientCostListPhoi.Where(item => item.FK_MMBatchProductID == batchProductID
                                                                                    && item.FK_MMOperationID == objOperationsInfo.MMOperationID
                                                                                    && item.MMProductionCostIngredientCostReferenceNo.IndexOf("NKPK") >= 0).ToList();

                    collection.Clear();
                    shipmentItemList.Clear();

                    //foreach (MMProductionCostIngredientCostsInfo receiptItem in nhapPhoi)
                    //{
                    //    string key = receiptItem.FK_ICProductID + "-" + receiptItem.FK_ICProductSerieID;
                    //    if (!collection.Keys.Contains(key))
                    //        collection.Add(key, 0);
                    //    collection[key] += receiptItem.MMProductionCostIngredientCostProductQty;
                    //}


                    //foreach (MMProductionCostIngredientCostsInfo shipmentItem in xuatPhoi)
                    //{
                    //    string key = shipmentItem.FK_ICProductID + "-" + shipmentItem.FK_ICProductSerieID;
                    //    decimal remainQty = 0;
                    //    if (collection.Keys.Contains(key) && collection[key] > 0)
                    //    {
                    //        remainQty = Math.Min(shipmentItem.MMProductionCostIngredientCostProductQty, collection[key]);
                    //        collection[key] -= remainQty;
                    //    }
                    //    if (shipmentItem.MMProductionCostIngredientCostProductQty > remainQty)
                    //    {
                    //        MMProductionCostIngredientCostsInfo shipmentItem1 = new MMProductionCostIngredientCostsInfo();
                    //        BOSUtil.CopyObject(shipmentItem, shipmentItem1);
                    //        shipmentItem1.MMProductionCostIngredientCostProductQty = shipmentItem.MMProductionCostIngredientCostProductQty - remainQty;
                    //        shipmentItem1.MMProductionCostIngredientCostProductWoodQty = shipmentItem.MMProductionCostIngredientCostProductQty - remainQty;
                    //        shipmentItem1.MMProductionCostIngredientCostTotalCost = shipmentItem1.MMProductionCostIngredientCostProductQty * shipmentItem1.MMProductionCostIngredientCostProductUnitCost;
                    //        shipmentItemList.Add(shipmentItem1);
                    //    }
                    //}

                    foreach (MMProductionCostIngredientCostsInfo receiptItem in nhapPhoi)
                    {
                        //if (receiptItem.MMProductionCostIngredientCostProductUnitCost != 0)
                        {
                            //string key = receiptItem.FK_ICProductID + "-" + receiptItem.FK_ICProductSerieID;
                            if (!collection.Keys.Contains(receiptItem.FK_ICProductID))
                                collection.Add(receiptItem.FK_ICProductID, new MMProductionCostIngredientCostsInfo());
                            collection[receiptItem.FK_ICProductID].MMProductionCostIngredientCostProductQty += receiptItem.MMProductionCostIngredientCostProductQty;
                            collection[receiptItem.FK_ICProductID].MMProductionCostIngredientCostTotalCost += receiptItem.MMProductionCostIngredientCostTotalCost;
                        }
                    }

                    foreach (int key in collection.Keys)
                    {
                        if (collection[key].MMProductionCostIngredientCostProductQty != 0)
                            collection[key].MMProductionCostIngredientCostProductUnitCost = collection[key].MMProductionCostIngredientCostTotalCost / collection[key].MMProductionCostIngredientCostProductQty;
                    }

                    foreach (MMProductionCostIngredientCostsInfo shipmentItem in xuatPhoi)
                    {
                        int key = shipmentItem.FK_ICProductID;
                        decimal remainQty = 0;
                        decimal value = 0;
                        if (collection.Keys.Contains(key) &&
                            (collection[key].MMProductionCostIngredientCostProductQty > 0 ||
                            collection[key].MMProductionCostIngredientCostTotalCost > 0))
                        {
                            remainQty = Math.Min(shipmentItem.MMProductionCostIngredientCostProductQty, collection[key].MMProductionCostIngredientCostProductQty);
                            value = Math.Min(shipmentItem.MMProductionCostIngredientCostTotalCost, collection[key].MMProductionCostIngredientCostTotalCost);
                            collection[key].MMProductionCostIngredientCostProductQty -= remainQty;
                            collection[key].MMProductionCostIngredientCostTotalCost -= value;
                        }
                        if (shipmentItem.MMProductionCostIngredientCostProductQty != remainQty ||
                            shipmentItem.MMProductionCostIngredientCostTotalCost != value)
                        {
                            MMProductionCostIngredientCostsInfo shipmentItem1 = new MMProductionCostIngredientCostsInfo();
                            BOSUtil.CopyObject(shipmentItem, shipmentItem1);
                            shipmentItem1.MMProductionCostIngredientCostProductQty = shipmentItem.MMProductionCostIngredientCostProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostProductWoodQty = shipmentItem.MMProductionCostIngredientCostProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostTotalCost = shipmentItem1.MMProductionCostIngredientCostTotalCost - value;
                            //shipmentItem1.MMProductionCostIngredientCostTotalCost = shipmentItem1.MMProductionCostIngredientCostProductQty * shipmentItem1.MMProductionCostIngredientCostProductUnitCost;
                            if (shipmentItem1.MMProductionCostIngredientCostProductQty != 0)
                                shipmentItem1.MMProductionCostIngredientCostProductUnitCost = shipmentItem1.MMProductionCostIngredientCostTotalCost / shipmentItem1.MMProductionCostIngredientCostProductQty;
                            shipmentItemList.Add(shipmentItem1);
                        }

                        //if (shipmentItem.MMProductionCostIngredientCostProductQty > remainQty)
                        //{
                        //    MMProductionCostIngredientCostsInfo shipmentItem1 = new MMProductionCostIngredientCostsInfo();
                        //    BOSUtil.CopyObject(shipmentItem, shipmentItem1);
                        //    shipmentItem1.MMProductionCostIngredientCostProductQty = shipmentItem.MMProductionCostIngredientCostProductQty - remainQty;
                        //    shipmentItem1.MMProductionCostIngredientCostProductWoodQty = shipmentItem.MMProductionCostIngredientCostProductQty - remainQty;
                        //    shipmentItem1.MMProductionCostIngredientCostTotalCost = shipmentItem1.MMProductionCostIngredientCostTotalCost - value;
                        //    //shipmentItem1.MMProductionCostIngredientCostTotalCost = shipmentItem1.MMProductionCostIngredientCostProductQty * shipmentItem1.MMProductionCostIngredientCostProductUnitCost;
                        //    if (shipmentItem1.MMProductionCostIngredientCostProductQty != 0)
                        //        shipmentItem1.MMProductionCostIngredientCostProductUnitCost = shipmentItem1.MMProductionCostIngredientCostTotalCost / shipmentItem1.MMProductionCostIngredientCostProductQty;
                        //    shipmentItemList.Add(shipmentItem1);
                        //}
                    }

                    //foreach (MMProductionCostIngredientCostsInfo item in xuatPhoi)
                    //{
                    //    itemShipment = new ICShipmentItemsInfo();
                    //    BOSUtil.CopyObject(item, itemShipment);
                    //    objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.MMProductionCostIngredientCostProductSerialNo);
                    //    if (objProductSeriesInfo != null)
                    //    {
                    //        itemShipment.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                    //    }
                    //    itemShipment.FK_ICProductID = item.FK_ICProductID;
                    //    itemShipment.FK_MMBatchProductID = item.FK_MMBatchProductID;
                    //    itemShipment.ICShipmentItemProductQty = item.MMProductionCostIngredientCostProductQty;
                    //    itemShipment.ICShipmentItemProductUnitPrice = item.MMProductionCostIngredientCostProductUnitCost;
                    //    itemShipment.ICShipmentItemWoodQty = item.MMProductionCostIngredientCostProductWoodQty;
                    //    itemShipment.ICShipmentItemTotalAmount = item.MMProductionCostIngredientCostTotalCost;
                    //    itemShipment.ICShipmentNo = item.MMProductionCostIngredientCostReferenceNo;
                    //    itemShipment.MMBatchProductNo = item.MMProductionCostIngredientCostBatchProductNo;
                    //    itemShipment.MMOperationName = item.MMProductionCostIngredientCostOperationName;
                    //    itemShipment.ICMeasureUnitName = item.MMProductionCostIngredientCostMeasureUnitName;
                    //    itemShipment.ICStockName = item.MMProductionCostIngredientCostStockName;
                    //    itemShipment.ICProductNo = item.MMProductionCostIngredientCostProductNo;
                    //    ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByNo(item.MMProductionCostIngredientCostReferenceNo);
                    //    if (objShipmentInfo != null)
                    //    {
                    //        itemShipment.FK_ICShipmentID = objShipmentInfo.ICShipmentID;
                    //        itemShipment.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                    //        itemShipment.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                    //    }
                    //    shipmentItemList.Add(itemShipment);
                    //}

                    //foreach (ICShipmentItemsInfo shipmentItem in shipmentItemList)
                    //{
                    //    chiPhiXuatKhoGo += shipmentItem.ICShipmentItemTotalAmount;
                    //}    
                    chiPhiXuatKhoGo = shipmentItemList.Sum(item => item.MMProductionCostIngredientCostTotalCost);

                    //receiptItemList = objReceiptItemsController.GetReceiptItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    receiptItemList1 = receiptItemList.Where(item => item.FK_MMBatchProductID == batchProductID).ToList();
                    //TongM3TinhLSX = receiptItemList.Sum(e => e.ICReceiptItemProductHeight * e.ICReceiptItemProductWidth * e.ICReceiptItemProductLength * e.ICReceiptItemProductQty / 1000000000);
                    //TongM3TinhLSX = receiptItemList.Sum(e => e.ICReceiptItemWoodQty);
                    TongM3TinhLSX = receiptItemList1.Where(item => item.ICReceiptTypeCombo == "SemiProductReceipt" ||
                                                                    item.ICReceiptTypeCombo == "ProductionReceipt")
                                                    .Sum(e => e.ICReceiptItemWoodQty);

                    decimal klXUat = shipmentItemList.Sum(e => e.MMProductionCostIngredientCostProductQty);
                    decimal tongGTXuat = shipmentItemList.Sum(e => e.MMProductionCostIngredientCostTotalCost);
                    //decimal klNhap = receiptItemList.Sum(e => e.ICReceiptItemWoodQty);
                    decimal klNhap = TongM3TinhLSX;
                    List<MMBatchProductProductionNormItemsInfo> ppniList = objBPPNIsController.GetProductionNormItemsByGroupTypeAndBatchProductID(ProductType.Product.ToString(), batchProductID);
                    decimal klLSX = ppniList.Sum(e => e.MMBatchProductProductionNormItemBlocks);
                    List<MMWoodPlanItemDetailsInfo> wpiList = objWoodPlanItemDetailsController.GetWoodPlanItemByBatchProductID(batchProductID);
                    //decimal klHDSX = wpiList.Sum(e => e.MMWoodPlanItemDetailProductDryBlocks);
                    decimal klHDSX = wpiList.Sum(e => e.MMWoodPlanItemDetailBlocks);
                    //decimal dodang = klXUat - (klXUat / klHDSX) * klNhap;
                    //decimal klNhapLai = receiptItemList.Where(p => p.ICReceiptNo.IndexOf("NKPK") >= 0).Sum(e => e.ICReceiptItemProductQty);
                    //decimal gtNhapLai = receiptItemList.Where(p => p.ICReceiptNo.IndexOf("NKPK") >= 0).Sum(e => e.ICReceiptItemTotalCost);

                    List<ICReceiptItemsInfo> totalReceiptItemList = objReceiptItemsController.GetAllReceiptItemByBatchProductIDAndOperationIDAndDate(batchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate.AddDays(-1));
                    decimal klTongNhapLSX = totalReceiptItemList.Sum(e => e.ICReceiptItemWoodQty);
                    //decimal dodang = klXUat - klNhapLai - (klXUat / klHDSX) * klTongNhapLSX;
                    //decimal dodang = (klXUat - klNhapLai) - ((klXUat - klNhapLai) / (klHDSX - klTongNhapLSX)) * klNhap;
                    //decimal dodang = (klXUat - klNhapLai) - ((klXUat - klNhapLai) / (klLSX - klTongNhapLSX)) * klNhap;
                    decimal dodang = (klXUat) - ((klXUat) / (klLSX - klTongNhapLSX)) * klNhap;

                    List<MMProductionCostIngredientCostDDsInfo> listIncomplete = entity.ProductionCostIngredientCostListDDPhoi.Where(p => p.FK_MMBatchProductID == batchProductID).ToList();
                    decimal gtDoDang = listIncomplete.Sum(s => s.MMProductionCostIngredientCostDDTotalCost);
                    //chiPhiXuatKhoGo = chiPhiXuatKhoGo - gtNhapLai - gtDoDang;
                    chiPhiXuatKhoGo = chiPhiXuatKhoGo - gtDoDang;
                    //if (dodang > 0)
                    //{
                    //    chiPhiXuatKhoGo = chiPhiXuatKhoGo - gtNhapLai - ((tongGTXuat - gtNhapLai) / klXUat) * dodang;
                    //}
                    //else
                    //{
                    //    chiPhiXuatKhoGo = 0;
                    //}

                    foreach (ICReceiptItemsInfo receiptItem in receiptItemList1)
                    {
                        if (receiptItem.ICReceiptTypeCombo == "SemiProductReceipt" ||
                            receiptItem.ICReceiptTypeCombo == "ProductionReceipt")
                        {
                            //decimal receiptItemWoodQty = receiptItem.ICReceiptItemProductHeight *
                            //                        receiptItem.ICReceiptItemProductWidth * 
                            //                        receiptItem.ICReceiptItemProductLength *
                            //                        receiptItem.ICReceiptItemProductQty / 1000000000;

                            decimal receiptItemWoodQty = receiptItem.ICReceiptItemWoodQty;

                            if (receiptItemWoodQty > 0)
                            {
                                // % m3 tinh thực nhập
                                receiptItem.ICReceiptItemM3PercentCPChung = receiptItemWoodQty / TongM3Tinh;
                                receiptItem.ICReceiptItemM3PercentCPGo = receiptItemWoodQty / TongM3TinhLSX;
                                // CP NL Gỗ
                                receiptItem.ICReceiptItemCPNguyenLieuGo = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiXuatKhoGo;
                                receiptItem.ICReceiptItemWoodFee = receiptItem.ICReceiptItemCPNguyenLieuGo;
                                // CP nhân công TT
                                receiptItem.ICReceiptItemCPNCTT = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiNhanCongTT;
                                receiptItem.ICReceiptItemDirectSalaryFee = receiptItem.ICReceiptItemCPNCTT;
                                // CP Chung
                                receiptItem.ICReceiptItemCPChung = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiChungTT;
                                //receiptItem.ICReceiptItemCPChung += receiptItem.ICReceiptItemM3PercentCPGo * chiPhiKhac;
                                receiptItem.ICReceiptItemGeneralFee = receiptItem.ICReceiptItemCPChung;

                                // CP Chung nhà máy + chi phí khác
                                receiptItem.ICReceiptItemCPChungNhaMay = receiptItemWoodQty * (chiPhiChungNhaMay / tongM3TinhToanNhaMay);
                                receiptItem.ICReceiptItemOtherFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiKhac;
                                receiptItem.ICReceiptItemOtherFee += receiptItem.ICReceiptItemCPChungNhaMay;

                                objProductionCostsInfo.MMProductionCost6279FeeP += receiptItemWoodQty * (chiPhi6279 / tongM3TinhToanNhaMay);

                                // CP HW, PLDG, Son
                                receiptItem.ICReceiptItemCPNguyenLieuKhac = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiXuatKhoKhac;
                                receiptItem.ICReceiptItemHardwareFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiHW;
                                receiptItem.ICReceiptItemPaintFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiSon;
                                receiptItem.ICReceiptItemMaintainFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiBaoBi;
                                // CP Khau Hao
                                receiptItem.ICReceiptItemDepreciationFee = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiKhauHao;
                                // CP Tien dien
                                receiptItem.ICReceiptItemElecFee = receiptItemWoodQty * (chiPhiTienDien / tongM3TinhToanNhaMay);
                                // Tổng giá BTP
                                receiptItem.ICReceiptItemCostBTP = receiptItem.ICReceiptItemCPNguyenLieuKhac
                                    + receiptItem.ICReceiptItemCPNguyenLieuGo
                                    + receiptItem.ICReceiptItemCPNCTT
                                    + receiptItem.ICReceiptItemCPChung
                                    + receiptItem.ICReceiptItemOtherFee;
                                //+ receiptItem.ICReceiptItemDepreciationFee
                                //+ receiptItem.ICReceiptItemElecFee;
                                receiptItem.ICReceiptItemTotalCost = receiptItem.ICReceiptItemCostBTP;
                                // Giá từng BTP
                                if (receiptItem.ICReceiptItemProductQty > 0)
                                {
                                    receiptItem.ICReceiptItemProductUnitCost = receiptItem.ICReceiptItemTotalCost / receiptItem.ICReceiptItemProductQty;
                                    //receiptItem.ICReceiptItemWoodFee /= receiptItem.ICReceiptItemProductQty;
                                    //receiptItem.ICReceiptItemDirectSalaryFee /= receiptItem.ICReceiptItemProductQty;
                                    //receiptItem.ICReceiptItemGeneralFee /= receiptItem.ICReceiptItemProductQty;
                                    //receiptItem.ICReceiptItemOtherFee /= receiptItem.ICReceiptItemProductQty;
                                    //receiptItem.ICReceiptItemHardwareFee /= receiptItem.ICReceiptItemProductQty;
                                    //receiptItem.ICReceiptItemPaintFee /= receiptItem.ICReceiptItemProductQty;
                                    //receiptItem.ICReceiptItemMaintainFee /= receiptItem.ICReceiptItemProductQty;
                                    //receiptItem.ICReceiptItemDepreciationFee /= receiptItem.ICReceiptItemProductQty;
                                    //receiptItem.ICReceiptItemElecFee /= receiptItem.ICReceiptItemProductQty;
                                }
                                if (receiptItem.ICReceiptItemProductUnitCost > 0)
                                {
                                    BOSApp.RoundByCurrency(receiptItem, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                    objReceiptItemsController.UpdateObject(receiptItem);
                                    // Receipt
                                    dbUtil.ExecuteNonQuery("UpdateInventoryCost_B1", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                                    // Shipment
                                    dbUtil.ExecuteNonQuery("UpdateInventoryCost_B2", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                                }

                                //productPrice.MMProductPriceIngredientShipment += receiptItem.ICReceiptItemCPNguyenLieuGo;
                            }
                        }
                    }
                    //batchProductIDList.Add(productPrice.FK_MMBatchProductID);
                }
            }
            GetProductionCostItemByDate(objProductionCostsInfo.MMProductionCostFromDate,
                                                  objProductionCostsInfo.MMProductionCostToDate, true);

            BOSProgressBar.Close();
        }

        public void ExecCostOprationSC(bool isChange)
        {
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            string CPNCTTAccountNo = "6225";
            string CPChungTTAccountNo = "6274";
            decimal chiPhiNhanCongTT = GetDocumentEntryAmountByAccountNo(CPNCTTAccountNo)
                - GetDocumentEntryCreditAmountByAccountNo(CPNCTTAccountNo);
            decimal chiPhiChungTT = GetDocumentEntryAmountByAccountNo(CPChungTTAccountNo)
                - GetDocumentEntryCreditAmountByAccountNo(CPChungTTAccountNo);
            decimal chiPhiChungNhaMay = GetDocumentEntryAmountByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay6279)
                    - GetDocumentEntryCreditAmountByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay6279);
            if (chiPhiNhanCongTT == 0 || chiPhiChungTT == 0 || chiPhiChungNhaMay == 0)
            {
                if (MessageBox.Show("Có chi phí sản xuất không xác định được, bạn có muốn tiếp tục?", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    BOSProgressBar.Close();
                    return;
                }
            }
            decimal chiPhi6279 = chiPhiChungNhaMay;
            objProductionCostsInfo.MMProductionCost6279FeeSC = 0;

            decimal chiPhiKhauHao = GetDocumentEntryAmountByAccountNo("62742");
            decimal chiPhiTienDien = GetDocumentEntryAmountByAccountNo("62794");
            decimal chiPhiHW = 0;
            decimal chiPhiSon = 0;
            decimal chiPhiBaoBi = 0;

            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDSoCheNo);

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> receiptItemList;
            List<ICReceiptItemsInfo> receiptItemList1;
            List<MMProductionCostIngredientCostSCsInfo> shipmentItemOtherList;
            List<MMProductionCostIngredientCostSCsInfo> shipmentItemOtherList1 = new List<MMProductionCostIngredientCostSCsInfo>();
            List<MMProductionCostIngredientCostSCsInfo> receiptItemOtherList;
            decimal chiPhiXuatKhoGo = 0;
            decimal chiPhiXuatKhoKhac = 0;
            decimal chiPhiKhac = 0;
            decimal TongM3TinhLSX = 0;
            decimal TongM3Tinh = 0;
            decimal tongM3TinhToanNhaMay = 0;
            ICShipmentItemsInfo objShipmentItemsInfo;
            BOSDbUtil dbUtil = new BOSDbUtil();
            receiptItemList = objReceiptItemsController.GetReceiptItemByOperationIDAndDate(objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            List<ICReceiptItemsInfo> receiptItems = objReceiptItemsController.GetReceiptItemByAllOperationIDAndDate(objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            TongM3Tinh = receiptItemList.Sum(e => e.ICReceiptItemWoodQty);
            tongM3TinhToanNhaMay = receiptItems.Sum(e => e.ICReceiptItemWoodQty);
            //TongM3Tinh = receiptItemList.Sum(e => e.ICReceiptItemProductHeight * e.ICReceiptItemProductWidth * e.ICReceiptItemProductLength * e.ICReceiptItemProductQty / 1000000000);
            //tongM3TinhToanNhaMay = receiptItems.Sum(e => e.ICReceiptItemProductHeight * e.ICReceiptItemProductWidth * e.ICReceiptItemProductLength * e.ICReceiptItemProductQty / 1000000000);
            //List<int> batchProductIDList = new List<int>();
            ICProductsForViewInfo objProductsInfo;
            dbUtil.ExecuteNonQuery("ResetInventoryCostByOperationID", objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            int percent = 0;

            List<MMProductionCostIngredientCostSCsInfo> xuatSC = new List<MMProductionCostIngredientCostSCsInfo>();
            ICShipmentItemsInfo itemShipment = null;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo = null;
            ICShipmentsController objShipmentController = new ICShipmentsController();

            List<int> batchProductIDList = entity.ProductionCostItemList.Select(item => item.FK_MMBatchProductID).Distinct().ToList();
            Dictionary<int, MMProductionCostIngredientCostSCsInfo> collection = new Dictionary<int, MMProductionCostIngredientCostSCsInfo>();
            List<ICShipmentItemsInfo> shipmentProductList;
            //foreach (MMProductionCostItemsInfo productPrice in entity.ProductionCostItemList)
            foreach (int batchProductID in batchProductIDList)
            {
                percent++;
                decimal pct = (percent * 100) / batchProductIDList.Count;
                BOSProgressBar.Start("Đang tính giá thành sơ chế  " + Math.Round(pct) + " % ");

                //if (!batchProductIDList.Contains(productPrice.FK_MMBatchProductID))
                {
                    //if (batchProductID != 806)
                    //{
                    //    continue;
                    //    //string a = "";
                    //}
                    chiPhiXuatKhoKhac = 0;
                    chiPhiHW = 0;
                    chiPhiSon = 0;
                    chiPhiBaoBi = 0;
                    //shipmentItemOtherList = objShipmentItemsController.GetShipmentItemOtherBySomeCriteria(productPrice.FK_ICProductIDForBatch, productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);

                    shipmentItemOtherList = entity.ProductionCostIngredientCostListSC.Where(item => item.FK_MMBatchProductID == batchProductID
                            && item.MMProductionCostIngredientCostSCReferenceTypeCombo == ShipmentType.MaterialShipment.ToString()).ToList();

                    receiptItemOtherList = entity.ProductionCostIngredientCostListSC.Where(item => item.FK_MMBatchProductID == batchProductID
                            && (item.MMProductionCostIngredientCostSCReferenceTypeCombo == ReceiptType.MaterialReturnReceipt.ToString()
                            || item.MMProductionCostIngredientCostSCReferenceTypeCombo == ReceiptType.MaterialRedundantReceipt.ToString())).ToList();

                    collection.Clear();
                    shipmentItemOtherList1.Clear();
                    if (receiptItemOtherList != null && receiptItemOtherList.Count > 0)
                    {
                        foreach (MMProductionCostIngredientCostSCsInfo receiptItem in receiptItemOtherList)
                        {
                            int key = receiptItem.FK_ICProductID;
                            if (!collection.Keys.Contains(key))
                                collection.Add(key, new MMProductionCostIngredientCostSCsInfo());
                            collection[key].MMProductionCostIngredientCostSCProductQty += receiptItem.MMProductionCostIngredientCostSCProductQty;
                            collection[key].MMProductionCostIngredientCostSCTotalCost += receiptItem.MMProductionCostIngredientCostSCTotalCost;
                        }

                    }

                    foreach (int key in collection.Keys)
                    {
                        if (collection[key].MMProductionCostIngredientCostSCProductQty != 0)
                            collection[key].MMProductionCostIngredientCostSCProductUnitCost = collection[key].MMProductionCostIngredientCostSCTotalCost / collection[key].MMProductionCostIngredientCostSCProductQty;
                    }

                    foreach (MMProductionCostIngredientCostSCsInfo shipmentItem in shipmentItemOtherList)
                    {
                        int key = shipmentItem.FK_ICProductID;
                        decimal remainQty = 0;
                        decimal value = 0;
                        if (collection.Keys.Contains(key) &&
                            (collection[key].MMProductionCostIngredientCostSCProductQty > 0 ||
                            collection[key].MMProductionCostIngredientCostSCTotalCost > 0))
                        {
                            remainQty = Math.Min(shipmentItem.MMProductionCostIngredientCostSCProductQty, collection[key].MMProductionCostIngredientCostSCProductQty);
                            value = Math.Min(shipmentItem.MMProductionCostIngredientCostSCTotalCost, collection[key].MMProductionCostIngredientCostSCTotalCost);
                            collection[key].MMProductionCostIngredientCostSCProductQty -= remainQty;
                            collection[key].MMProductionCostIngredientCostSCTotalCost -= value;
                        }
                        if (shipmentItem.MMProductionCostIngredientCostSCProductQty != remainQty ||
                            shipmentItem.MMProductionCostIngredientCostSCTotalCost != value)
                        {
                            MMProductionCostIngredientCostSCsInfo shipmentItem1 = new MMProductionCostIngredientCostSCsInfo();
                            BOSUtil.CopyObject(shipmentItem, shipmentItem1);
                            shipmentItem1.MMProductionCostIngredientCostSCProductQty = shipmentItem.MMProductionCostIngredientCostSCProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostSCProductWoodQty = shipmentItem.MMProductionCostIngredientCostSCProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostSCTotalCost = shipmentItem1.MMProductionCostIngredientCostSCTotalCost - value;
                            if (shipmentItem1.MMProductionCostIngredientCostSCProductQty != 0)
                                shipmentItem1.MMProductionCostIngredientCostSCProductUnitCost = shipmentItem1.MMProductionCostIngredientCostSCTotalCost / shipmentItem1.MMProductionCostIngredientCostSCProductQty;
                            //shipmentItem1.MMProductionCostIngredientCostSCTotalCost = shipmentItem1.MMProductionCostIngredientCostSCProductQty * shipmentItem1.MMProductionCostIngredientCostSCProductUnitCost;
                            shipmentItemOtherList1.Add(shipmentItem1);
                        }
                    }


                    foreach (MMProductionCostIngredientCostSCsInfo shipmentItem in shipmentItemOtherList1)
                    {
                        chiPhiXuatKhoKhac += shipmentItem.MMProductionCostIngredientCostSCTotalCost;
                        objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(i => i.ICProductID == shipmentItem.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            if (objProductsInfo.ICProductType == ProductType.Hardware.ToString())
                            {
                                chiPhiHW += shipmentItem.MMProductionCostIngredientCostSCTotalCost;
                            }
                            else if (objProductsInfo.ICProductType == ProductType.IngredientPackaging.ToString())
                            {
                                chiPhiBaoBi += shipmentItem.MMProductionCostIngredientCostSCTotalCost;
                            }
                            else if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString())
                            {
                                chiPhiSon += shipmentItem.MMProductionCostIngredientCostSCTotalCost;
                            }
                            else
                            {
                                chiPhiHW += shipmentItem.MMProductionCostIngredientCostSCTotalCost;
                            }
                        }
                    }
                    chiPhiKhac = 0;
                    foreach (MMProductionCostOtherFeesInfo item in entity.ProductionCostOtherFeesList)
                    {
                        if (item.FK_MMBatchProductID == batchProductID
                            && item.FK_MMOperationID == objOperationsInfo.MMOperationID)
                        {
                            chiPhiKhac += item.MMProductionCostOtherFeeTotalAmount;
                        }
                    }
                    chiPhiXuatKhoGo = 0;

                    //shipmentItemList = objShipmentItemsController.GetShipmentItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    shipmentItemList.Clear();
                    int index = 1;
                    xuatSC = entity.ProductionCostIngredientCostListSC.Where(p => p.FK_MMBatchProductID == batchProductID
                        && p.MMProductionCostIngredientCostSCReferenceTypeCombo == ShipmentType.SemiProductShipment.ToString()).ToList();
                    foreach (MMProductionCostIngredientCostSCsInfo item in xuatSC)
                    {
                        itemShipment = new ICShipmentItemsInfo();
                        BOSUtil.CopyObject(item, itemShipment);
                        //objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.MMProductionCostIngredientCostSCProductSerialNo);
                        //if (objProductSeriesInfo != null)
                        //{
                        //    itemShipment.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                        //}
                        //itemShipment.FK_ICProductID = item.FK_ICProductID;
                        //itemShipment.FK_MMBatchProductID = item.FK_MMBatchProductID;
                        itemShipment.ICShipmentItemProductQty = item.MMProductionCostIngredientCostSCProductQty;
                        itemShipment.ICShipmentItemProductUnitPrice = item.MMProductionCostIngredientCostSCProductUnitCost;
                        itemShipment.ICShipmentItemWoodQty = item.MMProductionCostIngredientCostSCProductWoodQty;
                        itemShipment.ICShipmentItemTotalAmount = item.MMProductionCostIngredientCostSCTotalCost;
                        itemShipment.ICShipmentNo = item.MMProductionCostIngredientCostSCReferenceNo;
                        itemShipment.MMBatchProductNo = item.MMProductionCostIngredientCostSCBatchProductNo;
                        itemShipment.MMOperationName = item.MMProductionCostIngredientCostSCOperationName;
                        itemShipment.ICMeasureUnitName = item.MMProductionCostIngredientCostSCMeasureUnitName;
                        itemShipment.ICStockName = item.MMProductionCostIngredientCostSCStockName;
                        itemShipment.ICProductNo = item.MMProductionCostIngredientCostSCProductNo;

                        //ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByNo(item.MMProductionCostIngredientCostSCReferenceNo);
                        //if (objShipmentInfo != null)
                        //{
                        //    itemShipment.FK_ICShipmentID = objShipmentInfo.ICShipmentID;
                        //    itemShipment.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                        //    itemShipment.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                        //}
                        itemShipment.Id = index;
                        index++;
                        shipmentItemList.Add(itemShipment);
                    }

                    receiptItemList1 = receiptItemList.Where(item => item.FK_MMBatchProductID == batchProductID).ToList();

                    //List<int> productIDList = new List<int>();
                    //foreach (ICShipmentItemsInfo shipmentItem in shipmentItemList)
                    //{
                    //    //chiPhiXuatKhoGo += shipmentItem.ICShipmentItemTotalAmount;
                    //    if (!productIDList.Contains(shipmentItem.FK_ICProductID))
                    //    {
                    //        decimal tongSLXuat = shipmentItemList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.ICShipmentItemProductQty);
                    //        decimal tongSLNhap = receiptItemList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.ICReceiptItemProductQty);
                    //        if (tongSLNhap > 0)
                    //        {
                    //            chiPhiXuatKhoGo += (tongSLNhap * shipmentItem.ICShipmentItemProductUnitPrice);
                    //        }
                    //        productIDList.Add(shipmentItem.FK_ICProductID);
                    //    }

                    //}
                    //TongM3TinhLSX = receiptItemList.Sum(e => e.ICReceiptItemProductHeight * e.ICReceiptItemProductWidth * e.ICReceiptItemProductLength * e.ICReceiptItemProductQty / 1000000000);
                    TongM3TinhLSX = receiptItemList1.Sum(e => e.ICReceiptItemWoodQty);

                    foreach (ICReceiptItemsInfo receiptItem in receiptItemList1)
                    {
                        //decimal receiptItemWoodQty = receiptItem.ICReceiptItemProductHeight *
                        //                        receiptItem.ICReceiptItemProductWidth * 
                        //                        receiptItem.ICReceiptItemProductLength *
                        //                        receiptItem.ICReceiptItemProductQty / 1000000000;
                        if (receiptItem.FK_ICProductID == 9765)
                        {
                            string a = "";
                        }
                        decimal receiptItemWoodQty = receiptItem.ICReceiptItemWoodQty;
                        // % m3 tinh thực nhập
                        receiptItem.ICReceiptItemM3PercentCPChung = receiptItemWoodQty / TongM3Tinh;
                        receiptItem.ICReceiptItemM3PercentCPGo = receiptItemWoodQty / TongM3TinhLSX;
                        // CP NL Gỗ
                        //receiptItem.ICReceiptItemCPNguyenLieuGo = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiXuatKhoGo;

                        shipmentProductList = shipmentItemList.Where(x => x.FK_ICProductID == receiptItem.FK_ICProductID
                                                                        && x.ReceiptQty < x.ICShipmentItemProductQty)
                                                                        .OrderBy(x => x.FK_ICProductSerieID).ToList();
                        if (shipmentProductList.Count > 0)
                        {
                            //decimal tongSLXuat = shipmentProductList.Sum(x => x.ICShipmentItemProductQty - x.ReceiptQty);
                            //if (receiptItem.ICReceiptItemProductQty >= tongSLXuat)
                            //{
                            //    receiptItem.ICReceiptItemCPNguyenLieuGo += shipmentProductList.Sum(x => x.ICShipmentItemProductUnitPrice * (x.ICShipmentItemProductQty - x.ReceiptQty));
                            //    //if (receiptItem.ICReceiptItemProductQty - tongSLXuat > 0)
                            //    //{
                            //    //    objShipmentItemsInfo = shipmentProductList[0];
                            //    //    receiptItem.ICReceiptItemCPNguyenLieuGo += (receiptItem.ICReceiptItemProductQty - tongSLXuat) * objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
                            //    //}
                            //}
                            //else
                            //{

                            decimal remainQty = receiptItem.ICReceiptItemProductQty;
                            foreach (ICShipmentItemsInfo subItemShipment in shipmentProductList)
                            {
                                if (remainQty > 0)
                                {
                                    //if (subItemShipment.ICShipmentItemProductQty - remainQty >= 0)
                                    //{
                                    //    receiptItem.ICReceiptItemCPNguyenLieuGo += remainQty * subItemShipment.ICShipmentItemProductUnitPrice;
                                    //}
                                    //else
                                    //{
                                    //    decimal qty = Math.Min(remainQty, subItemShipment.ICShipmentItemProductQty);
                                    //    receiptItem.ICReceiptItemCPNguyenLieuGo += qty * subItemShipment.ICShipmentItemProductUnitPrice;
                                    //}
                                    //remainQty = remainQty - subItemShipment.ICShipmentItemProductQty;
                                    decimal qty = Math.Min(remainQty, subItemShipment.ICShipmentItemProductQty - subItemShipment.ReceiptQty);
                                    receiptItem.ICReceiptItemCPNguyenLieuGo += qty * subItemShipment.ICShipmentItemProductUnitPrice;
                                    remainQty = remainQty - qty;
                                    ICShipmentItemsInfo foundItem = shipmentItemList.FirstOrDefault(item => item.Id == subItemShipment.Id);
                                    if (foundItem != null)
                                        foundItem.ReceiptQty += qty;
                                }
                                else
                                {
                                    break;
                                }

                            }
                            //}
                        }
                        else
                        {
                            receiptItem.ICReceiptItemCPNguyenLieuGo = 0;
                        }
                        // CP nhân công TT
                        receiptItem.ICReceiptItemCPNCTT = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiNhanCongTT;
                        receiptItem.ICReceiptItemDirectSalaryFee = receiptItem.ICReceiptItemCPNCTT;
                        // CP Chung
                        receiptItem.ICReceiptItemCPChung = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiChungTT;
                        //receiptItem.ICReceiptItemCPChung += receiptItem.ICReceiptItemM3PercentCPGo * chiPhiKhac;
                        receiptItem.ICReceiptItemGeneralFee = receiptItem.ICReceiptItemCPChung;
                        // CP Chung nhà máy
                        //receiptItem.ICReceiptItemCPChungNhaMay = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiChungNhaMay/6;
                        receiptItem.ICReceiptItemCPChungNhaMay = receiptItemWoodQty * (chiPhiChungNhaMay / tongM3TinhToanNhaMay);
                        objProductionCostsInfo.MMProductionCost6279FeeSC += receiptItemWoodQty * (chiPhi6279 / tongM3TinhToanNhaMay);
                        receiptItem.ICReceiptItemOtherFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiKhac;
                        receiptItem.ICReceiptItemOtherFee += receiptItem.ICReceiptItemCPChungNhaMay;
                        // CP HW, PLDG, Son
                        receiptItem.ICReceiptItemCPNguyenLieuKhac = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiXuatKhoKhac;

                        receiptItem.ICReceiptItemWoodFee = receiptItem.ICReceiptItemCPNguyenLieuGo;
                        receiptItem.ICReceiptItemHardwareFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiHW;
                        receiptItem.ICReceiptItemPaintFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiSon;
                        receiptItem.ICReceiptItemMaintainFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiBaoBi;
                        //receiptItem.ICReceiptItemOtherFee -= receiptItem.ICReceiptItemDepreciationFee;
                        //receiptItem.ICReceiptItemOtherFee -= receiptItem.ICReceiptItemElecFee;
                        // CP Khau Hao
                        receiptItem.ICReceiptItemDepreciationFee = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiKhauHao;
                        // CP Tien dien
                        receiptItem.ICReceiptItemElecFee = receiptItemWoodQty * (chiPhiTienDien / tongM3TinhToanNhaMay);

                        // Tổng giá BTP
                        receiptItem.ICReceiptItemCostBTP = receiptItem.ICReceiptItemCPNguyenLieuKhac
                            + receiptItem.ICReceiptItemCPNguyenLieuGo
                            + receiptItem.ICReceiptItemCPNCTT
                            + receiptItem.ICReceiptItemCPChung
                            + receiptItem.ICReceiptItemOtherFee;
                        //+ receiptItem.ICReceiptItemDepreciationFee
                        //+ receiptItem.ICReceiptItemElecFee;
                        receiptItem.ICReceiptItemTotalCost = receiptItem.ICReceiptItemCostBTP;
                        // Giá từng BTP
                        receiptItem.ICReceiptItemProductUnitCost = receiptItem.ICReceiptItemTotalCost / receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemWoodFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemDirectSalaryFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemGeneralFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemOtherFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemHardwareFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemPaintFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemMaintainFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemDepreciationFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemElecFee /= receiptItem.ICReceiptItemProductQty;

                        if (receiptItem.ICReceiptItemProductUnitCost > 0)
                        {
                            BOSApp.RoundByCurrency(receiptItem, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                            objReceiptItemsController.UpdateObject(receiptItem);
                            // Cập nhật lại giá xuất kho BTP
                            //objShipmentItemsInfo = objShipmentItemsController.GetShipmentItemByReceiptItemIDAndBatchProductID(receiptItem.Id, productPrice.FK_MMBatchProductID);
                            //if (objShipmentItemsInfo != null)
                            //{
                            //    objShipmentItemsInfo.ICShipmentItemTotalAmount = receiptItem.ICReceiptItemTotalCost;
                            //    objShipmentItemsInfo.ICShipmentItemTotalCost = receiptItem.ICReceiptItemTotalCost;
                            //    objShipmentItemsInfo.ICShipmentItemProductUnitPrice = receiptItem.ICReceiptItemProductUnitCost;
                            //    objShipmentItemsController.UpdateObject(objShipmentItemsInfo);
                            //}
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCostByOperationID", receiptItem.FK_ICProductID, receiptItem.ICReceiptItemProductSerialNo, receiptItem.ICReceiptItemProductUnitCost, objOperationsInfo.MMOperationID);
                            dbUtil.ExecuteNonQuery("UpdateInventoryCost_B1", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                            // Shipment
                            dbUtil.ExecuteNonQuery("UpdateInventoryCost_B2", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                            // Shipment Accounting
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B3", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B7", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B8", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //// Receipt Accounting
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B4", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B5", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B6", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                        }
                    }
                    //batchProductIDList.Add(productPrice.FK_MMBatchProductID);
                }
            }
            GetProductionCostItemByDate(objProductionCostsInfo.MMProductionCostFromDate,
                                                  objProductionCostsInfo.MMProductionCostToDate, true);

            BOSProgressBar.Close();

        }

        public void ExecCostOprationTC(bool isChange)
        {
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            string CPNCTTAccountNo = "6226";
            string CPChungTTAccountNo = "6275";
            decimal chiPhiNhanCongTT = GetDocumentEntryAmountByAccountNo(CPNCTTAccountNo)
                - GetDocumentEntryCreditAmountByAccountNo(CPNCTTAccountNo);
            decimal chiPhiChungTT = GetDocumentEntryAmountByAccountNo(CPChungTTAccountNo)
                - GetDocumentEntryCreditAmountByAccountNo(CPChungTTAccountNo);
            decimal chiPhiChungNhaMay = GetDocumentEntryAmountByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay6279)
                    - GetDocumentEntryCreditAmountByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay6279);
            if (chiPhiNhanCongTT == 0 || chiPhiChungTT == 0 || chiPhiChungNhaMay == 0)
            {
                if (MessageBox.Show("Có chi phí sản xuất không xác định được, bạn có muốn tiếp tục?", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    BOSProgressBar.Close();
                    return;
                }
            }
            decimal chiPhi6279 = chiPhiChungNhaMay;

            objProductionCostsInfo.MMProductionCost6279FeeTC = 0;
            decimal chiPhiKhauHao = GetDocumentEntryAmountByAccountNo("62752");
            decimal chiPhiTienDien = GetDocumentEntryAmountByAccountNo("62794");
            decimal chiPhiHW = 0;
            decimal chiPhiSon = 0;
            decimal chiPhiBaoBi = 0;

            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDTinhCheNo);

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> receiptItemList;
            List<ICReceiptItemsInfo> receiptItemList1;
            List<MMProductionCostIngredientCostTCsInfo> shipmentItemOtherList;
            List<MMProductionCostIngredientCostTCsInfo> shipmentItemOtherList1 = new List<MMProductionCostIngredientCostTCsInfo>();
            List<MMProductionCostIngredientCostTCsInfo> receiptItemOtherList;
            decimal chiPhiXuatKhoGo = 0;
            decimal chiPhiXuatKhoKhac = 0;
            decimal chiPhiKhac = 0;
            decimal TongM3TinhLSX = 0;
            decimal TongM3Tinh = 0;
            decimal tongM3TinhToanNhaMay = 0;
            ICShipmentItemsInfo objShipmentItemsInfo;
            BOSDbUtil dbUtil = new BOSDbUtil();
            receiptItemList = objReceiptItemsController.GetReceiptItemByOperationIDAndDate(objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            List<ICReceiptItemsInfo> receiptItems = objReceiptItemsController.GetReceiptItemByAllOperationIDAndDate(objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            TongM3Tinh = receiptItemList.Sum(e => e.ICReceiptItemWoodQty);
            tongM3TinhToanNhaMay = receiptItems.Sum(e => e.ICReceiptItemWoodQty);
            //TongM3Tinh = receiptItemList.Sum(e => e.ICReceiptItemProductHeight * e.ICReceiptItemProductWidth * e.ICReceiptItemProductLength * e.ICReceiptItemProductQty / 1000000000);
            //tongM3TinhToanNhaMay = receiptItems.Sum(e => e.ICReceiptItemProductHeight * e.ICReceiptItemProductWidth * e.ICReceiptItemProductLength * e.ICReceiptItemProductQty / 1000000000);
            //List<int> batchProductIDList = new List<int>();
            dbUtil.ExecuteNonQuery("ResetInventoryCostByOperationID", objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            int percent = 0;

            List<MMProductionCostIngredientCostTCsInfo> xuatTC = new List<MMProductionCostIngredientCostTCsInfo>();
            ICShipmentItemsInfo itemShipment = null;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo = null;
            ICShipmentsController objShipmentController = new ICShipmentsController();

            List<int> batchProductIDList = entity.ProductionCostItemList.Select(item => item.FK_MMBatchProductID).Distinct().ToList();
            Dictionary<int, MMProductionCostIngredientCostTCsInfo> collection = new Dictionary<int, MMProductionCostIngredientCostTCsInfo>();
            List<ICShipmentItemsInfo> shipmentProductList;
            //foreach (MMProductionCostItemsInfo productPrice in entity.ProductionCostItemList)
            foreach (int batchProductID in batchProductIDList)
            {
                percent++;
                decimal pct = (percent * 100) / batchProductIDList.Count;
                BOSProgressBar.Start("Đang tính giá thành tinh chế  " + Math.Round(pct) + " % ");

                //if (!batchProductIDList.Contains(productPrice.FK_MMBatchProductID))
                {
                    //if (productPrice.FK_MMBatchProductID != 222)
                    //{
                    //    continue;
                    //}
                    chiPhiKhac = 0;
                    foreach (MMProductionCostOtherFeesInfo item in entity.ProductionCostOtherFeesList)
                    {
                        if (item.FK_MMBatchProductID == batchProductID
                            && item.FK_MMOperationID == objOperationsInfo.MMOperationID)
                        {
                            chiPhiKhac += item.MMProductionCostOtherFeeTotalAmount;
                        }
                    }
                    chiPhiXuatKhoKhac = 0;
                    chiPhiHW = 0;
                    chiPhiSon = 0;
                    chiPhiBaoBi = 0;
                    //shipmentItemOtherList = objShipmentItemsController.GetShipmentItemOtherBySomeCriteria(productPrice.FK_ICProductIDForBatch, productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);

                    shipmentItemOtherList = entity.ProductionCostIngredientCostListTC.Where(item => item.FK_MMBatchProductID == batchProductID
                            && item.MMProductionCostIngredientCostTCReferenceTypeCombo == ShipmentType.MaterialShipment.ToString()).OrderBy(item => item.FK_ICProductSerieID).ToList();

                    receiptItemOtherList = entity.ProductionCostIngredientCostListTC.Where(item => item.FK_MMBatchProductID == batchProductID
                            && (item.MMProductionCostIngredientCostTCReferenceTypeCombo == ReceiptType.MaterialReturnReceipt.ToString()
                            || item.MMProductionCostIngredientCostTCReferenceTypeCombo == ReceiptType.MaterialRedundantReceipt.ToString())).ToList();

                    collection.Clear();
                    shipmentItemOtherList1.Clear();
                    if (receiptItemOtherList != null && receiptItemOtherList.Count > 0)
                    {
                        foreach (MMProductionCostIngredientCostTCsInfo receiptItem in receiptItemOtherList)
                        {
                            int key = receiptItem.FK_ICProductID;
                            if (!collection.Keys.Contains(key))
                                collection.Add(key, new MMProductionCostIngredientCostTCsInfo());
                            collection[key].MMProductionCostIngredientCostTCProductQty += receiptItem.MMProductionCostIngredientCostTCProductQty;
                            collection[key].MMProductionCostIngredientCostTCTotalCost += receiptItem.MMProductionCostIngredientCostTCTotalCost;
                        }

                    }

                    foreach (int key in collection.Keys)
                    {
                        if (collection[key].MMProductionCostIngredientCostTCProductQty != 0)
                            collection[key].MMProductionCostIngredientCostTCProductUnitCost = collection[key].MMProductionCostIngredientCostTCTotalCost / collection[key].MMProductionCostIngredientCostTCProductQty;
                    }

                    foreach (MMProductionCostIngredientCostTCsInfo shipmentItem in shipmentItemOtherList)
                    {
                        int key = shipmentItem.FK_ICProductID;
                        decimal remainQty = 0;
                        decimal value = 0;
                        if (collection.Keys.Contains(key) &&
                            (collection[key].MMProductionCostIngredientCostTCProductQty > 0 ||
                            collection[key].MMProductionCostIngredientCostTCTotalCost > 0))
                        {
                            remainQty = Math.Min(shipmentItem.MMProductionCostIngredientCostTCProductQty, collection[key].MMProductionCostIngredientCostTCProductQty);
                            remainQty = Math.Min(shipmentItem.MMProductionCostIngredientCostTCTotalCost, collection[key].MMProductionCostIngredientCostTCTotalCost);
                            collection[key].MMProductionCostIngredientCostTCProductQty -= remainQty;
                            collection[key].MMProductionCostIngredientCostTCTotalCost -= value;
                        }
                        if (shipmentItem.MMProductionCostIngredientCostTCProductQty != remainQty ||
                            shipmentItem.MMProductionCostIngredientCostTCTotalCost != value)
                        {
                            MMProductionCostIngredientCostTCsInfo shipmentItem1 = new MMProductionCostIngredientCostTCsInfo();
                            BOSUtil.CopyObject(shipmentItem, shipmentItem1);
                            shipmentItem1.MMProductionCostIngredientCostTCProductQty = shipmentItem.MMProductionCostIngredientCostTCProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostTCProductWoodQty = shipmentItem.MMProductionCostIngredientCostTCProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostTCTotalCost -= value;
                            if (shipmentItem1.MMProductionCostIngredientCostTCProductQty != 0)
                                shipmentItem1.MMProductionCostIngredientCostTCProductUnitCost = shipmentItem1.MMProductionCostIngredientCostTCTotalCost / shipmentItem1.MMProductionCostIngredientCostTCProductQty;
                            shipmentItemOtherList1.Add(shipmentItem1);
                        }
                    }

                    foreach (MMProductionCostIngredientCostTCsInfo shipmentItem in shipmentItemOtherList1)
                    {
                        chiPhiXuatKhoKhac += shipmentItem.MMProductionCostIngredientCostTCTotalCost;
                        ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(i => i.ICProductID == shipmentItem.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            if (objProductsInfo.ICProductType == ProductType.Hardware.ToString())
                            {
                                chiPhiHW += shipmentItem.MMProductionCostIngredientCostTCTotalCost;
                            }
                            else if (objProductsInfo.ICProductType == ProductType.IngredientPackaging.ToString())
                            {
                                chiPhiBaoBi += shipmentItem.MMProductionCostIngredientCostTCTotalCost;
                            }
                            else if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString())
                            {
                                chiPhiSon += shipmentItem.MMProductionCostIngredientCostTCTotalCost;
                            }
                            else
                            {
                                chiPhiHW += shipmentItem.MMProductionCostIngredientCostTCTotalCost;
                            }
                        }
                    }
                    chiPhiXuatKhoGo = 0;

                    //shipmentItemList = objShipmentItemsController.GetShipmentItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    shipmentItemList.Clear();
                    int index = 0;
                    xuatTC = entity.ProductionCostIngredientCostListTC.Where(p => p.FK_MMBatchProductID == batchProductID
                        && p.MMProductionCostIngredientCostTCReferenceType == ProductionCostIngredientCostReferenceType.XuatKho).ToList();
                    foreach (MMProductionCostIngredientCostTCsInfo item in xuatTC)
                    {
                        itemShipment = new ICShipmentItemsInfo();
                        BOSUtil.CopyObject(item, itemShipment);
                        //objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.MMProductionCostIngredientCostTCProductSerialNo);
                        //if (objProductSeriesInfo != null)
                        //{
                        //    itemShipment.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                        //}
                        itemShipment.FK_ICProductID = item.FK_ICProductID;
                        itemShipment.FK_MMBatchProductID = item.FK_MMBatchProductID;
                        itemShipment.ICShipmentItemProductQty = item.MMProductionCostIngredientCostTCProductQty;
                        itemShipment.ICShipmentItemProductUnitPrice = item.MMProductionCostIngredientCostTCProductUnitCost;
                        itemShipment.ICShipmentItemWoodQty = item.MMProductionCostIngredientCostTCProductWoodQty;
                        itemShipment.ICShipmentItemTotalAmount = item.MMProductionCostIngredientCostTCTotalCost;
                        itemShipment.ICShipmentNo = item.MMProductionCostIngredientCostTCReferenceNo;
                        itemShipment.MMBatchProductNo = item.MMProductionCostIngredientCostTCBatchProductNo;
                        itemShipment.MMOperationName = item.MMProductionCostIngredientCostTCOperationName;
                        itemShipment.ICMeasureUnitName = item.MMProductionCostIngredientCostTCMeasureUnitName;
                        itemShipment.ICStockName = item.MMProductionCostIngredientCostTCStockName;
                        itemShipment.ICProductNo = item.MMProductionCostIngredientCostTCProductNo;

                        //ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByNo(item.MMProductionCostIngredientCostTCReferenceNo);
                        //if (objShipmentInfo != null)
                        //{
                        //    itemShipment.FK_ICShipmentID = objShipmentInfo.ICShipmentID;
                        //    itemShipment.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                        //    itemShipment.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                        //}
                        itemShipment.Id = index;
                        index++;
                        shipmentItemList.Add(itemShipment);
                    }

                    receiptItemList1 = receiptItemList.Where(item => item.FK_MMBatchProductID == batchProductID).ToList();

                    //List<int> productIDList = new List<int>();
                    //foreach (ICShipmentItemsInfo shipmentItem in shipmentItemList)
                    //{
                    //    //chiPhiXuatKhoGo += shipmentItem.ICShipmentItemTotalAmount;
                    //    if (!productIDList.Contains(shipmentItem.FK_ICProductID))
                    //    {
                    //        decimal tongSLXuat = shipmentItemList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.ICShipmentItemProductQty);
                    //        decimal tongSLNhap = receiptItemList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.ICReceiptItemProductQty);
                    //        if (tongSLNhap > 0)
                    //        {
                    //            chiPhiXuatKhoGo += (tongSLNhap * shipmentItem.ICShipmentItemProductUnitPrice);
                    //        }
                    //        productIDList.Add(shipmentItem.FK_ICProductID);
                    //    }

                    //}

                    //TongM3TinhLSX = receiptItemList.Sum(e => e.ICReceiptItemProductHeight * e.ICReceiptItemProductWidth * e.ICReceiptItemProductLength * e.ICReceiptItemProductQty / 1000000000);
                    TongM3TinhLSX = receiptItemList1.Sum(e => e.ICReceiptItemWoodQty);

                    foreach (ICReceiptItemsInfo receiptItem in receiptItemList1)
                    {
                        //decimal receiptItemWoodQty = receiptItem.ICReceiptItemProductHeight *
                        //                        receiptItem.ICReceiptItemProductWidth * 
                        //                        receiptItem.ICReceiptItemProductLength *
                        //                        receiptItem.ICReceiptItemProductQty / 1000000000;
                        decimal receiptItemWoodQty = receiptItem.ICReceiptItemWoodQty;
                        // % m3 tinh thực nhập
                        receiptItem.ICReceiptItemM3PercentCPChung = receiptItemWoodQty / TongM3Tinh;
                        receiptItem.ICReceiptItemM3PercentCPGo = receiptItemWoodQty / TongM3TinhLSX;
                        // CP NL Gỗ
                        //receiptItem.ICReceiptItemCPNguyenLieuGo = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiXuatKhoGo;
                        shipmentProductList = shipmentItemList.Where(x => x.FK_ICProductID == receiptItem.FK_ICProductID
                                                                        && x.ReceiptQty < x.ICShipmentItemProductQty).OrderBy(x => x.FK_ICProductSerieID).ToList();

                        if (shipmentProductList.Count > 0)
                        {
                            //decimal tongSLXuat = shipmentProductList.Sum(x => x.ICShipmentItemProductQty - x.ReceiptQty);
                            //if (receiptItem.ICReceiptItemProductQty >= tongSLXuat)
                            //{
                            //    receiptItem.ICReceiptItemCPNguyenLieuGo += shipmentProductList.Sum(x => x.ICShipmentItemProductUnitPrice * (x.ICShipmentItemProductQty - x.ReceiptQty));
                            //    //if (receiptItem.ICReceiptItemProductQty - tongSLXuat > 0)
                            //    //{
                            //    //    objShipmentItemsInfo = shipmentProductList[0];
                            //    //    receiptItem.ICReceiptItemCPNguyenLieuGo += (receiptItem.ICReceiptItemProductQty - tongSLXuat) * objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
                            //    //}
                            //}
                            //else
                            //{

                            decimal remainQty = receiptItem.ICReceiptItemProductQty;
                            foreach (ICShipmentItemsInfo subItemShipment in shipmentProductList)
                            {
                                if (remainQty > 0)
                                {
                                    //if (subItemShipment.ICShipmentItemProductQty - remainQty >= 0)
                                    //{
                                    //    receiptItem.ICReceiptItemCPNguyenLieuGo += remainQty * subItemShipment.ICShipmentItemProductUnitPrice;
                                    //}
                                    //else
                                    //{
                                    //    decimal qty = Math.Min(remainQty, subItemShipment.ICShipmentItemProductQty);
                                    //    receiptItem.ICReceiptItemCPNguyenLieuGo += qty * subItemShipment.ICShipmentItemProductUnitPrice;
                                    //}
                                    //remainQty = remainQty - subItemShipment.ICShipmentItemProductQty;
                                    decimal qty = Math.Min(remainQty, subItemShipment.ICShipmentItemProductQty - subItemShipment.ReceiptQty);
                                    receiptItem.ICReceiptItemCPNguyenLieuGo += qty * subItemShipment.ICShipmentItemProductUnitPrice;
                                    remainQty = remainQty - qty;
                                    ICShipmentItemsInfo foundItem = shipmentItemList.FirstOrDefault(item => item.Id == subItemShipment.Id);
                                    if (foundItem != null)
                                        foundItem.ReceiptQty += qty;
                                }
                                else
                                {
                                    break;
                                }

                            }
                            //}
                        }
                        else
                        {
                            receiptItem.ICReceiptItemCPNguyenLieuGo = 0;
                        }
                        // CP nhân công TT
                        receiptItem.ICReceiptItemCPNCTT = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiNhanCongTT;
                        receiptItem.ICReceiptItemDirectSalaryFee = receiptItem.ICReceiptItemCPNCTT;
                        // CP Chung
                        receiptItem.ICReceiptItemCPChung = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiChungTT;
                        receiptItem.ICReceiptItemGeneralFee = receiptItem.ICReceiptItemCPChung;
                        // CP Chung nhà máy
                        //receiptItem.ICReceiptItemCPChungNhaMay = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiChungNhaMay/6;
                        receiptItem.ICReceiptItemCPChungNhaMay = receiptItemWoodQty * chiPhiChungNhaMay / tongM3TinhToanNhaMay;
                        objProductionCostsInfo.MMProductionCost6279FeeTC += receiptItemWoodQty * (chiPhi6279 / tongM3TinhToanNhaMay);
                        receiptItem.ICReceiptItemOtherFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiKhac;
                        receiptItem.ICReceiptItemOtherFee += receiptItem.ICReceiptItemCPChungNhaMay;
                        // CP HW, PLDG, Son
                        receiptItem.ICReceiptItemCPNguyenLieuKhac = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiXuatKhoKhac;
                        receiptItem.ICReceiptItemWoodFee = receiptItem.ICReceiptItemCPNguyenLieuGo;
                        receiptItem.ICReceiptItemHardwareFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiHW;
                        receiptItem.ICReceiptItemPaintFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiSon;
                        receiptItem.ICReceiptItemMaintainFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiBaoBi;
                        //receiptItem.ICReceiptItemOtherFee -= receiptItem.ICReceiptItemDepreciationFee;
                        //receiptItem.ICReceiptItemOtherFee -= receiptItem.ICReceiptItemElecFee;
                        // CP Khau Hao
                        receiptItem.ICReceiptItemDepreciationFee = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiKhauHao;
                        // CP Tien dien
                        receiptItem.ICReceiptItemElecFee = receiptItemWoodQty * (chiPhiTienDien / tongM3TinhToanNhaMay);
                        // Tổng giá BTP
                        receiptItem.ICReceiptItemCostBTP = receiptItem.ICReceiptItemCPNguyenLieuKhac
                            + receiptItem.ICReceiptItemCPNguyenLieuGo
                            + receiptItem.ICReceiptItemCPNCTT
                            + receiptItem.ICReceiptItemCPChung
                            + receiptItem.ICReceiptItemOtherFee;
                        //+ receiptItem.ICReceiptItemDepreciationFee
                        //+ receiptItem.ICReceiptItemElecFee;
                        receiptItem.ICReceiptItemTotalCost = receiptItem.ICReceiptItemCostBTP;
                        // Giá từng BTP
                        receiptItem.ICReceiptItemProductUnitCost = receiptItem.ICReceiptItemTotalCost / receiptItem.ICReceiptItemProductQty;

                        //receiptItem.ICReceiptItemWoodFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemDirectSalaryFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemGeneralFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemOtherFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemHardwareFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemPaintFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemMaintainFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemDepreciationFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemElecFee /= receiptItem.ICReceiptItemProductQty;

                        if (receiptItem.ICReceiptItemProductUnitCost > 0)
                        {
                            BOSApp.RoundByCurrency(receiptItem, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                            objReceiptItemsController.UpdateObject(receiptItem);
                            // Cập nhật lại giá xuất kho BTP
                            //objShipmentItemsInfo = objShipmentItemsController.GetShipmentItemByReceiptItemIDAndBatchProductID(receiptItem.Id, productPrice.FK_MMBatchProductID);
                            //if (objShipmentItemsInfo != null)
                            //{
                            //    objShipmentItemsInfo.ICShipmentItemTotalAmount = receiptItem.ICReceiptItemTotalCost;
                            //    objShipmentItemsInfo.ICShipmentItemTotalCost = receiptItem.ICReceiptItemTotalCost;
                            //    objShipmentItemsInfo.ICShipmentItemProductUnitPrice = receiptItem.ICReceiptItemProductUnitCost;
                            //    objShipmentItemsController.UpdateObject(objShipmentItemsInfo);
                            //}
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCostByOperationID", receiptItem.FK_ICProductID, receiptItem.ICReceiptItemProductSerialNo, receiptItem.ICReceiptItemProductUnitCost, objOperationsInfo.MMOperationID);
                            dbUtil.ExecuteNonQuery("UpdateInventoryCost_B1", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                            // Shipment
                            dbUtil.ExecuteNonQuery("UpdateInventoryCost_B2", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                            // Shipment Accounting
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B3", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B7", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B8", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //// Receipt Accounting
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B4", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B5", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B6", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                        }
                    }
                    //batchProductIDList.Add(productPrice.FK_MMBatchProductID);
                }
            }
            GetProductionCostItemByDate(objProductionCostsInfo.MMProductionCostFromDate,
                                                  objProductionCostsInfo.MMProductionCostToDate, true);

            BOSProgressBar.Close();
        }

        public void ExecCostOprationSon(bool isChange)
        {
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            string CPNCTTAccountNo = "6228";
            string CPChungTTAccountNo = "6277";
            decimal chiPhiNhanCongTT = GetDocumentEntryAmountByAccountNo(CPNCTTAccountNo)
                - GetDocumentEntryCreditAmountByAccountNo(CPNCTTAccountNo);
            decimal chiPhiChungTT = GetDocumentEntryAmountByAccountNo(CPChungTTAccountNo)
                - GetDocumentEntryCreditAmountByAccountNo(CPChungTTAccountNo);
            decimal chiPhiChungNhaMay = GetDocumentEntryAmountByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay6279)
                    - GetDocumentEntryCreditAmountByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay6279);
            if (chiPhiNhanCongTT == 0 || chiPhiChungTT == 0 || chiPhiChungNhaMay == 0)
            {
                if (MessageBox.Show("Có chi phí sản xuất không xác định được, bạn có muốn tiếp tục?", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    BOSProgressBar.Close();
                    return;
                }
            }
            decimal chiPhi6279 = chiPhiChungNhaMay;

            objProductionCostsInfo.MMProductionCost6279FeeS = 0;
            decimal chiPhiKhauHao = GetDocumentEntryAmountByAccountNo("62772");
            decimal chiPhiTienDien = GetDocumentEntryAmountByAccountNo("62794");
            decimal chiPhiHW = 0;
            decimal chiPhiSon = 0;
            decimal chiPhiBaoBi = 0;

            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDSonNo);

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> receiptItemList;
            List<ICReceiptItemsInfo> receiptItemList1;
            List<MMProductionCostIngredientCostSonsInfo> shipmentItemOtherList;
            List<MMProductionCostIngredientCostSonsInfo> shipmentItemOtherList1 = new List<MMProductionCostIngredientCostSonsInfo>();
            List<MMProductionCostIngredientCostSonsInfo> receiptItemOtherList;
            decimal chiPhiXuatKhoGo = 0;
            decimal chiPhiXuatKhoKhac = 0;
            decimal chiPhiKhac = 0;
            decimal TongM3TinhLSX = 0;
            decimal TongM3Tinh = 0;
            decimal tongM3TinhToanNhaMay = 0;
            ICShipmentItemsInfo objShipmentItemsInfo;
            BOSDbUtil dbUtil = new BOSDbUtil();
            receiptItemList = objReceiptItemsController.GetReceiptItemByOperationIDAndDate(objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            List<ICReceiptItemsInfo> receiptItems = objReceiptItemsController.GetReceiptItemByAllOperationIDAndDate(objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            TongM3Tinh = receiptItemList.Sum(e => e.ICReceiptItemWoodQty);
            tongM3TinhToanNhaMay = receiptItems.Sum(e => e.ICReceiptItemWoodQty);
            //TongM3Tinh = receiptItemList.Sum(e => e.ICReceiptItemProductHeight * e.ICReceiptItemProductWidth * e.ICReceiptItemProductLength * e.ICReceiptItemProductQty / 1000000000);
            //tongM3TinhToanNhaMay = receiptItems.Sum(e => e.ICReceiptItemProductHeight * e.ICReceiptItemProductWidth * e.ICReceiptItemProductLength * e.ICReceiptItemProductQty / 1000000000);

            //List<int> batchProductIDList = new List<int>();
            dbUtil.ExecuteNonQuery("ResetInventoryCostByOperationID", objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            int percent = 0;

            List<MMProductionCostIngredientCostSonsInfo> xuatSon = new List<MMProductionCostIngredientCostSonsInfo>();
            ICShipmentItemsInfo itemShipment = null;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo = null;
            ICShipmentsController objShipmentController = new ICShipmentsController();
            List<int> batchProductIDList = entity.ProductionCostItemList.Select(item => item.FK_MMBatchProductID).Distinct().ToList();
            Dictionary<int, MMProductionCostIngredientCostSonsInfo> collection = new Dictionary<int, MMProductionCostIngredientCostSonsInfo>();
            List<ICShipmentItemsInfo> shipmentProductList;
            //foreach (MMProductionCostItemsInfo productPrice in entity.ProductionCostItemList)
            foreach (int batchProductID in batchProductIDList)
            {
                percent++;
                decimal pct = (percent * 100) / batchProductIDList.Count;
                BOSProgressBar.Start("Đang tính giá thành sơn  " + Math.Round(pct) + " % ");

                //if (!batchProductIDList.Contains(productPrice.FK_MMBatchProductID))
                {
                    //if (productPrice.FK_MMBatchProductID == 543)
                    //{
                    //    string a = "";
                    //}
                    chiPhiKhac = 0;
                    foreach (MMProductionCostOtherFeesInfo item in entity.ProductionCostOtherFeesList)
                    {
                        if (item.FK_MMBatchProductID == batchProductID
                            && item.FK_MMOperationID == objOperationsInfo.MMOperationID)
                        {
                            chiPhiKhac += item.MMProductionCostOtherFeeTotalAmount;
                        }
                    }
                    chiPhiXuatKhoKhac = 0;
                    //shipmentItemOtherList = objShipmentItemsController.GetShipmentItemOtherBySomeCriteria2(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    //shipmentItemOtherList.Clear();
                    //xuatSon = entity.ProductionCostIngredientCostListSon.Where(p => p.FK_MMBatchProductID == productPrice.FK_MMBatchProductID
                    //    && p.MMProductionCostIngredientCostSonReferenceType == ProductionCostIngredientCostReferenceType.XuatKho
                    //    && p.MMProductionCostIngredientCostSonReferenceNo.IndexOf("XKVT-") >= 0).ToList();
                    //foreach (MMProductionCostIngredientCostSonsInfo item in xuatSon)
                    //{
                    //    itemShipment = new ICShipmentItemsInfo();
                    //    BOSUtil.CopyObject(item, itemShipment);
                    //    objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.MMProductionCostIngredientCostSonProductSerialNo);
                    //    if (objProductSeriesInfo != null)
                    //    {
                    //        itemShipment.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                    //    }
                    //    itemShipment.FK_ICProductID = item.FK_ICProductID;
                    //    itemShipment.FK_MMBatchProductID = item.FK_MMBatchProductID;
                    //    itemShipment.ICShipmentItemProductQty = item.MMProductionCostIngredientCostSonProductQty;
                    //    itemShipment.ICShipmentItemProductUnitPrice = item.MMProductionCostIngredientCostSonProductUnitCost;
                    //    itemShipment.ICShipmentItemWoodQty = item.MMProductionCostIngredientCostSonProductWoodQty;
                    //    itemShipment.ICShipmentItemTotalAmount = item.MMProductionCostIngredientCostSonTotalCost;
                    //    itemShipment.ICShipmentNo = item.MMProductionCostIngredientCostSonReferenceNo;
                    //    itemShipment.MMBatchProductNo = item.MMProductionCostIngredientCostSonBatchProductNo;
                    //    itemShipment.MMOperationName = item.MMProductionCostIngredientCostSonOperationName;
                    //    itemShipment.ICMeasureUnitName = item.MMProductionCostIngredientCostSonMeasureUnitName;
                    //    itemShipment.ICStockName = item.MMProductionCostIngredientCostSonStockName;
                    //    itemShipment.ICProductNo = item.MMProductionCostIngredientCostSonProductNo;

                    //    ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByNo(item.MMProductionCostIngredientCostSonReferenceNo);
                    //    if (objShipmentInfo != null)
                    //    {
                    //        itemShipment.FK_ICShipmentID = objShipmentInfo.ICShipmentID;
                    //        itemShipment.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                    //        itemShipment.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                    //        itemShipment.ICShipmentType = objShipmentInfo.ICShipmentTypeCombo;
                    //    }
                    //    shipmentItemOtherList.Add(itemShipment);
                    //}

                    shipmentItemOtherList = entity.ProductionCostIngredientCostListSon.Where(item => item.FK_MMBatchProductID == batchProductID
                            && item.MMProductionCostIngredientCostSonReferenceTypeCombo == ShipmentType.MaterialShipment.ToString()).OrderBy(item => item.FK_ICProductSerieID).ToList();

                    receiptItemOtherList = entity.ProductionCostIngredientCostListSon.Where(item => item.FK_MMBatchProductID == batchProductID
                            && (item.MMProductionCostIngredientCostSonReferenceTypeCombo == ReceiptType.MaterialReturnReceipt.ToString()
                            || item.MMProductionCostIngredientCostSonReferenceTypeCombo == ReceiptType.MaterialRedundantReceipt.ToString())).ToList();

                    collection.Clear();
                    shipmentItemOtherList1.Clear();
                    if (receiptItemOtherList != null && receiptItemOtherList.Count > 0)
                    {
                        foreach (MMProductionCostIngredientCostSonsInfo receiptItem in receiptItemOtherList)
                        {
                            int key = receiptItem.FK_ICProductID;
                            if (!collection.Keys.Contains(key))
                                collection.Add(key, new MMProductionCostIngredientCostSonsInfo());
                            collection[key].MMProductionCostIngredientCostSonProductQty += receiptItem.MMProductionCostIngredientCostSonProductQty;
                            collection[key].MMProductionCostIngredientCostSonTotalCost += receiptItem.MMProductionCostIngredientCostSonTotalCost;
                        }

                    }

                    foreach (MMProductionCostIngredientCostSonsInfo shipmentItem in shipmentItemOtherList)
                    {
                        int key = shipmentItem.FK_ICProductID;
                        decimal remainQty = 0;
                        decimal value = 0;
                        if (collection.Keys.Contains(key) && (
                            collection[key].MMProductionCostIngredientCostSonProductQty > 0 ||
                            collection[key].MMProductionCostIngredientCostSonTotalCost > 0))
                        {
                            remainQty = Math.Min(shipmentItem.MMProductionCostIngredientCostSonProductQty, collection[key].MMProductionCostIngredientCostSonProductQty);
                            value = Math.Min(shipmentItem.MMProductionCostIngredientCostSonProductQty, collection[key].MMProductionCostIngredientCostSonProductQty);
                            collection[key].MMProductionCostIngredientCostSonProductQty -= remainQty;
                            collection[key].MMProductionCostIngredientCostSonTotalCost -= value;
                        }
                        if (shipmentItem.MMProductionCostIngredientCostSonProductQty != remainQty ||
                            shipmentItem.MMProductionCostIngredientCostSonTotalCost != value)
                        {
                            MMProductionCostIngredientCostSonsInfo shipmentItem1 = new MMProductionCostIngredientCostSonsInfo();
                            BOSUtil.CopyObject(shipmentItem, shipmentItem1);
                            shipmentItem1.MMProductionCostIngredientCostSonProductQty = shipmentItem.MMProductionCostIngredientCostSonProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostSonProductWoodQty = shipmentItem.MMProductionCostIngredientCostSonProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostSonTotalCost -= value;
                            if (shipmentItem1.MMProductionCostIngredientCostSonProductQty != 0)
                                shipmentItem1.MMProductionCostIngredientCostSonProductUnitCost = shipmentItem1.MMProductionCostIngredientCostSonTotalCost / shipmentItem1.MMProductionCostIngredientCostSonProductQty;
                            shipmentItemOtherList1.Add(shipmentItem1);
                        }
                    }


                    chiPhiHW = 0;
                    chiPhiSon = 0;
                    chiPhiBaoBi = 0;
                    foreach (MMProductionCostIngredientCostSonsInfo shipmentItem in shipmentItemOtherList1)
                    {
                        chiPhiXuatKhoKhac += shipmentItem.MMProductionCostIngredientCostSonTotalCost;
                        ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(i => i.ICProductID == shipmentItem.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            if (objProductsInfo.ICProductType == ProductType.Hardware.ToString())
                            {
                                chiPhiHW += shipmentItem.MMProductionCostIngredientCostSonTotalCost;
                            }
                            else if (objProductsInfo.ICProductType == ProductType.IngredientPackaging.ToString())
                            {
                                chiPhiBaoBi += shipmentItem.MMProductionCostIngredientCostSonTotalCost;
                            }
                            else if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString())
                            {
                                chiPhiSon += shipmentItem.MMProductionCostIngredientCostSonTotalCost;
                            }
                            else
                            {
                                chiPhiHW += shipmentItem.MMProductionCostIngredientCostSonTotalCost;
                            }
                        }
                    }
                    chiPhiXuatKhoGo = 0;

                    // Trừ giá trị NLP nhập lại
                    //receiptItemList = objReceiptItemsController.GetReceiptItemVLPByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    //chiPhiXuatKhoKhac = chiPhiXuatKhoKhac - receiptItemList.Sum(e => e.ICReceiptItemTotalCost);
                    //receiptItemList.Clear();

                    //shipmentItemList = objShipmentItemsController.GetShipmentItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    shipmentItemList.Clear();
                    int index = 1;

                    xuatSon = entity.ProductionCostIngredientCostListSon.Where(p => p.FK_MMBatchProductID == batchProductID
                        && p.MMProductionCostIngredientCostSonReferenceType == ProductionCostIngredientCostReferenceType.XuatKho
                        && p.MMProductionCostIngredientCostSonReferenceNo.IndexOf("XKBTP-") >= 0).ToList();

                    foreach (MMProductionCostIngredientCostSonsInfo item in xuatSon)
                    {
                        itemShipment = new ICShipmentItemsInfo();
                        BOSUtil.CopyObject(item, itemShipment);
                        //objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.MMProductionCostIngredientCostSonProductSerialNo);
                        //if (objProductSeriesInfo != null)
                        //{
                        //    itemShipment.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                        //}
                        itemShipment.FK_ICProductID = item.FK_ICProductID;
                        itemShipment.FK_MMBatchProductID = item.FK_MMBatchProductID;
                        itemShipment.ICShipmentItemProductQty = item.MMProductionCostIngredientCostSonProductQty;
                        itemShipment.ICShipmentItemProductUnitPrice = item.MMProductionCostIngredientCostSonProductUnitCost;
                        itemShipment.ICShipmentItemWoodQty = item.MMProductionCostIngredientCostSonProductWoodQty;
                        itemShipment.ICShipmentItemTotalAmount = item.MMProductionCostIngredientCostSonTotalCost;
                        itemShipment.ICShipmentNo = item.MMProductionCostIngredientCostSonReferenceNo;
                        itemShipment.MMBatchProductNo = item.MMProductionCostIngredientCostSonBatchProductNo;
                        itemShipment.MMOperationName = item.MMProductionCostIngredientCostSonOperationName;
                        itemShipment.ICMeasureUnitName = item.MMProductionCostIngredientCostSonMeasureUnitName;
                        itemShipment.ICStockName = item.MMProductionCostIngredientCostSonStockName;
                        itemShipment.ICProductNo = item.MMProductionCostIngredientCostSonProductNo;

                        //ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByNo(item.MMProductionCostIngredientCostSonReferenceNo);
                        //if (objShipmentInfo != null)
                        //{
                        //    itemShipment.FK_ICShipmentID = objShipmentInfo.ICShipmentID;
                        //    itemShipment.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                        //    itemShipment.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                        //    itemShipment.ICShipmentType = objShipmentInfo.ICShipmentTypeCombo;
                        //}
                        itemShipment.ICShipmentType = item.MMProductionCostIngredientCostSonReferenceTypeCombo;
                        itemShipment.Id = index;
                        index++;
                        shipmentItemList.Add(itemShipment);
                    }
                    //receiptItemList = objReceiptItemsController.GetReceiptItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    receiptItemList1 = receiptItemList.Where(item => item.FK_MMBatchProductID == batchProductID).ToList();

                    //List<int> productIDList = new List<int>();
                    //foreach (ICShipmentItemsInfo shipmentItem in shipmentItemList)
                    //{
                    //    //chiPhiXuatKhoGo += shipmentItem.ICShipmentItemTotalAmount;
                    //    if (!productIDList.Contains(shipmentItem.FK_ICProductID))
                    //    {
                    //        decimal tongSLXuat = shipmentItemList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.ICShipmentItemProductQty);
                    //        decimal tongSLNhap = receiptItemList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.ICReceiptItemProductQty);
                    //        if (tongSLNhap > 0)
                    //        {
                    //            chiPhiXuatKhoGo += (tongSLNhap * shipmentItem.ICShipmentItemProductUnitPrice);
                    //        }
                    //        productIDList.Add(shipmentItem.FK_ICProductID);
                    //    }

                    //}

                    //TongM3TinhLSX = receiptItemList.Sum(e => e.ICReceiptItemProductHeight * e.ICReceiptItemProductWidth * e.ICReceiptItemProductLength * e.ICReceiptItemProductQty / 1000000000);
                    TongM3TinhLSX = receiptItemList1.Sum(e => e.ICReceiptItemWoodQty);

                    foreach (ICReceiptItemsInfo receiptItem in receiptItemList1)
                    {
                        //if (receiptItem.FK_ICProductID == 49045)
                        //{
                        //    string b = "";
                        //}


                        //decimal receiptItemWoodQty = receiptItem.ICReceiptItemProductHeight *
                        //                        receiptItem.ICReceiptItemProductWidth * 
                        //                        receiptItem.ICReceiptItemProductLength *
                        //                        receiptItem.ICReceiptItemProductQty / 1000000000;
                        decimal receiptItemWoodQty = receiptItem.ICReceiptItemWoodQty;
                        // % m3 tinh thực nhập
                        receiptItem.ICReceiptItemM3PercentCPChung = receiptItemWoodQty / TongM3Tinh;
                        receiptItem.ICReceiptItemM3PercentCPGo = receiptItemWoodQty / TongM3TinhLSX;
                        // CP NL Gỗ
                        //receiptItem.ICReceiptItemCPNguyenLieuGo = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiXuatKhoGo;
                        shipmentProductList = shipmentItemList.Where(x => x.FK_ICProductID == receiptItem.FK_ICProductID
                                                                        && x.ReceiptQty < x.ICShipmentItemProductQty).OrderBy(x => x.FK_ICProductSerieID).ToList();

                        if (shipmentProductList.Count > 0)
                        {
                            //decimal tongSLXuat = shipmentProductList.Sum(x => x.ICShipmentItemProductQty - x.ReceiptQty);
                            //if (receiptItem.ICReceiptItemProductQty >= tongSLXuat)
                            //{
                            //    receiptItem.ICReceiptItemCPNguyenLieuGo += shipmentProductList.Sum(x => x.ICShipmentItemProductUnitPrice * (x.ICShipmentItemProductQty - x.ReceiptQty));
                            //    //if (receiptItem.ICReceiptItemProductQty - tongSLXuat > 0)
                            //    //{
                            //    //    objShipmentItemsInfo = shipmentProductList[0];
                            //    //    receiptItem.ICReceiptItemCPNguyenLieuGo += (receiptItem.ICReceiptItemProductQty - tongSLXuat) * objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
                            //    //}
                            //}
                            //else
                            //{

                            decimal remainQty = receiptItem.ICReceiptItemProductQty;
                            foreach (ICShipmentItemsInfo subItemShipment in shipmentProductList)
                            {
                                if (remainQty > 0)
                                {
                                    //if (subItemShipment.ICShipmentItemProductQty - remainQty >= 0)
                                    //{
                                    //    receiptItem.ICReceiptItemCPNguyenLieuGo += remainQty * subItemShipment.ICShipmentItemProductUnitPrice;
                                    //}
                                    //else
                                    //{
                                    //    decimal qty = Math.Min(remainQty, subItemShipment.ICShipmentItemProductQty);
                                    //    receiptItem.ICReceiptItemCPNguyenLieuGo += qty * subItemShipment.ICShipmentItemProductUnitPrice;
                                    //}
                                    //remainQty = remainQty - subItemShipment.ICShipmentItemProductQty;
                                    decimal qty = Math.Min(remainQty, subItemShipment.ICShipmentItemProductQty - subItemShipment.ReceiptQty);
                                    receiptItem.ICReceiptItemCPNguyenLieuGo += qty * subItemShipment.ICShipmentItemProductUnitPrice;
                                    remainQty = remainQty - qty;
                                    ICShipmentItemsInfo foundItem = shipmentItemList.FirstOrDefault(item => item.Id == subItemShipment.Id);
                                    if (foundItem != null)
                                        foundItem.ReceiptQty += qty;
                                }
                                else
                                {
                                    break;
                                }

                            }
                            //}
                        }
                        else
                        {
                            receiptItem.ICReceiptItemCPNguyenLieuGo = 0;
                        }
                        // CP nhân công TT
                        receiptItem.ICReceiptItemCPNCTT = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiNhanCongTT;
                        receiptItem.ICReceiptItemDirectSalaryFee = receiptItem.ICReceiptItemCPNCTT;
                        // CP Chung
                        receiptItem.ICReceiptItemCPChung = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiChungTT;
                        receiptItem.ICReceiptItemGeneralFee = receiptItem.ICReceiptItemCPChung;
                        // CP Chung nhà máy
                        //receiptItem.ICReceiptItemCPChungNhaMay = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiChungNhaMay/6;
                        receiptItem.ICReceiptItemCPChungNhaMay = receiptItemWoodQty * chiPhiChungNhaMay / tongM3TinhToanNhaMay;
                        objProductionCostsInfo.MMProductionCost6279FeeS += receiptItemWoodQty * (chiPhi6279 / tongM3TinhToanNhaMay);
                        receiptItem.ICReceiptItemOtherFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiKhac;
                        receiptItem.ICReceiptItemOtherFee += receiptItem.ICReceiptItemCPChungNhaMay;
                        // CP HW, PLDG, Son
                        receiptItem.ICReceiptItemCPNguyenLieuKhac = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiXuatKhoKhac;
                        receiptItem.ICReceiptItemWoodFee = receiptItem.ICReceiptItemCPNguyenLieuGo;
                        receiptItem.ICReceiptItemHardwareFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiHW;
                        receiptItem.ICReceiptItemPaintFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiSon;
                        receiptItem.ICReceiptItemMaintainFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiBaoBi;
                        //receiptItem.ICReceiptItemOtherFee -= receiptItem.ICReceiptItemDepreciationFee;
                        //receiptItem.ICReceiptItemOtherFee -= receiptItem.ICReceiptItemElecFee;
                        // CP Khau Hao
                        receiptItem.ICReceiptItemDepreciationFee = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiKhauHao;
                        // CP Tien dien
                        receiptItem.ICReceiptItemElecFee = receiptItemWoodQty * (chiPhiTienDien / tongM3TinhToanNhaMay);
                        // Tổng giá BTP
                        receiptItem.ICReceiptItemCostBTP = receiptItem.ICReceiptItemCPNguyenLieuKhac
                            + receiptItem.ICReceiptItemCPNguyenLieuGo
                            + receiptItem.ICReceiptItemCPNCTT
                            + receiptItem.ICReceiptItemCPChung
                            + receiptItem.ICReceiptItemOtherFee;
                        //+ receiptItem.ICReceiptItemDepreciationFee
                        //+ receiptItem.ICReceiptItemElecFee;
                        receiptItem.ICReceiptItemTotalCost = receiptItem.ICReceiptItemCostBTP;
                        // Giá từng BTP
                        receiptItem.ICReceiptItemProductUnitCost = receiptItem.ICReceiptItemTotalCost / receiptItem.ICReceiptItemProductQty;

                        //receiptItem.ICReceiptItemWoodFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemDirectSalaryFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemGeneralFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemOtherFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemHardwareFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemPaintFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemMaintainFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemDepreciationFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemElecFee /= receiptItem.ICReceiptItemProductQty;

                        if (receiptItem.ICReceiptItemProductUnitCost > 0)
                        {
                            BOSApp.RoundByCurrency(receiptItem, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                            objReceiptItemsController.UpdateObject(receiptItem);
                            // Cập nhật lại giá xuất kho BTP
                            //objShipmentItemsInfo = objShipmentItemsController.GetShipmentItemByReceiptItemIDAndBatchProductID(receiptItem.Id, productPrice.FK_MMBatchProductID);
                            //if (objShipmentItemsInfo != null)
                            //{
                            //    objShipmentItemsInfo.ICShipmentItemTotalAmount = receiptItem.ICReceiptItemTotalCost;
                            //    objShipmentItemsInfo.ICShipmentItemTotalCost = receiptItem.ICReceiptItemTotalCost;
                            //    objShipmentItemsInfo.ICShipmentItemProductUnitPrice = receiptItem.ICReceiptItemProductUnitCost;
                            //    objShipmentItemsController.UpdateObject(objShipmentItemsInfo);
                            //}
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCostByOperationID", receiptItem.FK_ICProductID, receiptItem.ICReceiptItemProductSerialNo, receiptItem.ICReceiptItemProductUnitCost, objOperationsInfo.MMOperationID);
                            dbUtil.ExecuteNonQuery("UpdateInventoryCost_B1", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                            // Shipment
                            dbUtil.ExecuteNonQuery("UpdateInventoryCost_B2", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                            // Shipment Accounting
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B3", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B7", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B8", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //// Receipt Accounting
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B4", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B5", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B6", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                        }
                    }
                    //batchProductIDList.Add(productPrice.FK_MMBatchProductID);
                }
            }
            GetProductionCostItemByDate(objProductionCostsInfo.MMProductionCostFromDate,
                                                  objProductionCostsInfo.MMProductionCostToDate, true);

            BOSProgressBar.Close();
        }

        public void ExecCostOprationLR(bool isChange)
        {
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            string CPNCTTAccountNo = "6227";
            string CPChungTTAccountNo = "6276";

            decimal chiPhiNhanCongTT = GetDocumentEntryAmountByAccountNo(CPNCTTAccountNo)
                - GetDocumentEntryCreditAmountByAccountNo(CPNCTTAccountNo);

            decimal chiPhiChungTT = GetDocumentEntryAmountByAccountNo(CPChungTTAccountNo)
                - GetDocumentEntryCreditAmountByAccountNo(CPChungTTAccountNo);
            decimal chiPhiChungNhaMay = GetDocumentEntryAmountByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay6279)
                    - GetDocumentEntryCreditAmountByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay6279);
            if (chiPhiNhanCongTT == 0 || chiPhiChungTT == 0 || chiPhiChungNhaMay == 0)
            {
                if (MessageBox.Show("Có chi phí sản xuất không xác định được, bạn có muốn tiếp tục?", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    BOSProgressBar.Close();
                    return;
                }
            }
            decimal chiPhi6279 = chiPhiChungNhaMay;

            objProductionCostsInfo.MMProductionCost6279FeeLR = 0;
            decimal chiPhiKhauHao = GetDocumentEntryAmountByAccountNo("62762");
            decimal chiPhiTienDien = GetDocumentEntryAmountByAccountNo("62794");
            decimal chiPhiHW = 0;
            decimal chiPhiSon = 0;
            decimal chiPhiBaoBi = 0;

            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDLapRapNo);

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> receiptItemList;
            List<ICReceiptItemsInfo> receiptItemList1;
            List<MMProductionCostIngredientCostLRsInfo> shipmentItemOtherList;
            List<MMProductionCostIngredientCostLRsInfo> shipmentItemOtherList1 = new List<MMProductionCostIngredientCostLRsInfo>();
            List<MMProductionCostIngredientCostLRsInfo> receiptItemOtherList;
            decimal chiPhiXuatKhoGo = 0;
            decimal chiPhiXuatKhoKhac = 0;
            decimal chiPhiKhac = 0;
            decimal TongM3TinhLSX = 0;
            decimal TongM3Tinh = 0;
            decimal tongM3TinhToanNhaMay = 0;
            decimal TongCPNguyenLieuKhac = 0;
            decimal TongCPNguyenLieuTT = 0;
            decimal TongCPKhac = 0;
            ICShipmentItemsInfo objShipmentItemsInfo;
            BOSDbUtil dbUtil = new BOSDbUtil();
            receiptItemList = objReceiptItemsController.GetReceiptItemByOperationIDAndDate(objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            List<ICReceiptItemsInfo> receiptItems = objReceiptItemsController.GetReceiptItemByAllOperationIDAndDate(objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            TongM3Tinh = receiptItemList.Sum(e => e.ICReceiptItemWoodQty);
            tongM3TinhToanNhaMay = receiptItems.Sum(e => e.ICReceiptItemWoodQty);
            //TongM3Tinh = receiptItemList.Sum(e => e.ICReceiptItemProductHeight * e.ICReceiptItemProductWidth * e.ICReceiptItemProductLength * e.ICReceiptItemProductQty / 1000000000);
            //decimal TongM3Tinh2 = receiptItemList.Sum(e => e.ICReceiptItemWoodQty);
            //tongM3TinhToanNhaMay = receiptItems.Sum(e => e.ICReceiptItemProductHeight * e.ICReceiptItemProductWidth * e.ICReceiptItemProductLength * e.ICReceiptItemProductQty / 1000000000);

            MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            List<ICReceiptItemsInfo> receiptItemDetailList = new List<ICReceiptItemsInfo>();
            //List<int> batchProductIDList = new List<int>();
            dbUtil.ExecuteNonQuery("ResetInventoryCostByOperationID", objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            int percent = 0;

            List<MMProductionCostIngredientCostLRsInfo> xuatLR = new List<MMProductionCostIngredientCostLRsInfo>();
            ICShipmentItemsInfo itemShipment = null;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo = null;
            ICShipmentsController objShipmentController = new ICShipmentsController();

            List<int> batchProductIDList = entity.ProductionCostItemList.Select(item => item.FK_MMBatchProductID).Distinct().ToList();
            Dictionary<int, MMProductionCostIngredientCostLRsInfo> collection = new Dictionary<int, MMProductionCostIngredientCostLRsInfo>();
            List<ICShipmentItemsInfo> shipmentProductList;
            //foreach (MMProductionCostItemsInfo productPrice in entity.ProductionCostItemList)
            Dictionary<int, decimal> woodFeeCollection = new Dictionary<int, decimal>();
            Dictionary<int, decimal> woodQtyCollection = new Dictionary<int, decimal>();
            foreach (int batchProductID in batchProductIDList)
            {
                percent++;
                decimal pct = (percent * 100) / batchProductIDList.Count;
                BOSProgressBar.Start("Đang tính giá thành lắp ráp  " + Math.Round(pct) + " %");

                //if (!batchProductIDList.Contains(productPrice.FK_MMBatchProductID))
                {
                    if (batchProductID == 1009)
                    {
                        //continue;

                        string a = "a";
                    }
                    chiPhiKhac = 0;
                    foreach (MMProductionCostOtherFeesInfo item in entity.ProductionCostOtherFeesList)
                    {
                        if (item.FK_MMBatchProductID == batchProductID
                            && item.FK_MMOperationID == objOperationsInfo.MMOperationID)
                        {
                            chiPhiKhac += item.MMProductionCostOtherFeeTotalAmount;
                        }
                    }
                    TongCPKhac += chiPhiKhac;
                    chiPhiXuatKhoKhac = 0;
                    //shipmentItemOtherList = objShipmentItemsController.GetShipmentItemOtherBySomeCriteria2(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    //shipmentItemOtherList.Clear();
                    //xuatLR = entity.ProductionCostIngredientCostListLR.Where(p => p.FK_MMBatchProductID == productPrice.FK_MMBatchProductID
                    //    && p.MMProductionCostIngredientCostLRReferenceType == ProductionCostIngredientCostReferenceType.XuatKho
                    //    && p.MMProductionCostIngredientCostLRReferenceNo.IndexOf("XKVT-")>=0).ToList();
                    //foreach (MMProductionCostIngredientCostLRsInfo item in xuatLR)
                    //{
                    //    itemShipment = new ICShipmentItemsInfo();
                    //    BOSUtil.CopyObject(item, itemShipment);
                    //    ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByNo(item.MMProductionCostIngredientCostLRReferenceNo);
                    //    if (objShipmentInfo != null)
                    //    {
                    //        itemShipment.FK_ICShipmentID = objShipmentInfo.ICShipmentID;
                    //        itemShipment.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                    //        itemShipment.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                    //        itemShipment.ICShipmentType = objShipmentInfo.ICShipmentTypeCombo;
                    //    }
                    //    objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.MMProductionCostIngredientCostLRProductSerialNo);
                    //    if (objProductSeriesInfo != null)
                    //    {
                    //        itemShipment.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                    //    }
                    //    itemShipment.FK_ICProductID = item.FK_ICProductID;
                    //    itemShipment.FK_MMBatchProductID = item.FK_MMBatchProductID;
                    //    itemShipment.ICShipmentItemProductQty = item.MMProductionCostIngredientCostLRProductQty;
                    //    itemShipment.ICShipmentItemProductUnitPrice = item.MMProductionCostIngredientCostLRProductUnitCost;
                    //    itemShipment.ICShipmentItemWoodQty = item.MMProductionCostIngredientCostLRProductWoodQty;
                    //    itemShipment.ICShipmentItemTotalAmount = item.MMProductionCostIngredientCostLRTotalCost;
                    //    itemShipment.ICShipmentNo = item.MMProductionCostIngredientCostLRReferenceNo;
                    //    itemShipment.MMBatchProductNo = item.MMProductionCostIngredientCostLRBatchProductNo;
                    //    itemShipment.MMOperationName = item.MMProductionCostIngredientCostLROperationName;
                    //    itemShipment.ICMeasureUnitName = item.MMProductionCostIngredientCostLRMeasureUnitName;
                    //    itemShipment.ICStockName = item.MMProductionCostIngredientCostLRStockName;
                    //    itemShipment.ICProductNo = item.MMProductionCostIngredientCostLRProductNo;
                    //    shipmentItemOtherList.Add(itemShipment);
                    //}


                    shipmentItemOtherList = entity.ProductionCostIngredientCostListLR.Where(item => item.FK_MMBatchProductID == batchProductID
                            && item.MMProductionCostIngredientCostLRReferenceTypeCombo == ShipmentType.MaterialShipment.ToString()).OrderBy(item => item.FK_ICProductSerieID).ToList();

                    receiptItemOtherList = entity.ProductionCostIngredientCostListLR.Where(item => item.FK_MMBatchProductID == batchProductID
                            && (item.MMProductionCostIngredientCostLRReferenceTypeCombo == ReceiptType.MaterialReturnReceipt.ToString()
                            || item.MMProductionCostIngredientCostLRReferenceTypeCombo == ReceiptType.MaterialRedundantReceipt.ToString())).ToList();

                    collection.Clear();
                    shipmentItemOtherList1.Clear();
                    if (receiptItemOtherList != null && receiptItemOtherList.Count > 0)
                    {
                        foreach (MMProductionCostIngredientCostLRsInfo receiptItem in receiptItemOtherList)
                        {
                            int key = receiptItem.FK_ICProductID;
                            if (!collection.Keys.Contains(key))
                                collection.Add(key, new MMProductionCostIngredientCostLRsInfo());
                            collection[key].MMProductionCostIngredientCostLRProductQty += receiptItem.MMProductionCostIngredientCostLRProductQty;
                            collection[key].MMProductionCostIngredientCostLRTotalCost += receiptItem.MMProductionCostIngredientCostLRTotalCost;
                        }

                    }

                    foreach (int key in collection.Keys)
                    {
                        if (collection[key].MMProductionCostIngredientCostLRProductQty != 0)
                            collection[key].MMProductionCostIngredientCostLRProductUnitCost = collection[key].MMProductionCostIngredientCostLRTotalCost / collection[key].MMProductionCostIngredientCostLRProductQty;
                    }

                    foreach (MMProductionCostIngredientCostLRsInfo shipmentItem in shipmentItemOtherList)
                    {
                        int key = shipmentItem.FK_ICProductID;
                        decimal remainQty = 0;
                        decimal value = 0;
                        if (collection.Keys.Contains(key) &&
                            (collection[key].MMProductionCostIngredientCostLRProductQty > 0 ||
                            collection[key].MMProductionCostIngredientCostLRTotalCost > 0))
                        {
                            remainQty = Math.Min(shipmentItem.MMProductionCostIngredientCostLRProductQty, collection[key].MMProductionCostIngredientCostLRProductQty);
                            value = Math.Min(shipmentItem.MMProductionCostIngredientCostLRTotalCost, collection[key].MMProductionCostIngredientCostLRTotalCost);
                            collection[key].MMProductionCostIngredientCostLRProductQty -= remainQty;
                            collection[key].MMProductionCostIngredientCostLRTotalCost -= value;
                        }
                        if (shipmentItem.MMProductionCostIngredientCostLRProductQty != remainQty ||
                            shipmentItem.MMProductionCostIngredientCostLRTotalCost != value)
                        {
                            MMProductionCostIngredientCostLRsInfo shipmentItem1 = new MMProductionCostIngredientCostLRsInfo();
                            BOSUtil.CopyObject(shipmentItem, shipmentItem1);
                            shipmentItem1.MMProductionCostIngredientCostLRProductQty = shipmentItem.MMProductionCostIngredientCostLRProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostLRProductWoodQty = shipmentItem.MMProductionCostIngredientCostLRProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostLRTotalCost -= value;
                            if (shipmentItem1.MMProductionCostIngredientCostLRProductQty != 0)
                                shipmentItem1.MMProductionCostIngredientCostLRProductUnitCost = shipmentItem1.MMProductionCostIngredientCostLRTotalCost / shipmentItem1.MMProductionCostIngredientCostLRProductQty;
                            shipmentItemOtherList1.Add(shipmentItem1);
                        }
                    }

                    chiPhiHW = 0;
                    chiPhiSon = 0;
                    chiPhiBaoBi = 0;
                    foreach (MMProductionCostIngredientCostLRsInfo shipmentItem in shipmentItemOtherList1)
                    {
                        chiPhiXuatKhoKhac += shipmentItem.MMProductionCostIngredientCostLRTotalCost;
                        ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(i => i.ICProductID == shipmentItem.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            if (objProductsInfo.ICProductType == ProductType.Hardware.ToString())
                            {
                                chiPhiHW += shipmentItem.MMProductionCostIngredientCostLRTotalCost;
                            }
                            else if (objProductsInfo.ICProductType == ProductType.IngredientPackaging.ToString())
                            {
                                chiPhiBaoBi += shipmentItem.MMProductionCostIngredientCostLRTotalCost;
                            }
                            else if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString())
                            {
                                chiPhiSon += shipmentItem.MMProductionCostIngredientCostLRTotalCost;
                            }
                            else
                            {
                                chiPhiHW += shipmentItem.MMProductionCostIngredientCostLRTotalCost;
                            }
                        }

                    }

                    // Trừ giá trị NLP nhập lại
                    //receiptItemList = objReceiptItemsController.GetReceiptItemVLPByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    //chiPhiXuatKhoKhac = chiPhiXuatKhoKhac - receiptItemList.Sum(e => e.ICReceiptItemTotalCost);
                    //receiptItemList.Clear();

                    chiPhiXuatKhoGo = 0;

                    //shipmentItemList = objShipmentItemsController.GetShipmentItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    shipmentItemList.Clear();
                    int index = 1;
                    xuatLR = entity.ProductionCostIngredientCostListLR.Where(p => p.FK_MMBatchProductID == batchProductID
                        && p.MMProductionCostIngredientCostLRReferenceType == ProductionCostIngredientCostReferenceType.XuatKho
                        && p.MMProductionCostIngredientCostLRReferenceNo.IndexOf("XKBTP") >= 0).ToList();
                    foreach (MMProductionCostIngredientCostLRsInfo item in xuatLR)
                    {
                        itemShipment = new ICShipmentItemsInfo();
                        BOSUtil.CopyObject(item, itemShipment);
                        //ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByNo(item.MMProductionCostIngredientCostLRReferenceNo);
                        //if (objShipmentInfo != null)
                        //{
                        //    itemShipment.FK_ICShipmentID = objShipmentInfo.ICShipmentID;
                        //    itemShipment.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                        //    itemShipment.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                        //    itemShipment.ICShipmentType = objShipmentInfo.ICShipmentTypeCombo;
                        //}
                        itemShipment.ICShipmentType = item.MMProductionCostIngredientCostLRReferenceTypeCombo;
                        //objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.MMProductionCostIngredientCostLRProductSerialNo);
                        //if (objProductSeriesInfo != null)
                        //{
                        //    itemShipment.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                        //}
                        itemShipment.FK_ICProductID = item.FK_ICProductID;
                        itemShipment.FK_MMBatchProductID = item.FK_MMBatchProductID;
                        itemShipment.ICShipmentItemProductQty = item.MMProductionCostIngredientCostLRProductQty;
                        itemShipment.ICShipmentItemProductUnitPrice = item.MMProductionCostIngredientCostLRProductUnitCost;
                        itemShipment.ICShipmentItemWoodQty = item.MMProductionCostIngredientCostLRProductWoodQty;
                        itemShipment.ICShipmentItemTotalAmount = item.MMProductionCostIngredientCostLRTotalCost;
                        itemShipment.ICShipmentNo = item.MMProductionCostIngredientCostLRReferenceNo;
                        itemShipment.MMBatchProductNo = item.MMProductionCostIngredientCostLRBatchProductNo;
                        itemShipment.MMOperationName = item.MMProductionCostIngredientCostLROperationName;
                        itemShipment.ICMeasureUnitName = item.MMProductionCostIngredientCostLRMeasureUnitName;
                        itemShipment.ICStockName = item.MMProductionCostIngredientCostLRStockName;
                        itemShipment.ICProductNo = item.MMProductionCostIngredientCostLRProductNo;
                        itemShipment.Id = index;
                        index++;
                        shipmentItemList.Add(itemShipment);
                    }

                    receiptItemList1 = receiptItemList.Where(item => item.FK_MMBatchProductID == batchProductID).ToList();
                    // Kiểm tra chi tiết theo cụm
                    //if (receiptItemList.Count > 0)
                    //{
                    //    foreach (ICReceiptItemsInfo item in receiptItemList)
                    //    {
                    //        if (item.FK_ICProductGroupID == 1 || item.ICReceiptItemProductDesc.Contains("Cụm"))
                    //        {
                    //            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)objReceiptsController.GetObjectByID(item.FK_ICReceiptID);
                    //            List<MMBatchProductProductionNormItemsInfo> bppniList = objBPPNIsController.GetItemByParentID(item.FK_MMBatchProductProductionNormItemID, objReceiptsInfo.FK_MMBatchProductID, objReceiptsInfo.FK_MMOperationID, objReceiptsInfo.FK_ICProductID);
                    //            foreach (MMBatchProductProductionNormItemsInfo bppni in bppniList)
                    //            {
                    //                ICReceiptItemsInfo objItem = new ICReceiptItemsInfo();
                    //                BOSUtil.CopyObject(bppni, objItem);
                    //                objItem.FK_ICProductID = bppni.FK_ICProductID;
                    //                //objItem.ICReceiptItemProductQty = bppni.MMBatchProductProductionNormItemQuantity;
                    //                objItem.ICReceiptItemProductQty = (bppni.MMBatchProductItemProductQty / bppni.MMBatchProductProductionNormItemQuantity) * item.ICReceiptItemProductQty;
                    //                receiptItemDetailList.Add(objItem);
                    //            }
                    //        }
                    //        else
                    //        {
                    //            receiptItemDetailList.Add(item);
                    //        }
                    //    }
                    //}
                    //List<int> productIDList = new List<int>();
                    //foreach (ICShipmentItemsInfo shipmentItem in shipmentItemList)
                    //{
                    //    //chiPhiXuatKhoGo += shipmentItem.ICShipmentItemTotalAmount;
                    //    if (!productIDList.Contains(shipmentItem.FK_ICProductID))
                    //    {
                    //        decimal tongSLXuat = shipmentItemList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.ICShipmentItemProductQty);
                    //        decimal tongSLNhap = receiptItemDetailList.Where(p => p.FK_ICProductID == shipmentItem.FK_ICProductID).Sum(e => e.ICReceiptItemProductQty);
                    //        if (tongSLNhap > 0)
                    //        {
                    //            chiPhiXuatKhoGo += (tongSLNhap * shipmentItem.ICShipmentItemProductUnitPrice);
                    //        }
                    //        productIDList.Add(shipmentItem.FK_ICProductID);
                    //    }

                    //}

                    //TongCPNguyenLieuTT += chiPhiXuatKhoGo;
                    //TongM3TinhLSX = receiptItemList.Sum(e => e.ICReceiptItemProductHeight * e.ICReceiptItemProductWidth * e.ICReceiptItemProductLength * e.ICReceiptItemProductQty / 1000000000);
                    TongM3TinhLSX = receiptItemList1.Sum(e => e.ICReceiptItemWoodQty);


                    List<MMBatchProductProductionNormItemsInfo> bppniList = objBPPNIsController.GetBatchProductProductionNormItemsByBatchProductIDAndProductGroup(batchProductID, "SemiProduct");
                    woodFeeCollection.Clear();
                    woodQtyCollection.Clear();
                    foreach (ICReceiptItemsInfo receiptItem in receiptItemList1)
                    {
                        if (!woodFeeCollection.Keys.Contains(receiptItem.FK_ICProductSerieID))
                            woodFeeCollection.Add(receiptItem.FK_ICProductSerieID, 0);
                        if (!woodQtyCollection.Keys.Contains(receiptItem.FK_ICProductSerieID))
                            woodQtyCollection.Add(receiptItem.FK_ICProductSerieID, 0);
                        woodQtyCollection[receiptItem.FK_ICProductSerieID] += receiptItem.ICReceiptItemWoodQty;
                        //decimal receiptItemWoodQty = receiptItem.ICReceiptItemProductHeight *
                        //                        receiptItem.ICReceiptItemProductWidth * 
                        //                        receiptItem.ICReceiptItemProductLength *
                        //                        receiptItem.ICReceiptItemProductQty / 1000000000;
                        //decimal receiptItemWoodQty = receiptItem.ICReceiptItemWoodQty;
                        //receiptItem.ICReceiptItemCPNguyenLieuGo = 0;
                        //// % m3 tinh thực nhập
                        //receiptItem.ICReceiptItemM3PercentCPChung = receiptItemWoodQty / TongM3Tinh;
                        //receiptItem.ICReceiptItemM3PercentCPGo = receiptItemWoodQty / TongM3TinhLSX;
                        // CP NL Gỗ
                        //receiptItem.ICReceiptItemCPNguyenLieuGo = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiXuatKhoGo;
                        if (receiptItem.FK_ICProductGroupID == 1 || receiptItem.ICReceiptItemProductDesc.Contains("Cụm"))
                        {
                            //ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)objReceiptsController.GetObjectByID(receiptItem.FK_ICReceiptID);
                            //List<MMBatchProductProductionNormItemsInfo> bppniList = objBPPNIsController.GetItemByParentID(receiptItem.FK_MMBatchProductProductionNormItemID, objReceiptsInfo.FK_MMBatchProductID, objReceiptsInfo.FK_MMOperationID, objReceiptsInfo.FK_ICProductID);
                            //if (bppniList.Count == 0)
                            //{
                            //    bppniList = objBPPNIsController.GetItemBySomeCriteria(receiptItem.FK_MMBatchProductItemID, receiptItem.FK_MMBatchProductID, receiptItem.FK_ICProductID);
                            //}
                            List<MMBatchProductProductionNormItemsInfo> bppniList1 = bppniList.Where(pni => pni.MMBatchProductProductionNormItemParentID == receiptItem.FK_MMBatchProductProductionNormItemID).ToList();
                            if (bppniList1.Count == 0)
                            {
                                bppniList1 = bppniList.Where(pni =>
                                                bppniList.Where(pni1 => pni1.FK_MMBatchProductID == receiptItem.FK_MMBatchProductID
                                                    && pni1.FK_ICProductID == receiptItem.FK_ICProductID
                                                    && pni1.FK_MMBatchProductItemID == receiptItem.FK_MMBatchProductItemID)
                                                    .Any(pni2 => pni2.MMBatchProductProductionNormItemID == pni.MMBatchProductProductionNormItemParentID)).ToList();
                            }

                            foreach (MMBatchProductProductionNormItemsInfo bppni in bppniList1)
                            {
                                //objShipmentItemsInfo = shipmentItemList.Where(x => x.FK_ICProductID == bppni.FK_ICProductID).FirstOrDefault();
                                //if (objShipmentItemsInfo != null)
                                //{
                                //    //decimal giaChiTiet = objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
                                //    decimal slChiTiet = (bppni.MMBatchProductProductionNormItemQuantity / bppni.SoLuongCum);
                                //    receiptItem.ICReceiptItemCPNguyenLieuGo += (objShipmentItemsInfo.ICShipmentItemProductUnitPrice * slChiTiet);
                                //}

                                shipmentProductList = shipmentItemList.Where(x => x.FK_ICProductID == bppni.FK_ICProductID
                                                                                    && x.ReceiptQty < x.ICShipmentItemProductQty).OrderBy(x => x.FK_ICProductSerieID).ToList();

                                if (shipmentProductList.Count > 0)
                                {
                                    //decimal tongSLXuat = shipmentProductList.Sum(x => x.ICShipmentItemProductQty - x.ReceiptQty);
                                    decimal slChiTiet = (bppni.MMBatchProductProductionNormItemQuantity / bppni.SoLuongCum);
                                    decimal slChiTietNhap = slChiTiet * receiptItem.ICReceiptItemProductQty;
                                    //if (slChiTietNhap >= tongSLXuat)
                                    //{
                                    //    receiptItem.ICReceiptItemCPNguyenLieuGo += shipmentProductList.Sum(x => x.ICShipmentItemProductUnitPrice * (x.ICShipmentItemProductQty - x.ReceiptQty));
                                    //    //if (slChiTietNhap - tongSLXuat > 0)
                                    //    //{
                                    //    //    objShipmentItemsInfo = shipmentProductList[0];
                                    //    //    receiptItem.ICReceiptItemCPNguyenLieuGo += (slChiTietNhap - tongSLXuat) * objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
                                    //    //}
                                    //}
                                    //else
                                    //{

                                    decimal remainQty = slChiTietNhap;
                                    foreach (ICShipmentItemsInfo subItemShipment in shipmentProductList)
                                    {
                                        if (remainQty > 0)
                                        {
                                            //if (subItemShipment.ICShipmentItemProductQty - remainQty >= 0)
                                            //{
                                            //    receiptItem.ICReceiptItemCPNguyenLieuGo += remainQty * subItemShipment.ICShipmentItemProductUnitPrice;
                                            //}
                                            //else
                                            //{
                                            //    decimal qty = Math.Min(remainQty, subItemShipment.ICShipmentItemProductQty);
                                            //    receiptItem.ICReceiptItemCPNguyenLieuGo += qty * subItemShipment.ICShipmentItemProductUnitPrice;
                                            //}
                                            //remainQty = remainQty - subItemShipment.ICShipmentItemProductQty;
                                            decimal qty = Math.Min(remainQty, subItemShipment.ICShipmentItemProductQty - subItemShipment.ReceiptQty);
                                            //receiptItem.ICReceiptItemCPNguyenLieuGo += qty * subItemShipment.ICShipmentItemProductUnitPrice;
                                            woodFeeCollection[receiptItem.FK_ICProductSerieID] += qty * subItemShipment.ICShipmentItemProductUnitPrice;
                                            remainQty = remainQty - qty;
                                            ICShipmentItemsInfo foundItem = shipmentItemList.FirstOrDefault(item => item.Id == subItemShipment.Id);
                                            if (foundItem != null)
                                                foundItem.ReceiptQty += qty;
                                        }
                                        else
                                        {
                                            break;
                                        }

                                        //}
                                    }
                                }
                                else
                                {
                                    receiptItem.ICReceiptItemCPNguyenLieuGo += 0;
                                }
                            }

                        }
                        else
                        {
                            shipmentProductList = shipmentItemList.Where(x => x.FK_ICProductID == receiptItem.FK_ICProductID).OrderBy(x => x.FK_ICProductSerieID).ToList();

                            if (shipmentProductList.Count > 0)
                            {
                                //decimal tongSLXuat = shipmentProductList.Sum(x => x.ICShipmentItemProductQty);
                                //if (receiptItem.ICReceiptItemProductQty >= tongSLXuat)
                                //{
                                //    receiptItem.ICReceiptItemCPNguyenLieuGo += shipmentProductList.Sum(x => x.ICShipmentItemTotalAmount);
                                //    //if (receiptItem.ICReceiptItemProductQty - tongSLXuat > 0)
                                //    //{
                                //    //    objShipmentItemsInfo = shipmentProductList[0];
                                //    //    receiptItem.ICReceiptItemCPNguyenLieuGo += (receiptItem.ICReceiptItemProductQty - tongSLXuat) * objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
                                //    //}
                                //}
                                //else
                                //{

                                decimal remainQty = receiptItem.ICReceiptItemProductQty;
                                foreach (ICShipmentItemsInfo subItemShipment in shipmentProductList)
                                {
                                    if (remainQty > 0)
                                    {
                                        //if (subItemShipment.ICShipmentItemProductQty - remainQty >= 0)
                                        //{
                                        //    receiptItem.ICReceiptItemCPNguyenLieuGo += remainQty * subItemShipment.ICShipmentItemProductUnitPrice;
                                        //}
                                        //else
                                        //{
                                        //    decimal qty = Math.Min(remainQty, subItemShipment.ICShipmentItemProductQty);
                                        //    receiptItem.ICReceiptItemCPNguyenLieuGo += qty * subItemShipment.ICShipmentItemProductUnitPrice;
                                        //}
                                        //remainQty = remainQty - subItemShipment.ICShipmentItemProductQty;
                                        decimal qty = Math.Min(remainQty, subItemShipment.ICShipmentItemProductQty);
                                        //receiptItem.ICReceiptItemCPNguyenLieuGo += qty * subItemShipment.ICShipmentItemProductUnitPrice;
                                        woodFeeCollection[receiptItem.FK_ICProductSerieID] += qty * subItemShipment.ICShipmentItemProductUnitPrice;
                                        remainQty = remainQty - qty;
                                    }
                                    else
                                    {
                                        break;
                                    }

                                }
                                //}
                            }
                            else
                            {
                                receiptItem.ICReceiptItemCPNguyenLieuGo = 0;
                            }
                        }
                    }
                    foreach (ICReceiptItemsInfo receiptItem in receiptItemList1)
                    {
                        decimal receiptItemWoodQty = receiptItem.ICReceiptItemWoodQty;
                        receiptItem.ICReceiptItemCPNguyenLieuGo = 0;
                        if (woodFeeCollection.Keys.Contains(receiptItem.FK_ICProductSerieID))
                            receiptItem.ICReceiptItemCPNguyenLieuGo = (woodFeeCollection[receiptItem.FK_ICProductSerieID] / woodQtyCollection[receiptItem.FK_ICProductSerieID]) * receiptItemWoodQty;
                        // % m3 tinh thực nhập
                        receiptItem.ICReceiptItemM3PercentCPChung = receiptItemWoodQty / TongM3Tinh;
                        receiptItem.ICReceiptItemM3PercentCPGo = receiptItemWoodQty / TongM3TinhLSX;
                        // CP nhân công TT
                        receiptItem.ICReceiptItemCPNCTT = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiNhanCongTT;
                        receiptItem.ICReceiptItemDirectSalaryFee = receiptItem.ICReceiptItemCPNCTT;
                        // CP Chung
                        receiptItem.ICReceiptItemCPChung = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiChungTT;
                        receiptItem.ICReceiptItemGeneralFee = receiptItem.ICReceiptItemCPChung;
                        // CP Chung nhà máy
                        //receiptItem.ICReceiptItemCPChungNhaMay = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiChungNhaMay/6;
                        receiptItem.ICReceiptItemCPChungNhaMay = receiptItemWoodQty * chiPhiChungNhaMay / tongM3TinhToanNhaMay;
                        objProductionCostsInfo.MMProductionCost6279FeeLR += receiptItemWoodQty * (chiPhi6279 / tongM3TinhToanNhaMay);
                        receiptItem.ICReceiptItemOtherFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiKhac;
                        receiptItem.ICReceiptItemOtherFee += receiptItem.ICReceiptItemCPChungNhaMay;
                        // CP HW, PLDG, Son
                        receiptItem.ICReceiptItemCPNguyenLieuKhac = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiXuatKhoKhac;
                        receiptItem.ICReceiptItemWoodFee = receiptItem.ICReceiptItemCPNguyenLieuGo;
                        receiptItem.ICReceiptItemHardwareFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiHW;
                        receiptItem.ICReceiptItemPaintFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiSon;
                        receiptItem.ICReceiptItemMaintainFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiBaoBi;
                        //receiptItem.ICReceiptItemOtherFee -= receiptItem.ICReceiptItemDepreciationFee;
                        //receiptItem.ICReceiptItemOtherFee -= receiptItem.ICReceiptItemElecFee;
                        // CP Khau Hao
                        receiptItem.ICReceiptItemDepreciationFee = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiKhauHao;
                        // CP Tien dien
                        receiptItem.ICReceiptItemElecFee = receiptItemWoodQty * (chiPhiTienDien / tongM3TinhToanNhaMay);
                        // Tổng giá BTP
                        receiptItem.ICReceiptItemCostBTP = receiptItem.ICReceiptItemCPNguyenLieuKhac
                            + receiptItem.ICReceiptItemCPNguyenLieuGo
                            + receiptItem.ICReceiptItemCPNCTT
                            + receiptItem.ICReceiptItemCPChung
                            + receiptItem.ICReceiptItemOtherFee;
                        //+ receiptItem.ICReceiptItemDepreciationFee
                        //+ receiptItem.ICReceiptItemElecFee;
                        receiptItem.ICReceiptItemTotalCost = receiptItem.ICReceiptItemCostBTP;
                        // Giá từng BTP
                        receiptItem.ICReceiptItemProductUnitCost = receiptItem.ICReceiptItemTotalCost / receiptItem.ICReceiptItemProductQty;

                        //receiptItem.ICReceiptItemWoodFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemDirectSalaryFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemGeneralFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemOtherFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemHardwareFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemPaintFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemMaintainFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemDepreciationFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemElecFee /= receiptItem.ICReceiptItemProductQty;

                        if (receiptItem.ICReceiptItemProductUnitCost > 0)
                        {
                            BOSApp.RoundByCurrency(receiptItem, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                            objReceiptItemsController.UpdateObject(receiptItem);
                            // Cập nhật lại giá xuất kho BTP
                            //objShipmentItemsInfo = objShipmentItemsController.GetShipmentItemByReceiptItemIDAndBatchProductID(receiptItem.Id, productPrice.FK_MMBatchProductID);
                            //if (objShipmentItemsInfo != null)
                            //{
                            //    objShipmentItemsInfo.ICShipmentItemTotalAmount = receiptItem.ICReceiptItemTotalCost;
                            //    objShipmentItemsInfo.ICShipmentItemTotalCost = receiptItem.ICReceiptItemTotalCost;
                            //    objShipmentItemsInfo.ICShipmentItemProductUnitPrice = receiptItem.ICReceiptItemProductUnitCost;
                            //    objShipmentItemsController.UpdateObject(objShipmentItemsInfo);
                            //}
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCostByOperationID", receiptItem.FK_ICProductID, receiptItem.ICReceiptItemProductSerialNo, receiptItem.ICReceiptItemProductUnitCost, objOperationsInfo.MMOperationID);
                            dbUtil.ExecuteNonQuery("UpdateInventoryCost_B1", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                            // Shipment
                            dbUtil.ExecuteNonQuery("UpdateInventoryCost_B2", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                            // Shipment Accounting
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B3", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B7", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B8", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //// Receipt Accounting
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B4", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B5", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            //dbUtil.ExecuteNonQuery("UpdateInventoryCost_B6", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                        }
                    }
                    //batchProductIDList.Add(productPrice.FK_MMBatchProductID);
                }
            }
            GetProductionCostItemByDate(objProductionCostsInfo.MMProductionCostFromDate,
                                                  objProductionCostsInfo.MMProductionCostToDate, true);

            BOSProgressBar.Close();
        }

        public void ExecCostOprationDG(bool isChange)
        {
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            string CPNCTTAccountNo = "6229";
            string CPChungTTAccountNo = "6278";
            decimal chiPhiNhanCongTT = GetDocumentEntryAmountByAccountNo(CPNCTTAccountNo);
            decimal chiPhiChungTT = GetDocumentEntryAmountByAccountNo(CPChungTTAccountNo)
                - GetDocumentEntryCreditAmountByAccountNo(CPChungTTAccountNo);
            decimal chiPhiChungNhaMay = GetDocumentEntryAmountByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay6279)
                    - GetDocumentEntryCreditAmountByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay6279);
            //+ GetDocumentEntryAmountByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay627A);
            if (chiPhiNhanCongTT == 0 || chiPhiChungTT == 0 || chiPhiChungNhaMay == 0)
            {
                if (MessageBox.Show("Có chi phí sản xuất không xác định được, bạn có muốn tiếp tục?", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    BOSProgressBar.Close();
                    return;
                }
            }
            decimal chiPhi6279 = chiPhiChungNhaMay;
            objProductionCostsInfo.MMProductionCost6279FeeDG = 0;
            decimal chiPhiKhauHao = GetDocumentEntryAmountByAccountNo("62782");
            decimal chiPhiTienDien = GetDocumentEntryAmountByAccountNo("62794");
            decimal chiPhiHW = 0;
            decimal chiPhiSon = 0;
            decimal chiPhiBaoBi = 0;

            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDDongGoiNo);

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> receiptItemList;
            List<ICReceiptItemsInfo> receiptItemList1;
            List<MMProductionCostIngredientCostDGsInfo> shipmentItemOtherList;
            List<MMProductionCostIngredientCostDGsInfo> shipmentItemOtherList1 = new List<MMProductionCostIngredientCostDGsInfo>();
            List<MMProductionCostIngredientCostDGsInfo> receiptItemOtherList;
            decimal chiPhiXuatKhoGo = 0;
            decimal chiPhiXuatKhoKhac = 0;
            decimal chiPhiKhac = 0;
            decimal TongM3TinhLSX = 0;
            decimal TongM3Tinh = 0;
            decimal tongM3TinhToanNhaMay = 0;
            ICShipmentItemsInfo objShipmentItemsInfo;
            BOSDbUtil dbUtil = new BOSDbUtil();
            receiptItemList = objReceiptItemsController.GetReceiptItemByOperationIDAndDate(objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);

            List<ICReceiptItemsInfo> receiptItems = objReceiptItemsController.GetReceiptItemByAllOperationIDAndDate(objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            TongM3Tinh = receiptItemList.Sum(e => e.ICReceiptItemWoodQty);
            tongM3TinhToanNhaMay = receiptItems.Sum(e => e.ICReceiptItemWoodQty);
            //TongM3Tinh = receiptItemList.Sum(e => e.ICReceiptItemProductHeight * e.ICReceiptItemProductWidth * e.ICReceiptItemProductLength * e.ICReceiptItemProductQty / 1000000000);
            //tongM3TinhToanNhaMay = receiptItems.Sum(e => e.ICReceiptItemProductHeight * e.ICReceiptItemProductWidth * e.ICReceiptItemProductLength * e.ICReceiptItemProductQty / 1000000000);

            MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            List<ICReceiptItemsInfo> receiptItemDetailList = new List<ICReceiptItemsInfo>();
            //List<int> batchProductIDList = new List<int>();
            dbUtil.ExecuteNonQuery("ResetInventoryCostByOperationID", objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            int percent = 0;

            List<MMProductionCostIngredientCostDGsInfo> xuatDG = new List<MMProductionCostIngredientCostDGsInfo>();
            ICShipmentItemsInfo itemShipment = null;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo = null;
            ICShipmentsController objShipmentController = new ICShipmentsController();
            List<int> batchProductIDList = entity.ProductionCostItemList.Select(item => item.FK_MMBatchProductID).Distinct().ToList();
            Dictionary<int, MMProductionCostIngredientCostDGsInfo> collection = new Dictionary<int, MMProductionCostIngredientCostDGsInfo>();
            List<ICShipmentItemsInfo> shipmentProductList;
            Dictionary<int, decimal> woodFeeCollection = new Dictionary<int, decimal>();
            Dictionary<int, decimal> woodQtyCollection = new Dictionary<int, decimal>();
            //foreach (MMProductionCostItemsInfo productPrice in entity.ProductionCostItemList)
            foreach (int batchProductID in batchProductIDList)
            {
                percent++;
                decimal pct = (percent * 100) / batchProductIDList.Count;
                BOSProgressBar.Start("Đang tính giá thành đóng gói  " + Math.Round(pct) + " %");

                //chiPhiXuatKhoKhac = 0;
                //shipmentItemOtherList = objShipmentItemsController.GetShipmentItemOtherBySomeCriteria(productPrice.FK_ICProductIDForBatch, productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);

                //foreach (ICShipmentItemsInfo shipmentItem in shipmentItemOtherList)
                //{
                //    chiPhiXuatKhoKhac += shipmentItem.ICShipmentItemTotalAmount;
                //}
                //if (!batchProductIDList.Contains(productPrice.FK_MMBatchProductID))
                {
                    //if (productPrice.FK_MMBatchProductID != 782)
                    //{
                    //    //continue;
                    //}
                    chiPhiKhac = 0;
                    foreach (MMProductionCostOtherFeesInfo item in entity.ProductionCostOtherFeesList)
                    {
                        if (item.FK_MMBatchProductID == batchProductID
                            && item.FK_MMOperationID == objOperationsInfo.MMOperationID)
                        {
                            chiPhiKhac += item.MMProductionCostOtherFeeTotalAmount;
                        }
                    }
                    //TongCPKhac += chiPhiKhac;
                    chiPhiXuatKhoKhac = 0;
                    //shipmentItemOtherList = objShipmentItemsController.GetShipmentItemOtherBySomeCriteria2(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    //shipmentItemOtherList.Clear();
                    //xuatDG = entity.ProductionCostIngredientCostListDG.Where(p => p.FK_MMBatchProductID == productPrice.FK_MMBatchProductID
                    //    && p.MMProductionCostIngredientCostDGReferenceType == ProductionCostIngredientCostReferenceType.XuatKho
                    //    && p.MMProductionCostIngredientCostDGReferenceNo.IndexOf("XKVT-") >= 0).ToList();
                    //foreach (MMProductionCostIngredientCostDGsInfo item in xuatDG)
                    //{
                    //    itemShipment = new ICShipmentItemsInfo();
                    //    BOSUtil.CopyObject(item, itemShipment);
                    //    objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.MMProductionCostIngredientCostDGProductSerialNo);
                    //    if (objProductSeriesInfo != null)
                    //    {
                    //        itemShipment.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                    //    }
                    //    itemShipment.FK_ICProductID = item.FK_ICProductID;
                    //    itemShipment.FK_MMBatchProductID = item.FK_MMBatchProductID;
                    //    itemShipment.ICShipmentItemProductQty = item.MMProductionCostIngredientCostDGProductQty;
                    //    itemShipment.ICShipmentItemProductUnitPrice = item.MMProductionCostIngredientCostDGProductUnitCost;
                    //    itemShipment.ICShipmentItemWoodQty = item.MMProductionCostIngredientCostDGProductWoodQty;
                    //    itemShipment.ICShipmentItemTotalAmount = item.MMProductionCostIngredientCostDGTotalCost;
                    //    itemShipment.ICShipmentNo = item.MMProductionCostIngredientCostDGReferenceNo;
                    //    itemShipment.MMBatchProductNo = item.MMProductionCostIngredientCostDGBatchProductNo;
                    //    itemShipment.MMOperationName = item.MMProductionCostIngredientCostDGOperationName;
                    //    itemShipment.ICMeasureUnitName = item.MMProductionCostIngredientCostDGMeasureUnitName;
                    //    itemShipment.ICStockName = item.MMProductionCostIngredientCostDGStockName;
                    //    itemShipment.ICProductNo = item.MMProductionCostIngredientCostDGProductNo;

                    //    ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByNo(item.MMProductionCostIngredientCostDGReferenceNo);
                    //    if (objShipmentInfo != null)
                    //    {
                    //        itemShipment.FK_ICShipmentID = objShipmentInfo.ICShipmentID;
                    //        itemShipment.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                    //        itemShipment.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                    //        itemShipment.ICShipmentType = objShipmentInfo.ICShipmentTypeCombo;
                    //    }
                    //    shipmentItemOtherList.Add(itemShipment);
                    //}

                    shipmentItemOtherList = entity.ProductionCostIngredientCostListDG.Where(item => item.FK_MMBatchProductID == batchProductID
                            && item.MMProductionCostIngredientCostDGReferenceTypeCombo == ShipmentType.MaterialShipment.ToString()).OrderBy(item => item.FK_ICProductSerieID).ToList();

                    receiptItemOtherList = entity.ProductionCostIngredientCostListDG.Where(item => item.FK_MMBatchProductID == batchProductID
                            && (item.MMProductionCostIngredientCostDGReferenceTypeCombo == ReceiptType.MaterialReturnReceipt.ToString()
                            || item.MMProductionCostIngredientCostDGReferenceTypeCombo == ReceiptType.MaterialRedundantReceipt.ToString())).ToList();

                    collection.Clear();
                    shipmentItemOtherList1.Clear();
                    if (receiptItemOtherList != null && receiptItemOtherList.Count > 0)
                    {
                        foreach (MMProductionCostIngredientCostDGsInfo receiptItem in receiptItemOtherList)
                        {
                            int key = receiptItem.FK_ICProductID;
                            if (!collection.Keys.Contains(key))
                                collection.Add(key, new MMProductionCostIngredientCostDGsInfo());
                            collection[key].MMProductionCostIngredientCostDGProductQty += receiptItem.MMProductionCostIngredientCostDGProductQty;
                            collection[key].MMProductionCostIngredientCostDGTotalCost += receiptItem.MMProductionCostIngredientCostDGTotalCost;
                        }
                    }

                    foreach (int key in collection.Keys)
                    {
                        if (collection[key].MMProductionCostIngredientCostDGProductQty != 0)
                            collection[key].MMProductionCostIngredientCostDGProductUnitCost = collection[key].MMProductionCostIngredientCostDGTotalCost / collection[key].MMProductionCostIngredientCostDGProductQty;
                    }

                    foreach (MMProductionCostIngredientCostDGsInfo shipmentItem in shipmentItemOtherList)
                    {
                        int key = shipmentItem.FK_ICProductID;
                        decimal remainQty = 0;
                        decimal value = 0;
                        if (collection.Keys.Contains(key) && (
                            collection[key].MMProductionCostIngredientCostDGProductQty > 0 ||
                            collection[key].MMProductionCostIngredientCostDGTotalCost > 0))
                        {
                            remainQty = Math.Min(shipmentItem.MMProductionCostIngredientCostDGProductQty, collection[key].MMProductionCostIngredientCostDGProductQty);
                            value = Math.Min(shipmentItem.MMProductionCostIngredientCostDGTotalCost, collection[key].MMProductionCostIngredientCostDGTotalCost);
                            collection[key].MMProductionCostIngredientCostDGProductQty -= remainQty;
                            collection[key].MMProductionCostIngredientCostDGTotalCost -= value;
                        }
                        if (shipmentItem.MMProductionCostIngredientCostDGProductQty != remainQty ||
                            shipmentItem.MMProductionCostIngredientCostDGTotalCost != value)
                        {
                            MMProductionCostIngredientCostDGsInfo shipmentItem1 = new MMProductionCostIngredientCostDGsInfo();
                            BOSUtil.CopyObject(shipmentItem, shipmentItem1);
                            shipmentItem1.MMProductionCostIngredientCostDGProductQty = shipmentItem.MMProductionCostIngredientCostDGProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostDGProductWoodQty = shipmentItem.MMProductionCostIngredientCostDGProductQty - remainQty;
                            shipmentItem1.MMProductionCostIngredientCostDGTotalCost -= value;
                            if (shipmentItem1.MMProductionCostIngredientCostDGProductQty != 0)
                                shipmentItem1.MMProductionCostIngredientCostDGProductUnitCost = shipmentItem1.MMProductionCostIngredientCostDGTotalCost / shipmentItem1.MMProductionCostIngredientCostDGProductQty;
                            shipmentItemOtherList1.Add(shipmentItem1);
                        }
                    }

                    chiPhiHW = 0;
                    chiPhiSon = 0;
                    chiPhiBaoBi = 0;
                    foreach (MMProductionCostIngredientCostDGsInfo shipmentItem in shipmentItemOtherList1)
                    {
                        chiPhiXuatKhoKhac += shipmentItem.MMProductionCostIngredientCostDGTotalCost;
                        ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(i => i.ICProductID == shipmentItem.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            if (objProductsInfo.ICProductType == ProductType.Hardware.ToString())
                            {
                                chiPhiHW += shipmentItem.MMProductionCostIngredientCostDGTotalCost;
                            }
                            else if (objProductsInfo.ICProductType == ProductType.IngredientPackaging.ToString())
                            {
                                chiPhiBaoBi += shipmentItem.MMProductionCostIngredientCostDGTotalCost;
                            }
                            else if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString())
                            {
                                chiPhiSon += shipmentItem.MMProductionCostIngredientCostDGTotalCost;
                            }
                            else
                            {
                                chiPhiHW += shipmentItem.MMProductionCostIngredientCostDGTotalCost;
                            }
                        }

                    }
                    //TongCPNguyenLieuKhac += chiPhiXuatKhoKhac;


                    // Trừ giá trị NLP nhập lại
                    //receiptItemList = objReceiptItemsController.GetReceiptItemVLPByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    //chiPhiXuatKhoKhac = chiPhiXuatKhoKhac - receiptItemList.Sum(e => e.ICReceiptItemTotalCost);
                    //receiptItemList.Clear();

                    //shipmentItemList = objShipmentItemsController.GetShipmentItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    shipmentItemList.Clear();
                    int index = 1;

                    xuatDG = entity.ProductionCostIngredientCostListDG.Where(p => p.FK_MMBatchProductID == batchProductID
                        && p.MMProductionCostIngredientCostDGReferenceType == ProductionCostIngredientCostReferenceType.XuatKho
                        && p.MMProductionCostIngredientCostDGReferenceNo.IndexOf("XKBTP-") >= 0).ToList();
                    foreach (MMProductionCostIngredientCostDGsInfo item in xuatDG)
                    {
                        itemShipment = new ICShipmentItemsInfo();
                        BOSUtil.CopyObject(item, itemShipment);
                        //objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.MMProductionCostIngredientCostDGProductSerialNo);
                        //if (objProductSeriesInfo != null)
                        //{
                        //    itemShipment.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                        //}
                        itemShipment.FK_ICProductID = item.FK_ICProductID;
                        itemShipment.FK_MMBatchProductID = item.FK_MMBatchProductID;
                        itemShipment.ICShipmentItemProductQty = item.MMProductionCostIngredientCostDGProductQty;
                        itemShipment.ICShipmentItemProductUnitPrice = item.MMProductionCostIngredientCostDGProductUnitCost;
                        itemShipment.ICShipmentItemWoodQty = item.MMProductionCostIngredientCostDGProductWoodQty;
                        itemShipment.ICShipmentItemTotalAmount = item.MMProductionCostIngredientCostDGTotalCost;
                        itemShipment.ICShipmentNo = item.MMProductionCostIngredientCostDGReferenceNo;
                        itemShipment.MMBatchProductNo = item.MMProductionCostIngredientCostDGBatchProductNo;
                        itemShipment.MMOperationName = item.MMProductionCostIngredientCostDGOperationName;
                        itemShipment.ICMeasureUnitName = item.MMProductionCostIngredientCostDGMeasureUnitName;
                        itemShipment.ICStockName = item.MMProductionCostIngredientCostDGStockName;
                        itemShipment.ICProductNo = item.MMProductionCostIngredientCostDGProductNo;

                        //ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)objShipmentController.GetObjectByNo(item.MMProductionCostIngredientCostDGReferenceNo);
                        //if (objShipmentInfo != null)
                        //{
                        //    itemShipment.FK_ICShipmentID = objShipmentInfo.ICShipmentID;
                        //    itemShipment.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                        //    itemShipment.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                        //    itemShipment.ICShipmentType = objShipmentInfo.ICShipmentTypeCombo;
                        //}
                        itemShipment.ICShipmentType = item.MMProductionCostIngredientCostDGReferenceTypeCombo;
                        itemShipment.Id = index;
                        index++;
                        shipmentItemList.Add(itemShipment);
                    }
                    //receiptItemList = objReceiptItemsController.GetReceiptItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    receiptItemList1 = receiptItemList.Where(item => item.FK_MMBatchProductID == batchProductID).ToList();
                    // Kiểm tra chi tiết theo thành phẩm
                    TongM3TinhLSX = receiptItemList1.Sum(e => e.ICReceiptItemWoodQty);
                    //List<ICShipmentItemsInfo> shipmentProductList = new List<ICShipmentItemsInfo>();

                    List<MMBatchProductProductionNormItemsInfo> bppniList = objBPPNIsController.GetBatchProductProductionNormItemsByBatchProductIDAndProductGroup(batchProductID, "SemiProduct");

                    woodFeeCollection.Clear();
                    woodQtyCollection.Clear();
                    foreach (ICReceiptItemsInfo receiptItem in receiptItemList1)
                    {
                        if (!woodFeeCollection.Keys.Contains(receiptItem.FK_ICProductSerieID))
                            woodFeeCollection.Add(receiptItem.FK_ICProductSerieID, 0);
                        if (!woodQtyCollection.Keys.Contains(receiptItem.FK_ICProductSerieID))
                            woodQtyCollection.Add(receiptItem.FK_ICProductSerieID, 0);
                        woodQtyCollection[receiptItem.FK_ICProductSerieID] += receiptItem.ICReceiptItemWoodQty;
                        //decimal receiptItemWoodQty = receiptItem.ICReceiptItemProductHeight *
                        //                        receiptItem.ICReceiptItemProductWidth * 
                        //                        receiptItem.ICReceiptItemProductLength *
                        //                        receiptItem.ICReceiptItemProductQty / 1000000000;

                        //decimal receiptItemWoodQty = receiptItem.ICReceiptItemWoodQty;
                        //// % m3 tinh thực nhập
                        //receiptItem.ICReceiptItemM3PercentCPChung = receiptItemWoodQty / TongM3Tinh;
                        //receiptItem.ICReceiptItemM3PercentCPGo = receiptItemWoodQty / TongM3TinhLSX;
                        //// CP NL Gỗ
                        //receiptItem.ICReceiptItemCPNguyenLieuGo = 0;
                        chiPhiXuatKhoGo = 0;
                        //ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)objReceiptsController.GetObjectByID(receiptItem.FK_ICReceiptID);
                        //List<MMBatchProductProductionNormItemsInfo> bppniList1 = objBPPNIsController.GetItemByParentIDForDongGoi(receiptItem.FK_MMBatchProductItemID, objReceiptsInfo.FK_MMBatchProductID, objReceiptsInfo.FK_MMOperationID, objReceiptsInfo.FK_ICProductID);
                        //List<MMBatchProductProductionNormItemsInfo> bppniList1 = bppniList.Where(pni => pni.MMBatchProductProductionNormItemParentID == receiptItem.FK_MMBatchProductProductionNormItemID).ToList();

                        List<MMBatchProductProductionNormItemsInfo> bppniList1 = bppniList.Where(pni =>
                                               bppniList.Where(pni1 => pni1.FK_MMBatchProductID == receiptItem.FK_MMBatchProductID
                                                   && pni1.FK_ICProductID == receiptItem.FK_ICProductID
                                                   && pni1.FK_MMBatchProductItemID == receiptItem.FK_MMBatchProductItemID)
                                                   .Any(pni2 => pni2.MMBatchProductProductionNormItemID == pni.MMBatchProductProductionNormItemParentID)).ToList();

                        foreach (MMBatchProductProductionNormItemsInfo bppni in bppniList1)
                        {
                            shipmentProductList = shipmentItemList.Where(x => x.FK_ICProductID == bppni.FK_ICProductID
                                                                            && x.ReceiptQty < x.ICShipmentItemProductQty).OrderBy(x => x.FK_ICProductSerieID).ToList();

                            if (shipmentProductList.Count > 0)
                            {
                                decimal tongSLXuat = shipmentProductList.Sum(x => x.ICShipmentItemProductQty - x.ReceiptQty);
                                decimal slChiTiet = (bppni.MMBatchProductProductionNormItemQuantity / bppni.MMBatchProductItemProductQty);
                                decimal slChiTietNhap = slChiTiet * receiptItem.ICReceiptItemProductQty;
                                //if (slChiTietNhap >= tongSLXuat)
                                //{
                                //    receiptItem.ICReceiptItemCPNguyenLieuGo += shipmentProductList.Sum(x => x.ICShipmentItemProductUnitPrice * (x.ICShipmentItemProductQty - x.ReceiptQty));
                                //    //if (slChiTietNhap - tongSLXuat > 0)
                                //    //{
                                //    //    objShipmentItemsInfo = shipmentProductList[0];
                                //    //    receiptItem.ICReceiptItemCPNguyenLieuGo += (slChiTietNhap - tongSLXuat) * objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
                                //    //}
                                //}
                                //else
                                //{

                                decimal remainQty = slChiTietNhap;
                                foreach (ICShipmentItemsInfo subItemShipment in shipmentProductList)
                                {
                                    if (remainQty > 0)
                                    {
                                        //if (subItemShipment.ICShipmentItemProductQty - remainQty >= 0)
                                        //{
                                        //    receiptItem.ICReceiptItemCPNguyenLieuGo += remainQty * subItemShipment.ICShipmentItemProductUnitPrice;
                                        //}
                                        //else
                                        //{
                                        //    decimal qty = Math.Min(remainQty, subItemShipment.ICShipmentItemProductQty);
                                        //    receiptItem.ICReceiptItemCPNguyenLieuGo += qty * subItemShipment.ICShipmentItemProductUnitPrice;
                                        //}
                                        //remainQty = remainQty - subItemShipment.ICShipmentItemProductQty;
                                        decimal qty = Math.Min(remainQty, subItemShipment.ICShipmentItemProductQty - subItemShipment.ReceiptQty);
                                        //receiptItem.ICReceiptItemCPNguyenLieuGo += qty * subItemShipment.ICShipmentItemProductUnitPrice;
                                        woodFeeCollection[receiptItem.FK_ICProductSerieID] += qty * subItemShipment.ICShipmentItemProductUnitPrice;
                                        remainQty = remainQty - qty;
                                        ICShipmentItemsInfo foundItem = shipmentItemList.FirstOrDefault(item => item.Id == subItemShipment.Id);
                                        if (foundItem != null)
                                            foundItem.ReceiptQty += qty;
                                    }
                                    else
                                    {
                                        break;
                                    }

                                }
                                //}
                            }
                            else
                            {
                                receiptItem.ICReceiptItemCPNguyenLieuGo += 0;
                            }
                        }
                    }
                    foreach (ICReceiptItemsInfo receiptItem in receiptItemList1)
                    {
                        decimal receiptItemWoodQty = receiptItem.ICReceiptItemWoodQty;
                        // % m3 tinh thực nhập
                        receiptItem.ICReceiptItemM3PercentCPChung = receiptItemWoodQty / TongM3Tinh;
                        receiptItem.ICReceiptItemM3PercentCPGo = receiptItemWoodQty / TongM3TinhLSX;
                        // CP NL Gỗ
                        receiptItem.ICReceiptItemCPNguyenLieuGo = 0;
                        if (woodFeeCollection.Keys.Contains(receiptItem.FK_ICProductSerieID))
                            receiptItem.ICReceiptItemCPNguyenLieuGo = (woodFeeCollection[receiptItem.FK_ICProductSerieID] / woodQtyCollection[receiptItem.FK_ICProductSerieID]) * receiptItemWoodQty;
                        // CP nhân công TT
                        receiptItem.ICReceiptItemCPNCTT = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiNhanCongTT;
                        receiptItem.ICReceiptItemDirectSalaryFee = receiptItem.ICReceiptItemCPNCTT;
                        // CP Chung
                        receiptItem.ICReceiptItemCPChung = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiChungTT;
                        receiptItem.ICReceiptItemGeneralFee = receiptItem.ICReceiptItemCPChung;
                        // CP Chung nhà máy
                        //receiptItem.ICReceiptItemCPChungNhaMay = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiChungNhaMay/6;
                        receiptItem.ICReceiptItemCPChungNhaMay = receiptItemWoodQty * chiPhiChungNhaMay / tongM3TinhToanNhaMay;
                        objProductionCostsInfo.MMProductionCost6279FeeDG += receiptItemWoodQty * (chiPhi6279 / tongM3TinhToanNhaMay);
                        receiptItem.ICReceiptItemOtherFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiKhac;
                        receiptItem.ICReceiptItemOtherFee += receiptItem.ICReceiptItemCPChungNhaMay;
                        // CP HW, PLDG, Son
                        receiptItem.ICReceiptItemCPNguyenLieuKhac = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiXuatKhoKhac;
                        receiptItem.ICReceiptItemWoodFee = receiptItem.ICReceiptItemCPNguyenLieuGo;
                        receiptItem.ICReceiptItemHardwareFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiHW;
                        receiptItem.ICReceiptItemPaintFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiSon;
                        receiptItem.ICReceiptItemMaintainFee = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiBaoBi;
                        //receiptItem.ICReceiptItemOtherFee -= receiptItem.ICReceiptItemDepreciationFee;
                        //receiptItem.ICReceiptItemOtherFee -= receiptItem.ICReceiptItemElecFee;
                        // CP Khau Hao
                        receiptItem.ICReceiptItemDepreciationFee = receiptItem.ICReceiptItemM3PercentCPChung * chiPhiKhauHao;
                        // CP Tien dien
                        receiptItem.ICReceiptItemElecFee = receiptItemWoodQty * (chiPhiTienDien / tongM3TinhToanNhaMay);

                        // Tổng giá BTP
                        receiptItem.ICReceiptItemCostBTP = receiptItem.ICReceiptItemCPNguyenLieuKhac
                            + receiptItem.ICReceiptItemCPNguyenLieuGo
                            + receiptItem.ICReceiptItemCPNCTT
                            + receiptItem.ICReceiptItemCPChung
                            + receiptItem.ICReceiptItemOtherFee;
                        //+ receiptItem.ICReceiptItemDepreciationFee
                        //+ receiptItem.ICReceiptItemElecFee;
                        receiptItem.ICReceiptItemTotalCost = receiptItem.ICReceiptItemCostBTP;
                        // Giá từng BTP
                        receiptItem.ICReceiptItemProductUnitCost = receiptItem.ICReceiptItemTotalCost / receiptItem.ICReceiptItemProductQty;

                        //receiptItem.ICReceiptItemWoodFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemDirectSalaryFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemGeneralFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemOtherFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemHardwareFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemPaintFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemMaintainFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemDepreciationFee /= receiptItem.ICReceiptItemProductQty;
                        //receiptItem.ICReceiptItemElecFee /= receiptItem.ICReceiptItemProductQty;

                        if (receiptItem.ICReceiptItemProductUnitCost > 0)
                        {
                            BOSApp.RoundByCurrency(receiptItem, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                            objReceiptItemsController.UpdateObject(receiptItem);
                            // Cập nhật lại giá xuất kho BTP
                            dbUtil.ExecuteNonQuery("UpdateInventoryCost_B1", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                            // Shipment
                            dbUtil.ExecuteNonQuery("UpdateInventoryCost_B2", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        }
                    }
                    //batchProductIDList.Add(productPrice.FK_MMBatchProductID);
                }
            }
            GetProductionCostItemByDate(objProductionCostsInfo.MMProductionCostFromDate,
                                                  objProductionCostsInfo.MMProductionCostToDate, true);


            BOSProgressBar.Close();
        }

        public void ExecCostOprationTP()
        {
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;

            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDThanhPhamNo);

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> receiptItemList = new List<ICReceiptItemsInfo>();
            decimal chiPhiXuatKhoGo = 0;
            decimal TongM3TinhLSX = 0;
            BOSDbUtil dbUtil = new BOSDbUtil();

            List<int> batchProductIDList = new List<int>();
            dbUtil.ExecuteNonQuery("ResetInventoryCostByOperationID", objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            foreach (MMProductionCostItemsInfo productPrice in entity.ProductionCostItemList)
            {
                if (!batchProductIDList.Contains(productPrice.FK_MMBatchProductID))
                {
                    chiPhiXuatKhoGo = 0;

                    shipmentItemList = objShipmentItemsController.GetShipmentItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    foreach (ICShipmentItemsInfo shipmentItem in shipmentItemList)
                    {
                        chiPhiXuatKhoGo += shipmentItem.ICShipmentItemTotalAmount;
                    }

                    receiptItemList = objReceiptItemsController.GetReceiptItemByBatchProductIDAndOperationIDAndDate(productPrice.FK_MMBatchProductID, objOperationsInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);

                    TongM3TinhLSX = receiptItemList.Sum(e => e.ICReceiptItemWoodQty);

                    foreach (ICReceiptItemsInfo receiptItem in receiptItemList)
                    {

                        decimal receiptItemWoodQty = receiptItem.ICReceiptItemWoodQty;
                        // % m3 tinh thực nhập
                        receiptItem.ICReceiptItemM3PercentCPGo = receiptItemWoodQty / TongM3TinhLSX;
                        // CP NL Gỗ
                        receiptItem.ICReceiptItemCPNguyenLieuGo = receiptItem.ICReceiptItemM3PercentCPGo * chiPhiXuatKhoGo;


                        // Tổng giá BTP
                        receiptItem.ICReceiptItemCostBTP = receiptItem.ICReceiptItemCPNguyenLieuGo;
                        receiptItem.ICReceiptItemTotalCost = receiptItem.ICReceiptItemCostBTP;
                        // Giá từng BTP
                        receiptItem.ICReceiptItemProductUnitCost = receiptItem.ICReceiptItemTotalCost / receiptItem.ICReceiptItemProductQty;

                        if (receiptItem.ICReceiptItemProductUnitCost > 0)
                        {
                            objReceiptItemsController.UpdateObject(receiptItem);
                            dbUtil.ExecuteNonQuery("UpdateInventoryCost_B1", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                            dbUtil.ExecuteNonQuery("UpdateInventoryCost_B2", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost, objProductionCostsInfo.MMProductionCostFromDate);
                        }
                    }
                    batchProductIDList.Add(productPrice.FK_MMBatchProductID);
                }
            }
        }

        public void ApplyProductPriceAllOperation()
        {
            ExecCostOprationPhoi(true);
            //ExecUpdateCostOprationPhoi();
            ExecCostOprationSC(true);
            //ExecUpdateCostOprationSC();
            ExecCostOprationTC(true);
            //ExecUpdateCostOprationTC();
            ExecCostOprationLR(true);
            //ExecUpdateCostOprationLR();
            ExecCostOprationSon(true);
            //ExecUpdateCostOprationSon();
            ExecCostOprationDG(true);
            //ExecUpdateCostOprationDG();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            //InitializeProductionCostIngredientCostsGridControls(false);

            TaiDuLieuButtonEdit.Enabled = false;
            TinhGiaAllButtonEdit.Enabled = false;
            CapNhatAllButtonEdit.Enabled = false;
        }

        public void RemoveProductionCostItemList()
        {
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            MMProductionCostItemsInfo objProductionCostItemsInfo = entity.ProductionCostItemList[entity.ProductionCostItemList.CurrentIndex];
            entity.ProductionCostItemList.RemoveSelectedRowObjectFromList();
        }
    }
}
