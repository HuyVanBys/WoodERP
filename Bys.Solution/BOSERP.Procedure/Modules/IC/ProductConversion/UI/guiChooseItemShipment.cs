using BOSCommon;
using BOSCommon.Constants;
using BOSCommon.Enums;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConversion
{
    public partial class guiChooseItemShipment : BOSERPScreen
    {
        #region Variables
        public List<MMAllocationPlanItemsInfo> SelectedObjects { get; set; }
        public BOSList<ICProductConversionItemsInfo> CurrentList { get; set; }
        public List<MMAllocationPlanItemsInfo> AllocationPlanItemList { get; set; }
        public BOSList<MMAllocationPlanItemsInfo> CurrentAllocationPlans { get; set; }
        public ICProductConversionItemsInfo CurrentObject { get; set; }
        public string Message = string.Empty;

        #endregion

        public guiChooseItemShipment(List<ICProductConversionItemsInfo> currentList)
        {
            InitializeComponent();
            CurrentList = new BOSList<ICProductConversionItemsInfo>();
            CurrentAllocationPlans = new BOSList<MMAllocationPlanItemsInfo>();
            CurrentList.AddRange(currentList);
            fld_dgcShowAllTargetProduct.InitGridControlDataSource(CurrentList);
            AllocationPlanItemList = new List<MMAllocationPlanItemsInfo>();
            GridView gridView = (GridView)fld_dgcShowAllTargetProduct.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            
        }

        private void guiShowAll_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            FocusAllocationPlanItem();
        }
        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        public void ChangeFocusAllocationPlanItem(ICProductConversionItemsInfo item)
        {
            //MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            //CurrentAllocationPlans = new BOSList<MMAllocationPlanItemsInfo>();
            //List<MMAllocationPlanItemsInfo> ListItem = AllocationPlanItemList.Where(o => o.FK_ICProductConversionItemID == item.ICProductConversionItemID).ToList();
            //if (ListItem == null || ListItem.Count == 0)
            //{
            //    ListItem = objAllocationPlanItemsController.GetItemForShipmentByProductConversion(item.FK_MMAllocationPlanID, item.FK_ICProductForBatchID, AllocationPlanItemGroup.Material.ToString());
            //    ListItem.ForEach(o => o.FK_ICProductConversionItemID = item.ICProductConversionItemID);
            //    //AllocationPlanItemList.AddRange(ListItem);
            //}
            //CurrentAllocationPlans.AddRange(ListItem);
            //fld_dgcMMAllocationPlanItemsGridControl.Screen = this;
            //fld_dgcMMAllocationPlanItemsGridControl.InvalidateDataSource(CurrentAllocationPlans);
        }
        public decimal GetSameShipmenttoatlQty(MMAllocationPlanItemsInfo item)
        {
            decimal result = 0;
            List<MMAllocationPlanItemsInfo> sameItem = CurrentAllocationPlans.Where(p => p.Id == item.Id).ToList();
            result = sameItem.Count() > 0 ? sameItem.Sum(o => o.MMAllocationPlanItemQty) : 0;
            return result;

        }
        public void FocusAllocationPlanItem()
        {
            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            CurrentAllocationPlans = new BOSList<MMAllocationPlanItemsInfo>();
            List<int> batchProductRefID = CurrentList.Select(o => o.FK_ICProductForBatchID).Distinct().ToList();
            List<int> allocationPlanID = CurrentList.Select(o => o.FK_MMAllocationPlanID).Distinct().ToList();
            List<MMAllocationPlanItemsInfo> ListItem = objAllocationPlanItemsController.GetItemForShipmentByProductConversion(allocationPlanID, batchProductRefID, AllocationPlanItemGroup.Material.ToString());
            CurrentAllocationPlans.AddRange(ListItem);
            fld_dgcMMAllocationPlanItemsGridControl.Screen = this;
            fld_dgcMMAllocationPlanItemsGridControl.InvalidateDataSource(CurrentAllocationPlans);

            //Reset data
            foreach (ICProductConversionItemsInfo item in CurrentList.Where(o => o.Selected).ToList())
            {
                List<MMAllocationPlanItemsInfo> sameItem = CurrentAllocationPlans.Where(p => p.FK_ICProductSerieID == item.FK_ICProductSerieID).ToList();
                if (sameItem.Count() > 0)
                {
                    item.ICProductConversionItemUsedQty = item.ICProductConversionItemProductQty - sameItem.Sum(o => o.MMAllocationPlanItemQty);
                    item.ICProductConversionItemWoodUsedQty = item.ICProductConversionItemWoodQty - sameItem.Sum(o => o.MMAllocationPlanItemWoodQty);
                }
                else
                {
                    item.ICProductConversionItemUsedQty = item.ICProductConversionItemProductQty;
                    item.ICProductConversionItemWoodUsedQty = item.ICProductConversionItemWoodQty;
                }
            }
            fld_dgcShowAllTargetProduct.RefreshDataSource();
        }
        public void AllocationConvertedSerial()
        {
            if (CurrentAllocationPlans.Where(o => o.Selected).Count() == 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn chi tiết cần phân bổ");
                return;
            }
            // reset giá trị phân bổ
            CurrentAllocationPlans.Where(o => o.Selected).ToList().ForEach(o => {
                o.FK_ICProductSerieID = 0;
                o.MMAllocationPlanItemProductSerialNo = string.Empty;
                o.MMAllocationPlanItemQty = 0;
                o.MMAllocationPlanItemWoodQty = 0;
                o.FK_ICStockID = 0;
                o.MMAllocationPlanItemUnitCost = 0;
                o.MMAllocationPlanItemHeight = 0;
                o.MMAllocationPlanItemLength = 0;
                o.MMAllocationPlanItemWidth = 0;
            });
            List<MMAllocationPlanItemsInfo> listAllocationPlan = CurrentAllocationPlans.Where(o => o.Selected).ToList();
            // phân bổ lần 1 ưu tiên cùng thành phẩm
            foreach (ICProductConversionItemsInfo item in CurrentList.Where(o => o.Selected).ToList())
            {
                List<MMAllocationPlanItemsInfo> sameItem = listAllocationPlan.Where(p => p.FK_MMAllocationPlanID == item.FK_MMAllocationPlanID
                                                                                       && p.FK_ICProductForBatchID == item.FK_ICProductForBatchID
                                                                                       && p.FK_ICProductID == item.FK_ICProductID
                                                                                       && p.FK_ICProductSerieID == 0
                                                                                       ).ToList();
                List<MMAllocationPlanItemsInfo> sameUsedItem = CurrentAllocationPlans.Where(p => p.FK_ICProductSerieID == item.FK_ICProductSerieID).ToList();
                decimal serialblock = item.ICProductConversionItemProductQty - (sameUsedItem.Count() > 0 ? sameUsedItem.Sum( o=> o.MMAllocationPlanItemQty) : 0) ;
                
                if (sameItem.Count() > 0)
                {
            
                    sameItem.ForEach(s =>
                    {
                        if (serialblock > 0)
                        {
                            s.MMAllocationPlanItemQty = Math.Min(serialblock, s.MMAllocationPlanItemNormQty);
                            serialblock = serialblock - s.MMAllocationPlanItemQty;
                            s.MMAllocationPlanItemWoodQty = Math.Round((item.ICProductConversionItemProductHeight * item.ICProductConversionItemProductWidth * item.ICProductConversionItemProductLength) > 0 ?
                            (s.MMAllocationPlanItemQty) / (item.ICProductConversionItemProductHeight * item.ICProductConversionItemProductWidth * item.ICProductConversionItemProductLength / 1000000000)
                            : 0, 0);
                            s.FK_ICProductSerieID = item.FK_ICProductSerieID;
                            s.MMAllocationPlanItemProductSerialNo = item.ICProductConversionItemProductSerialNo;
                            s.FK_ICStockID = item.FK_ICStockID;
                            s.MMAllocationPlanItemProductLotNo = item.ICProductConversionItemLotNo;
                            s.MMAllocationPlanItemHeight = item.ICProductConversionItemProductHeight;
                            s.MMAllocationPlanItemLength = item.ICProductConversionItemProductLength;
                            s.MMAllocationPlanItemWidth = item.ICProductConversionItemProductWidth;
                            s.MMAllocationPlanItemUnitCost = item.ICProductConversionItemUnitCost;
                        }
                        if (serialblock <= 0) return;
                    });
                }
            }
            // phân bổ cho thành phẩm khác nếu KL lô vẫn còn: phân bổ cho những chi tiết chưa phân bổ 
            List<MMAllocationPlanItemsInfo> listAllocationPlanRemain = CurrentAllocationPlans.Where(o => o.Selected 
                && o.FK_ICProductSerieID == 0 ).ToList();
            if (listAllocationPlanRemain.Count() > 0)
            {
                foreach (ICProductConversionItemsInfo item in CurrentList.Where(o => o.Selected).ToList())
                {
                    decimal serialblock = item.ICProductConversionItemProductQty;
                    decimal serialAlowcated = CurrentAllocationPlans.Where(o => o.Selected && o.FK_ICProductSerieID == item.FK_ICProductSerieID).Sum( a => a.MMAllocationPlanItemQty);
                    // Nếu đã phân bổ hết thì xử lý lô tiếp theo
                    if (serialblock <= serialAlowcated) continue;
                    decimal remainSerialBlock = serialblock - serialAlowcated;
                    List<MMAllocationPlanItemsInfo> sameItem = listAllocationPlanRemain.Where(p => p.FK_MMAllocationPlanID == item.FK_MMAllocationPlanID
                                                                                           && p.FK_ICProductID == item.FK_ICProductID
                                                                                           && p.FK_ICProductSerieID == 0).ToList();
                    

                    if (sameItem.Count() > 0)
                    {
                        if (remainSerialBlock <= 0) continue;
                            sameItem.ForEach(s =>
                        {
                            if (remainSerialBlock > 0)
                            {
                                s.MMAllocationPlanItemQty = Math.Min(remainSerialBlock, s.MMAllocationPlanItemNormQty);
                                remainSerialBlock = remainSerialBlock - s.MMAllocationPlanItemQty;
                                s.MMAllocationPlanItemWoodQty = Math.Round((item.ICProductConversionItemProductHeight * item.ICProductConversionItemProductWidth * item.ICProductConversionItemProductLength) > 0 ?
                                (s.MMAllocationPlanItemQty) / (item.ICProductConversionItemProductHeight * item.ICProductConversionItemProductWidth * item.ICProductConversionItemProductLength / 1000000000)
                                : 0, 0);
                                s.FK_ICProductSerieID = item.FK_ICProductSerieID;
                                s.MMAllocationPlanItemProductSerialNo = item.ICProductConversionItemProductSerialNo;
                                s.FK_ICStockID = item.FK_ICStockID;
                                s.MMAllocationPlanItemProductLotNo = item.ICProductConversionItemLotNo;
                                s.MMAllocationPlanItemHeight = item.ICProductConversionItemProductHeight;
                                s.MMAllocationPlanItemLength = item.ICProductConversionItemProductLength;
                                s.MMAllocationPlanItemWidth = item.ICProductConversionItemProductWidth;
                                s.MMAllocationPlanItemUnitCost = item.ICProductConversionItemUnitCost;
                                if (remainSerialBlock <= 0) return;
                            }
                        });
                    }
                }
            }
            // phân bổ cho thành phẩm khác nếu KL lô vẫn còn: phân bổ cho những chi tiết đã phân bổ và còn định mức
            List<MMAllocationPlanItemsInfo> listPlanRemain = CurrentAllocationPlans.Where(o => o.Selected
                && o.FK_ICProductSerieID != 0 && o.MMAllocationPlanItemQty < o.MMAllocationPlanItemNormQty).ToList();
            if (listPlanRemain.Count() > 0)
            {
                List<MMAllocationPlanItemsInfo> newItemList = new List<MMAllocationPlanItemsInfo>();
                foreach (ICProductConversionItemsInfo item in CurrentList.Where(o => o.Selected).ToList())
                {
                    decimal serialblock = item.ICProductConversionItemProductQty;
                    decimal serialAlowcated = CurrentAllocationPlans.Where(o => o.FK_ICProductSerieID == item.FK_ICProductSerieID).Sum(a => a.MMAllocationPlanItemQty);
                    // Nếu đã phân bổ hết thì xử lý lô tiếp theo
                    if (serialblock <= serialAlowcated) continue;
                    decimal remainSerialBlock = serialblock - serialAlowcated;
                    List<MMAllocationPlanItemsInfo> sameItem = listPlanRemain.Where(p => p.FK_MMAllocationPlanID == item.FK_MMAllocationPlanID
                                                                                           && p.FK_ICProductID == item.FK_ICProductID
                                                                                           && p.FK_ICProductSerieID != 0).ToList();


                    if (sameItem.Count() > 0)
                    {
                        if (remainSerialBlock <= 0) continue;
                        sameItem.ForEach(s =>
                        {
                            if (remainSerialBlock > 0)
                            {
                                MMAllocationPlanItemsInfo newItemSame = (MMAllocationPlanItemsInfo)s.Clone();

                                newItemSame.MMAllocationPlanItemQty = Math.Min(remainSerialBlock, newItemSame.MMAllocationPlanItemNormQty - newItemSame.MMAllocationPlanItemQty);
                                remainSerialBlock = remainSerialBlock - newItemSame.MMAllocationPlanItemQty;
                                newItemSame.MMAllocationPlanItemWoodQty = Math.Round((item.ICProductConversionItemProductHeight * item.ICProductConversionItemProductWidth * item.ICProductConversionItemProductLength) > 0 ?
                                (newItemSame.MMAllocationPlanItemQty) / (item.ICProductConversionItemProductHeight * item.ICProductConversionItemProductWidth * item.ICProductConversionItemProductLength / 1000000000)
                                : 0, 0);
                                newItemSame.FK_ICProductSerieID = item.FK_ICProductSerieID;
                                newItemSame.MMAllocationPlanItemProductSerialNo = item.ICProductConversionItemProductSerialNo;
                                newItemSame.FK_ICStockID = item.FK_ICStockID;
                                newItemSame.MMAllocationPlanItemProductLotNo = item.ICProductConversionItemLotNo;
                                newItemSame.MMAllocationPlanItemHeight = item.ICProductConversionItemProductHeight;
                                newItemSame.MMAllocationPlanItemLength = item.ICProductConversionItemProductLength;
                                newItemSame.MMAllocationPlanItemWidth = item.ICProductConversionItemProductWidth;
                                newItemSame.MMAllocationPlanItemUnitCost = item.ICProductConversionItemUnitCost;
                                newItemList.Add(newItemSame);
                                if (remainSerialBlock <= 0) return;
                            }
                        });
                    }
                }
                if (newItemList.Count() > 0) CurrentAllocationPlans.AddRange(newItemList);

            }
            foreach (ICProductConversionItemsInfo item in CurrentList)
            {
                List<MMAllocationPlanItemsInfo> sameItem = CurrentAllocationPlans.Where(p => p.FK_ICProductSerieID == item.FK_ICProductSerieID).ToList();
                if (sameItem.Count() > 0)
                {
                    item.ICProductConversionItemUsedQty = item.ICProductConversionItemProductQty - sameItem.Sum(o => o.MMAllocationPlanItemQty);
                    item.ICProductConversionItemWoodUsedQty = item.ICProductConversionItemWoodQty - sameItem.Sum(o => o.MMAllocationPlanItemWoodQty);
                }
                else
                {
                    item.ICProductConversionItemUsedQty = item.ICProductConversionItemProductQty ;
                    item.ICProductConversionItemWoodUsedQty = item.ICProductConversionItemWoodQty ;
                }
            }
            fld_dgcShowAllTargetProduct.RefreshDataSource();
            fld_dgcMMAllocationPlanItemsGridControl.InvalidateDataSource(CurrentAllocationPlans);
        }
        private void ValidateAllocationPlan(ICProductConversionItemsInfo item)
        {
            if (item.ICProductConversionItemProductQty <= CurrentAllocationPlans.Sum(o => o.MMAllocationPlanItemQty))
            {
                //Message += string.Format("Sản phẩm {0} không đủ ")
            }    
        }

        private void fld_btnCopyProduct_Click_1(object sender, EventArgs e)
        {
            AllocationConvertedSerial();
            //ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            //List<ICMeasureUnitsInfo> measureUnitList = objMeasureUnitsController.GetAllAliveMeasureUnit();
            ////if (CurrentObject.Validate)
            ////{
            ////    MessageBox.Show("Nguyên liệu đã được đồng bộ", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////    return;
            ////}    
            //List<MMAllocationPlanItemsInfo> listAllocationPlan = CurrentAllocationPlans.Where(o => o.Selected).ToList();
            //if (listAllocationPlan != null && listAllocationPlan.Count() > 0)
            //{
            //    decimal remainPlanQty = CurrentList.Where(o => o.FK_MMAllocationPlanID == CurrentObject.FK_MMAllocationPlanID && CurrentObject.ICProductConversionItemID != o.ICProductConversionItemID && o.Validate).Sum(o => o.ICProductConversionItemProductQty);
            //    if (CurrentObject.ICProductConversionItemProductQty > listAllocationPlan.Sum(o => o.MMAllocationPlanItemQty) - remainPlanQty)
            //    {
            //        MessageBox.Show("Không đủ số lượng để xuất kho", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    listAllocationPlan.ForEach(o =>
            //    {
            //        o.MMAllocationPlanItemProductSerialNo = CurrentObject.ICProductConversionItemProductSerialNo;
            //        o.FK_ICProductSerieID = CurrentObject.FK_ICProductSerieID;
            //        o.MMAllocationPlanItemProductLotNo = CurrentObject.ICProductConversionItemLotNo;
            //        o.MMAllocationPlanItemHeight = CurrentObject.ICProductConversionItemProductHeight;
            //        o.MMAllocationPlanItemLength = CurrentObject.ICProductConversionItemProductLength;
            //        o.MMAllocationPlanItemWidth = CurrentObject.ICProductConversionItemProductWidth;
            //        //SynItemQty(o);
            //    });
            //    decimal sameItemQty = 0;
            //    decimal rateWithTotalQty = 0;
            //    decimal allocationQty = 0;
            //    decimal allocationWoodQty = 0;
            //    decimal totalAllocationQty = CurrentObject.ICProductConversionItemProductQty;
            //    decimal totalAllocationWoodQty = CurrentObject.ICProductConversionItemWoodQty;
            //    int productID = listAllocationPlan.FirstOrDefault().FK_ICProductID;
            //    List<MMAllocationPlanItemsInfo> listRemainQty = GetRemainQtyForProductConversion(productID, listAllocationPlan.Select(o => o.Id).ToList(), out remainPlanQty);
            //    decimal totalNormQty = listRemainQty.Sum(o => o.MMAllocationPlanItemRemainQty);
            //    listAllocationPlan.ForEach(o =>
            //    {
            //        remainPlanQty = listRemainQty.Where(p => p.Id == o.Id).Select(p => p.MMAllocationPlanItemRemainQty).FirstOrDefault();
            //        sameItemQty = listAllocationPlan.Where(si => si.Id == o.Id && o.VirtualID != si.VirtualID).Sum(si => si.MMAllocationPlanItemQty);
            //        rateWithTotalQty = totalNormQty == 0 ? 0 : (remainPlanQty - sameItemQty) / totalNormQty;
            //        o.MMAllocationPlanItemQty = (rateWithTotalQty * totalAllocationQty);
            //        o.MMAllocationPlanItemWoodQty = rateWithTotalQty * totalAllocationWoodQty;
            //        o.MMAllocationPlanItemWoodQty = o.MMAllocationPlanItemWoodQty < 0 ? 0 : o.MMAllocationPlanItemWoodQty;
            //        o.MMAllocationPlanItemWoodQty = Math.Round(o.MMAllocationPlanItemWoodQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
            //        //roundNum = measureUnitList.Where(u => u.ICMeasureUnitID == o.FK_ICMeasureUnitID).Select(u => u.ICMeasureUnitRoundNum).FirstOrDefault();
            //        //o.ICShipmentItemProductQty = Math.Round(o.ICShipmentItemProductQty, roundNum, MidpointRounding.AwayFromZero);
            //        o.MMAllocationPlanItemQty = o.MMAllocationPlanItemQty < 0 ? 0 : o.MMAllocationPlanItemQty;
            //        o.MMAllocationPlanItemQty = Math.Round(o.MMAllocationPlanItemQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
            //        allocationQty += o.MMAllocationPlanItemQty;
            //        allocationWoodQty += o.MMAllocationPlanItemWoodQty;
            //    });
            //    allocationQty = Math.Round(allocationQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
            //    allocationWoodQty = Math.Round(allocationWoodQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
            //    decimal calOperation = totalAllocationQty - allocationQty >= 0 ? 1 : -1;
            //    decimal calWoodOperation = totalAllocationWoodQty - allocationWoodQty >= 0 ? 1 : -1;
            //    totalAllocationQty = Math.Abs(totalAllocationQty - allocationQty);
            //    totalAllocationWoodQty = Math.Abs(totalAllocationWoodQty - allocationWoodQty);
            //    allocationQty = 0;
            //    allocationWoodQty = 0;
            //    decimal oldQty = 0;
            //    decimal oldWoodQty = 0;
            //    int roundNum = 0;
            //    listAllocationPlan.ForEach(o =>
            //    {
            //        if (totalAllocationQty == 0 && totalAllocationWoodQty == 0)
            //            return;

            //        if (totalAllocationQty > 0)
            //        {
            //            remainPlanQty = listRemainQty.Where(p => p.Id == o.Id).Select(p => p.MMAllocationPlanItemRemainQty).FirstOrDefault();
            //            sameItemQty = listAllocationPlan.Where(si => si.Id == o.Id && o.VirtualID != si.VirtualID).Sum(si => si.MMAllocationPlanItemQty);
            //            rateWithTotalQty = totalNormQty == 0 ? 0 : (remainPlanQty - sameItemQty) / totalNormQty;
            //            oldQty = o.MMAllocationPlanItemQty;
            //            roundNum = measureUnitList.Where(u => u.ICMeasureUnitID == o.FK_ICMeasureUnitID).Select(u => u.ICMeasureUnitRoundNum).FirstOrDefault();
            //            o.MMAllocationPlanItemQty = o.MMAllocationPlanItemQty + calOperation * totalAllocationQty;
            //            o.MMAllocationPlanItemQty = o.MMAllocationPlanItemQty  > (remainPlanQty - sameItemQty)
            //                                            ? (remainPlanQty - sameItemQty) : o.MMAllocationPlanItemQty;
            //            o.MMAllocationPlanItemQty = o.MMAllocationPlanItemQty < 0 ? 0 : o.MMAllocationPlanItemQty;
            //            o.MMAllocationPlanItemQty = Math.Round(o.MMAllocationPlanItemQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
            //            totalAllocationQty = totalAllocationQty - Math.Abs((o.MMAllocationPlanItemQty - oldQty));
            //        }
            //        if (totalAllocationWoodQty > 0)
            //        {
            //            oldWoodQty = o.MMAllocationPlanItemWoodQty;
            //            o.MMAllocationPlanItemWoodQty = o.MMAllocationPlanItemWoodQty + calWoodOperation * totalAllocationWoodQty;
            //            o.MMAllocationPlanItemWoodQty = o.MMAllocationPlanItemWoodQty < 0 ? 0 : o.MMAllocationPlanItemWoodQty;
            //            o.MMAllocationPlanItemWoodQty = Math.Round(o.MMAllocationPlanItemWoodQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
            //            totalAllocationWoodQty = totalAllocationWoodQty - Math.Abs((o.MMAllocationPlanItemWoodQty - oldWoodQty));
            //        }
            //    });
            //    AllocationPlanItemList.AddRange(listAllocationPlan);
            //    CurrentObject.Validate = true;
            //    CurrentObject.Selected = true;
            //}
        }
        private List<MMAllocationPlanItemsInfo> GetRemainQtyForProductConversion(int productID, List<int> planItemRef, out decimal remainPlanQty)
        {
            var planItemIds = new List<int>();
            var shipmentItemIds = new List<int>();

            List<MMAllocationPlanItemsInfo> listRemainQty = (new MMAllocationPlanItemsController()).GetRemainQtyForProductConversion(planItemRef);
            remainPlanQty = listRemainQty.Sum(o => o.MMAllocationPlanItemRemainQty);
            return listRemainQty;
        }

        private void fld_btnAllocation_Click(object sender, EventArgs e)
        {
            AllocationConvertedSerial();
        }

        private void fld_btnLoad_Click(object sender, EventArgs e)
        {
            FocusAllocationPlanItem();
        }

        private void fld_btnChoose_Click(object sender, EventArgs e)
        {
            SelectedObjects = CurrentAllocationPlans.Where(o => o.FK_ICProductSerieID > 0).ToList();
   
            if (SelectedObjects.Count == 0)
            {
                BOSApp.ShowMessage("Chưa phân bổ cho kế hoạch");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}