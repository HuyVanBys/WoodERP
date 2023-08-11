using BOSCommon;
using BOSComponent;
using BOSERP.Modules.BatchProduct.Localization;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList.Nodes;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct
{
    public partial class guiChangeToNeedMerge : BOSERPScreen
    {

        public BOSList<MMBatchProductItemsInfo> SelectBatchProductItemList;
        List<MMBatchProductProductionNormItemsViewInfo> dsSemi;
        List<MMBatchProductProductionNormItemMeterialsInfo> dsMaterial;
        List<MMBatchProductProductionNormItemProcesssInfo> dsProcess;
        List<MMBatchProductProductionNormItemMeterialsInfo> dsOtherMaterial;
        private GridControlHelper GridControlMaterialHelper;
        private GridControlHelper GridControlHWHelper;
        private GridControlHelper GridControlPaintHelper;
        private GridControlHelper GridControlPackHelper;
        private GridControlHelper GridControlGenMaterialHelper;
        string applyType = ProductType.Material.ToString();
        public List<string> TypeList { get; set; }
        public bool IsMerge { get; set; }
        public bool isChangeBOM { get; set; }
        public guiChangeToNeedMerge()
        {
            InitializeComponent();
            SelectBatchProductItemList = new BOSList<MMBatchProductItemsInfo>();
            dsSemi = new List<MMBatchProductProductionNormItemsViewInfo>();
            dsMaterial = new List<MMBatchProductProductionNormItemMeterialsInfo>();
            dsProcess = new List<MMBatchProductProductionNormItemProcesssInfo>();
            IsMerge = false;
            isChangeBOM = false;
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void guiChooseProposalItem_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            InitBatchProductData();
            if (fld_tabVProductionNorm != null)
                foreach (XtraTabPage page in fld_tabVProductionNorm.TabPages)
                    page.PageVisible = false;
            BatchProductEntities entity = (BatchProductEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            if (SelectBatchProductItemList.Count() > 0)
            {
                fld_lkeFK_ICProductID1.EditValue = SelectBatchProductItemList[0].MMBatchProductItemID;
                fld_lkeFK_ICProductID1.Refresh();
                fld_lkeMMProductionNormID.EditValue = SelectBatchProductItemList[0].FK_MMProductionNormID;
                fld_lkeMMProductionNormID.Refresh();
                TypeList.ForEach(s =>
                {
                    EnableViewNormType(s, true);
                });
                fld_txtProductQty.EditValue = SelectBatchProductItemList[0].MMBatchProductItemProductQty;
            }
            fld_txtProductQty.Enabled = !isChangeBOM; fld_lkeMMProductionNormID.Enabled = isChangeBOM;
            fld_lkeApplyEmployeeID.EditValue = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            fld_lkeRequireApplyName.EditValue = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            fld_dteApplyDate.EditValue = DateTime.Now;
        }
        public void EnableViewNormType(string type, bool visible)
        {
            if (fld_tabVProductionNorm != null)
                foreach (XtraTabPage page in fld_tabVProductionNorm.TabPages)
                {
                    if (page.Name == "fld_tabVMaterial" && type == ProductType.SemiProduct.ToString())
                    {
                        page.PageVisible = visible;
                        if (fld_dgcViewChangeMaterialGridControl != null)
                        {
                            GridView gridView = (GridView)fld_dgcViewChangeMaterialGridControl.MainView;
                            GridControlMaterialHelper = new GridControlHelper(gridView);
                        }
                    }
                    else if (page.Name == "fld_tabVHardware" && type == ProductType.Hardware.ToString())
                    {
                        page.PageVisible = visible;
                        if (fld_dgcViewChangeHWGridControl != null)
                        {
                            GridView gridView = (GridView)fld_dgcViewChangeHWGridControl.MainView;
                            GridControlHWHelper = new GridControlHelper(gridView);
                        }
                    }
                    else if (page.Name == "fld_tabVPaint" && type == ProductType.IngredientPaint.ToString())
                    {
                        page.PageVisible = visible;
                        if (fld_dgcViewChangePaintGridControl != null)
                        {
                            GridView gridView = (GridView)fld_dgcViewChangePaintGridControl.MainView;
                            GridControlPaintHelper = new GridControlHelper(gridView);
                        }
                    }
                    else if (page.Name == "fld_tabVPackaging" && type == ProductType.IngredientPackaging.ToString())
                    {
                        page.PageVisible = visible;
                        if (fld_dgcViewChangePackGridControl != null)
                        {
                            GridView gridView = (GridView)fld_dgcViewChangePackGridControl.MainView;
                            GridControlPackHelper = new GridControlHelper(gridView);
                        }
                    }
                    else if (page.Name == "fld_tabVGeneral" && type == ProductType.GeneralMaterial.ToString())
                    {
                        page.PageVisible = visible;
                        if (fld_dgcViewChangeOtherMaterialGridControl != null)
                        {
                            GridView gridView = (GridView)fld_dgcViewChangeOtherMaterialGridControl.MainView;
                            GridControlGenMaterialHelper = new GridControlHelper(gridView);
                        }
                    }
                }
        }
        public bool CheckProductionPlanningQty(int MMBatchProductItemID, decimal newQty)
        {
            bool result = true;
            MMBatchProductItemsInfo reult = (new MMBatchProductItemsController()).GetRemainProductionPlanningByBatchItem(MMBatchProductItemID);
            if (reult != null && reult.MMBatchProductItemRemainQty < newQty && reult.FK_ARProductionPlanningItemID > 0)
            {
                BOSApp.ShowMessage("Số lượng thay đổi lớn hơn SL còn lại có thể kế hoạch."
                   + Environment.NewLine + " Kế hoạch: " + reult.ARProductionPlanningNo
                   + (!string.IsNullOrEmpty(reult.MMBatchProductNo) ? Environment.NewLine + " SL đã làm lệnh: " + reult.MMBatchProductItemProductQty.ToString("N2") + ", LSX: " + reult.MMBatchProductNo : string.Empty)
                   + Environment.NewLine + " SL kế hoạch còn lại: " + reult.MMBatchProductItemRemainQty.ToString("N2"));
                result = false;
            }
            return result;
        }
        public bool CheckApplyBOMStatus(MMProductionNormsInfo bom, string Type)
        {
            bool result = true;
            if (bom != null)
            {
                if (Type == ProductType.SemiProduct.ToString() && bom.MMProductionNormWoodStatus != Status.Approved.ToString()) result = false;
                else if (Type == ProductType.Hardware.ToString() && bom.MMProductionNormHardwareStatus != Status.Approved.ToString()) result = false;
                else if (Type == ProductType.IngredientPaint.ToString() && bom.MMProductionNormPaintStatus != Status.Approved.ToString()) result = false;
                else if (Type == ProductType.IngredientPackaging.ToString() && bom.MMProductionNormPackingMaterialStatus != Status.Approved.ToString()) result = false;
                else if (Type == ProductType.GeneralMaterial.ToString() && bom.MMProductionNormGeneralMaterialStatus != Status.Approved.ToString()) result = false;
            }

            return result;
        }
        public void ApplySemiProduct(List<MMBatchProductProductionNormItemsViewInfo> itemNote, List<MMBatchProductProductionNormItemMeterialsInfo> material, string type)
        {
            int RequireApplyID = 0;
            if (fld_lkeRequireApplyName.EditValue != null)
                RequireApplyID = int.Parse(fld_lkeRequireApplyName.EditValue.ToString());
            if (RequireApplyID == 0)
            {
                BOSApp.ShowMessage("Người yêu cầu thay đổi không thể trống!");
                return;
            }

            if (BOSApp.ShowMessageYesNo("Bạn chắc chắn muốn thay đổi định mức mới?") == DialogResult.No) return;
            #region Check BOM Status
            int norm = itemNote != null && itemNote.Count() > 0 ? itemNote.Where(n => n.FK_MMProductionNormID > 0).Select(n => n.FK_MMProductionNormID).FirstOrDefault() :
                                    ((material != null && material.Count() > 0) ? material.Where(n => n.FK_MMProductionNormID > 0).Select(n => n.FK_MMProductionNormID).FirstOrDefault() : 0);

            decimal qty = itemNote != null && itemNote.Count() > 0 ? itemNote.Where(n => n.MMBatchProductProductionNormItemApplyQuantity > 0
                        //&& n.FK_ICProductForBatchID == SelectBatchProductItemList[0].FK_ICProductID
                        && n.FK_ICProductID == SelectBatchProductItemList[0].FK_ICProductID).Select(n => n.MMBatchProductProductionNormItemApplyQuantity).FirstOrDefault() : 0;
            if (!isChangeBOM && fld_txtProductQty.EditValue != null)
            {
                decimal reqQty = decimal.Parse(fld_txtProductQty.EditValue.ToString());
                if (reqQty != qty && type == "All")
                {
                    if (BOSApp.ShowMessageYesNo("Số lượng có thể thay đổi: " + qty + " . Bạn có muốn thay đổi không?") == DialogResult.No) return;
                    fld_txtProductQty.EditValue = qty;
                }
            }
            if (norm == 0) return;
            MMProductionNormsInfo bom = (MMProductionNormsInfo)(new MMProductionNormsController()).GetObjectByID(norm);
            BatchProductEntities entity = (BatchProductEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            MMBatchProductsInfo mainObject = (MMBatchProductsInfo)entity.MainObject;
            string mess = string.Empty;
            bool checkApprove = true;
            bool checkApproveBOM = true;
            bool checkHWApprove = true;
            bool checkPaintApprove = true;
            bool checkPackApprove = true;
            bool checkGeneralApprove = true;
            TypeList.ForEach(s =>
            {
                if ((s == type || type == "All") && !CheckApplyBOMStatus(bom, s))
                {
                    checkApprove = false;
                    if (s == ProductType.SemiProduct.ToString())
                    {
                        checkApproveBOM = false;
                        mess += Environment.NewLine + "Bán thành phẩm";
                    }
                    else if (s == ProductType.Hardware.ToString())
                    {
                        mess += Environment.NewLine + "- Hardware";
                        checkHWApprove = false;
                    }
                    else if (s == ProductType.IngredientPaint.ToString())
                    {
                        mess += Environment.NewLine + "- Sơn";
                        checkPaintApprove = false;
                    }
                    else if (s == ProductType.IngredientPackaging.ToString())
                    {
                        mess += Environment.NewLine + "- PLĐG";
                        checkPackApprove = false;
                    }
                    else if (s == ProductType.GeneralMaterial.ToString())
                    {
                        mess += Environment.NewLine + "- Vật tư SX chung";
                        checkGeneralApprove = false;
                    }
                }
            });
            if (!checkApproveBOM) { BOSApp.ShowMessage("Bảng định mức chưa duyệt: Bán thành phẩm, bạn không thể tiếp tục!"); return; }
            if (!checkApprove)
                if (BOSApp.ShowMessageYesNo("Bảng định mức chưa duyệt nội dung: " + mess + Environment.NewLine + "Chỉ áp dụng thay đổi cho nội dung đã duyệt, bạn có muốn tiếp tục không?") == DialogResult.No) return;
            #endregion
            #region Check apply Data
            List<MMBatchProductProductionNormItemMeterialsInfo> focusMaterialList = new List<MMBatchProductProductionNormItemMeterialsInfo>();
            // Maretial
            if (type == "All")
                focusMaterialList = dsMaterial.Where(m =>
                            itemNote.Any(n => n.MMBatchProductProductionNormItemParentOrderName == m.MMBatchProductProductionNormItemParentOrderName
                            && n.MMBatchProductProductionNormItemParentNo == m.MMBatchProductProductionNormItemParentNo)).ToList();
            else if (type == ProductType.Material.ToString())
                focusMaterialList = material;
            if (mainObject.MMBatchProductWoodStatus == Status.Approved.ToString())
                if (focusMaterialList.Count() > 0 && !CheckApplyMaterial(focusMaterialList, ProductType.Material.ToString()))
                {
                    BOSDisposeUtility.DisposeAll(focusMaterialList, 0, GCCollectionMode.Forced);
                    return;
                }

            // HW
            List<MMBatchProductProductionNormItemMeterialsInfo> focusHWList = new List<MMBatchProductProductionNormItemMeterialsInfo>();
            if (type == "All")
                focusHWList = dsOtherMaterial.Where(m =>
                    itemNote.Any(n => n.MMBatchProductProductionNormItemParentOrderName == m.MMBatchProductProductionNormItemParentOrderName
                    && n.MMBatchProductProductionNormItemParentNo == m.MMBatchProductProductionNormItemParentNo
                    && m.MMBatchProductProductionNormItemGroup == ProductType.Hardware.ToString())).ToList();
            else if (type == ProductType.Hardware.ToString())
                focusHWList = material;

            if (mainObject.MMBatchProductHWStatus == Status.Approved.ToString())
                if (focusHWList.Count() > 0 && checkHWApprove && !CheckApplyMaterial(focusHWList, ProductType.Hardware.ToString()))
                {
                    BOSDisposeUtility.DisposeAll(focusHWList, 0, GCCollectionMode.Forced);
                    return;
                }
            // Paint
            List<MMBatchProductProductionNormItemMeterialsInfo> focusPaintList = new List<MMBatchProductProductionNormItemMeterialsInfo>();
            if (type == "All")
                focusPaintList = dsOtherMaterial.Where(m =>
                     itemNote.Any(n => n.MMBatchProductProductionNormItemParentOrderName == m.MMBatchProductProductionNormItemParentOrderName
                     && n.MMBatchProductProductionNormItemParentNo == m.MMBatchProductProductionNormItemParentNo
                     && m.MMBatchProductProductionNormItemGroup == ProductType.IngredientPaint.ToString())).ToList();
            else if (type == ProductType.IngredientPaint.ToString())
                focusPaintList = material;

            if (mainObject.MMBatchProductPaintStatus == Status.Approved.ToString())
                if (focusPaintList.Count() > 0 && checkPaintApprove && !CheckApplyMaterial(focusPaintList, ProductType.IngredientPaint.ToString()))
                {
                    BOSDisposeUtility.DisposeAll(focusPaintList, 0, GCCollectionMode.Forced);
                    return;
                }
            // Pack
            List<MMBatchProductProductionNormItemMeterialsInfo> focusPackList = new List<MMBatchProductProductionNormItemMeterialsInfo>();
            if (type == "All")
                focusPackList = dsOtherMaterial.Where(m =>
                    itemNote.Any(n => n.MMBatchProductProductionNormItemParentOrderName == m.MMBatchProductProductionNormItemParentOrderName
                    && n.MMBatchProductProductionNormItemParentNo == m.MMBatchProductProductionNormItemParentNo
                    && m.MMBatchProductProductionNormItemGroup == ProductType.IngredientPackaging.ToString())).ToList();
            else if (type == ProductType.IngredientPackaging.ToString())
                focusPackList = material;

            if (mainObject.MMBatchProductPackagingStatus == Status.Approved.ToString())
                if (focusPackList.Count() > 0 && checkPackApprove && !CheckApplyMaterial(focusPackList, ProductType.IngredientPackaging.ToString()))
                {
                    BOSDisposeUtility.DisposeAll(focusPackList, 0, GCCollectionMode.Forced);
                    return;
                }
            // General
            List<MMBatchProductProductionNormItemMeterialsInfo> focusGeneralList = new List<MMBatchProductProductionNormItemMeterialsInfo>();

            if (type == "All")
                focusGeneralList = dsOtherMaterial.Where(m =>
                    itemNote.Any(n => n.MMBatchProductProductionNormItemParentOrderName == m.MMBatchProductProductionNormItemParentOrderName
                    && n.MMBatchProductProductionNormItemParentNo == m.MMBatchProductProductionNormItemParentNo
                    && m.MMBatchProductProductionNormItemGroup == ProductType.GeneralMaterial.ToString())).ToList();
            else if (type == ProductType.GeneralMaterial.ToString())
                focusGeneralList = material;

            if (mainObject.MMBatchProductGeneralMaterialStatus == Status.Approved.ToString())
                if (focusGeneralList.Count() > 0 && checkGeneralApprove && !CheckApplyMaterial(focusGeneralList, ProductType.GeneralMaterial.ToString()))
                {
                    BOSDisposeUtility.DisposeAll(focusGeneralList, 0, GCCollectionMode.Forced);
                    return;
                }

            //////////////////////////////////////////////////////
            List<MMBatchProductProductionNormItemProcesssInfo> focusProcessList = new List<MMBatchProductProductionNormItemProcesssInfo>();
            if (type == "All" || itemNote.Count() > 0)
            {
                focusProcessList = dsProcess.Where(m =>
                        itemNote.Any(n => n.MMBatchProductProductionNormItemParentOrderName == m.MMBatchProductProductionNormItemParentOrderName
                        && n.MMBatchProductProductionNormItemParentNo == m.MMBatchProductProductionNormItemParentNo)).ToList();
                if (mainObject.MMBatchProductWoodStatus == Status.Approved.ToString())
                    if (!CheckApplyProcess(focusProcessList))
                    {
                        BOSDisposeUtility.DisposeAll(focusProcessList, 0, GCCollectionMode.Forced);
                        return;
                    }
            }
            #endregion
            #region clean & save data
            try
            {
                // Semi
                if (mainObject.MMBatchProductWoodStatus == Status.Approved.ToString())
                    if (itemNote != null)
                    {
                        List<MMBatchProductProductionNormItemsInfo> ApplyList = new List<MMBatchProductProductionNormItemsInfo>();
                        itemNote.ForEach(n =>
                        {
                            MMBatchProductProductionNormItemsInfo item = new MMBatchProductProductionNormItemsInfo();
                            BOSUtil.CopyViewObject(n, item);
                            item.MMBatchProductProductionNormItemQuantity = n.MMBatchProductProductionNormItemApplyQuantity;
                            item.FK_MMBatchProductItemID = SelectBatchProductItemList[0].MMBatchProductItemID;
                            item.FK_ICProductForBatchID = SelectBatchProductItemList[0].FK_ICProductID;
                            item.FK_MMBatchProductID = SelectBatchProductItemList[0].FK_MMBatchProductID;
                            //if (item.MMBatchProductProductionNormItemType == "Delete" && n.MMBatchProductProductionNormItemApplyQuantity == 0)
                            //    item.AAStatus = "Delete";
                            ApplyList.Add(item);
                        });
                        if (ApplyList.Count() > 0)
                            SaveItemWithDataTableType.SaveItemWithoutDeleteOverTimeOut<MMBatchProductProductionNormItemsInfo>(ApplyList
                                , "MMBatchProductProductionNormItemID", "MMBatchProductProductionNormItems", SelectBatchProductItemList[0].FK_MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);
                    }
                //Material
                if (mainObject.MMBatchProductWoodStatus == Status.Approved.ToString())
                    if (focusMaterialList != null && (type == "All" || type == ProductType.Material.ToString()))
                    {
                        focusMaterialList.ForEach(n =>
                        {
                            n.MMBatchProductProductionNormItemMeterialDepreciationQty = n.MMBatchProductProductionNormItemMeterialApplyQty;
                            n.FK_MMBatchProductItemID = SelectBatchProductItemList[0].MMBatchProductItemID;
                            n.FK_MMBatchProductID = SelectBatchProductItemList[0].FK_MMBatchProductID;
                            //if (n.MMBatchProductProductionNormItemType == "Delete" && n.MMBatchProductProductionNormItemMeterialApplyQty == 0)
                            //    n.AAStatus = "Delete";
                        });
                        if (focusMaterialList.Where(m => m.MMBatchProductProductionNormItemType != "Normal" || m.MMBatchProductProductionNormItemMaterialType == "Yes").Count() > 0)
                            SaveItemWithDataTableType.SaveItemWithoutDeleteOverTimeOut<MMBatchProductProductionNormItemMeterialsInfo>(focusMaterialList.Where(m => m.MMBatchProductProductionNormItemType != "Normal" || m.MMBatchProductProductionNormItemMaterialType == "Yes").ToList()
                                , "MMBatchProductProductionNormItemMeterialID", "MMBatchProductProductionNormItemMeterials", SelectBatchProductItemList[0].FK_MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);
                    }
                //HW
                if (mainObject.MMBatchProductHWStatus == Status.Approved.ToString())
                    if (checkHWApprove && focusHWList != null && (type == "All" || type == ProductType.Hardware.ToString()))
                    {
                        List<MMBatchProductProductionNormItemsInfo> ApplyHWList = new List<MMBatchProductProductionNormItemsInfo>();
                        focusHWList.ForEach(n =>
                        {
                            MMBatchProductProductionNormItemsInfo item = new MMBatchProductProductionNormItemsInfo();
                            BOSUtil.CopyViewObject(n, item);
                            item.MMBatchProductProductionNormItemQuantity = n.MMBatchProductProductionNormItemMeterialApplyQty;
                            item.FK_MMBatchProductItemID = SelectBatchProductItemList[0].MMBatchProductItemID;
                            item.FK_MMBatchProductID = SelectBatchProductItemList[0].FK_MMBatchProductID;
                            item.MMBatchProductProductionNormItemID = n.FK_MMBatchProductProductionNormItemID;
                            item.FK_ICProductForBatchID = SelectBatchProductItemList[0].FK_ICProductID;
                            item.FK_ICProductID = n.FK_ICProductID;
                            //if (n.MMBatchProductProductionNormItemType == "Delete" && n.MMBatchProductProductionNormItemMeterialApplyQty == 0)
                            //    item.AAStatus = "Delete";

                            ApplyHWList.Add(item);
                        });
                        if (ApplyHWList.Count() > 0)
                            SaveItemWithDataTableType.SaveItemWithoutDeleteOverTimeOut<MMBatchProductProductionNormItemsInfo>(ApplyHWList
                                , "MMBatchProductProductionNormItemID", "MMBatchProductProductionNormItems", SelectBatchProductItemList[0].FK_MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);
                    }
                //Paint
                if (mainObject.MMBatchProductPaintStatus == Status.Approved.ToString())
                    if (checkPaintApprove && focusPaintList != null && (type == "All" || type == ProductType.IngredientPaint.ToString()))
                    {
                        List<MMBatchProductProductionNormItemsInfo> ApplyPaintList = new List<MMBatchProductProductionNormItemsInfo>();
                        focusPaintList.ForEach(n =>
                        {
                            MMBatchProductProductionNormItemsInfo item = new MMBatchProductProductionNormItemsInfo();
                            BOSUtil.CopyViewObject(n, item);
                            item.MMBatchProductProductionNormItemQuantity = n.MMBatchProductProductionNormItemMeterialApplyQty;
                            item.FK_MMBatchProductItemID = SelectBatchProductItemList[0].MMBatchProductItemID;
                            item.FK_MMBatchProductID = SelectBatchProductItemList[0].FK_MMBatchProductID;
                            item.MMBatchProductProductionNormItemID = n.FK_MMBatchProductProductionNormItemID;
                            item.FK_MMProductionNormItemID = n.FK_MMProductionNormItemID;
                            item.FK_MMBPSemiProductID = n.FK_MMBPSemiProductID;
                            item.FK_ICProductForBatchID = SelectBatchProductItemList[0].FK_ICProductID;
                            //if (n.MMBatchProductProductionNormItemType == "Delete" && n.MMBatchProductProductionNormItemMeterialApplyQty == 0)
                            //    item.AAStatus = "Delete";
                            //else
                            item.AAStatus = "Alive";
                            ApplyPaintList.Add(item);
                        });
                        if (ApplyPaintList.Count() > 0)
                            SaveItemWithDataTableType.SaveItemWithoutDeleteOverTimeOut<MMBatchProductProductionNormItemsInfo>(ApplyPaintList
                                , "MMBatchProductProductionNormItemID", "MMBatchProductProductionNormItems", SelectBatchProductItemList[0].FK_MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);
                    }
                //Pack
                if (mainObject.MMBatchProductPackagingStatus == Status.Approved.ToString())
                    if (checkPackApprove && focusPackList != null && (type == "All" || type == ProductType.IngredientPackaging.ToString()))
                    {
                        List<MMBatchProductProductionNormItemsInfo> ApplyPackList = new List<MMBatchProductProductionNormItemsInfo>();
                        focusPackList.ForEach(n =>
                        {
                            MMBatchProductProductionNormItemsInfo item = new MMBatchProductProductionNormItemsInfo();
                            BOSUtil.CopyViewObject(n, item);
                            item.MMBatchProductProductionNormItemQuantity = n.MMBatchProductProductionNormItemMeterialApplyQty;
                            item.FK_MMBatchProductItemID = SelectBatchProductItemList[0].MMBatchProductItemID;
                            item.FK_MMBatchProductID = SelectBatchProductItemList[0].FK_MMBatchProductID;
                            item.MMBatchProductProductionNormItemID = n.FK_MMBatchProductProductionNormItemID;
                            item.FK_MMProductionNormItemID = n.FK_MMProductionNormItemID;
                            item.FK_MMBPSemiProductID = n.FK_MMBPSemiProductID;
                            item.FK_ICProductForBatchID = SelectBatchProductItemList[0].FK_ICProductID;
                            //if (n.MMBatchProductProductionNormItemType == "Delete" && n.MMBatchProductProductionNormItemMeterialApplyQty == 0)
                            //    item.AAStatus = "Delete";
                            //else 
                            item.AAStatus = "Alive";
                            ApplyPackList.Add(item);
                        });
                        if (ApplyPackList.Count() > 0)
                            SaveItemWithDataTableType.SaveItemWithoutDeleteOverTimeOut<MMBatchProductProductionNormItemsInfo>(ApplyPackList
                                , "MMBatchProductProductionNormItemID", "MMBatchProductProductionNormItems", SelectBatchProductItemList[0].FK_MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);
                    }
                //General
                if (mainObject.MMBatchProductGeneralMaterialStatus == Status.Approved.ToString())
                    if (checkGeneralApprove && focusGeneralList != null && (type == "All" || type == ProductType.GeneralMaterial.ToString()))
                    {
                        List<MMBatchProductProductionNormItemsInfo> ApplyGeneralList = new List<MMBatchProductProductionNormItemsInfo>();
                        focusGeneralList.ForEach(n =>
                        {
                            MMBatchProductProductionNormItemsInfo item = new MMBatchProductProductionNormItemsInfo();
                            BOSUtil.CopyViewObject(n, item);
                            item.MMBatchProductProductionNormItemQuantity = n.MMBatchProductProductionNormItemMeterialApplyQty;
                            item.FK_MMBatchProductItemID = SelectBatchProductItemList[0].MMBatchProductItemID;
                            item.FK_MMBatchProductID = SelectBatchProductItemList[0].FK_MMBatchProductID;
                            item.MMBatchProductProductionNormItemID = n.FK_MMBatchProductProductionNormItemID;
                            item.FK_MMProductionNormItemID = n.FK_MMProductionNormItemID;
                            item.FK_MMBPSemiProductID = n.FK_MMBPSemiProductID;
                            item.FK_ICProductForBatchID = SelectBatchProductItemList[0].FK_ICProductID;
                            //if (n.MMBatchProductProductionNormItemType == "Delete" && n.MMBatchProductProductionNormItemMeterialApplyQty == 0)
                            //    item.AAStatus = "Delete";
                            //else 
                            item.AAStatus = "Alive";
                            ApplyGeneralList.Add(item);
                        });
                        if (ApplyGeneralList.Count() > 0)
                            SaveItemWithDataTableType.SaveItemWithoutDeleteOverTimeOut<MMBatchProductProductionNormItemsInfo>(ApplyGeneralList
                                , "MMBatchProductProductionNormItemID", "MMBatchProductProductionNormItems", SelectBatchProductItemList[0].FK_MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);
                    }

                //Process
                if (mainObject.MMBatchProductWoodStatus == Status.Approved.ToString())
                    if (focusProcessList != null)
                    {
                        List<MMBatchProductProductionNormItemProcesssInfo> ApplyProcessList = new List<MMBatchProductProductionNormItemProcesssInfo>();
                        focusProcessList.ForEach(n =>
                        {
                            MMBatchProductProductionNormItemProcesssInfo item = new MMBatchProductProductionNormItemProcesssInfo();
                            BOSUtil.CopyViewObject(n, item);
                            item.FK_MMBatchProductItemID = SelectBatchProductItemList[0].MMBatchProductItemID;
                            item.FK_MMBatchProductID = SelectBatchProductItemList[0].FK_MMBatchProductID;
                            item.FK_MMBatchProductProductionNormItemID = n.FK_MMBatchProductProductionNormItemID;
                            if (n.MMBatchProductProductionNormItemType == "Delete" && n.MMBatchProductProductionNormItemApplyQuantity == 0)
                                item.AAStatus = "Delete";
                            else item.AAStatus = "Alive";

                            ApplyProcessList.Add(item);
                        });
                        if (ApplyProcessList.Count() > 0)
                            SaveItemWithDataTableType.SaveItemWithoutDeleteOverTimeOut<MMBatchProductProductionNormItemProcesssInfo>(ApplyProcessList
                                , "MMBatchProductProductionNormItemProcessID", "MMBatchProductProductionNormItemProcesss", SelectBatchProductItemList[0].FK_MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);
                    }
                //Update batchItem 
                if (isChangeBOM)
                    (new MMBatchProductItemsController()).UpdateChangeBOM(SelectBatchProductItemList[0].MMBatchProductItemID, norm, BOSApp.CurrentUsersInfo.ADUserName);
                else
                    (new MMBatchProductItemsController()).UpdateChangeQty(SelectBatchProductItemList[0].MMBatchProductItemID, qty, BOSApp.CurrentUsersInfo.ADUserName);
                # region write log
                MMBatchProductAdjustLogsInfo logsInfo = new MMBatchProductAdjustLogsInfo();
                logsInfo.MMBatchProductAdjustLogDate = BOSApp.GetCurrentServerDate();
                logsInfo.FK_HREmployeeEditID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                logsInfo.FK_HREmployeeRequestEditID = fld_lkeRequireApplyName.EditValue != null ? int.Parse(fld_lkeRequireApplyName.EditValue.ToString()) : 0;
                logsInfo.MMBatchProductAdjustLogDesc = fld_medApplyInfo.Text;
                logsInfo.FK_MMProductionNormNewID = norm;
                logsInfo.FK_MMProductionNormOldID = SelectBatchProductItemList[0].FK_MMProductionNormID;
                logsInfo.MMBatchProductAdjustLogOldQty = SelectBatchProductItemList[0].MMBatchProductItemProductQty;
                logsInfo.MMBatchProductAdjustLogQty = qty;
                logsInfo.FK_MMBatchProductID = SelectBatchProductItemList[0].FK_MMBatchProductID;
                logsInfo.FK_MMBatchProductItemID = SelectBatchProductItemList[0].MMBatchProductItemID;
                logsInfo.MMBatchProductAdjustLogType = isChangeBOM ? "ChangeBOM" : "ChangeQty";
                logsInfo.MMBatchProductAdjustLogIsMaterialChanged = false;
                (new MMBatchProductAdjustLogsController()).CreateObject(logsInfo);
                #endregion
                IsMerge = true;
                BOSApp.ShowMessage("Áp dụng thành công!");
                ViewBomChange();
            }
            catch (Exception ex)
            {
                BOSApp.ShowMessage("Có lổi xảy ra" + Environment.NewLine + ex.ToString());
            }
            #endregion
        }

        public List<MMBatchProductProductionNormItemMeterialsInfo> GetFocusList(GridView gridView)
        {
            List<MMBatchProductProductionNormItemMeterialsInfo> focusMaterialList = new List<MMBatchProductProductionNormItemMeterialsInfo>();
            List<object> filterList = (List<object>)gridView.DataController.GetAllFilteredAndSortedRows();
            if (filterList != null)
                foreach (object obj in filterList)
                {
                    MMBatchProductProductionNormItemMeterialsInfo item = (MMBatchProductProductionNormItemMeterialsInfo)obj;
                    if (item != null) focusMaterialList.Add(item);
                }
            return focusMaterialList;
        }

        public bool CheckApplyMaterial(List<MMBatchProductProductionNormItemMeterialsInfo> listMaterial, string type)
        {
            bool isConflig = false;
            listMaterial.ForEach(m =>
                {
                    if (m.MMBatchProductProductionNormItemType == "Delete" || m.MMBatchProductProductionNormItemType == "Decrease")
                    {
                        if (m.MMBatchProductProductionNormItemMeterialApplyQty < m.MMBatchProductProductionNormItemMeterialCanApplyQty)
                        {
                            m.IsError = true;
                            isConflig = true;
                        }
                        else
                        {
                            if (m.MMBatchProductProductionNormItemMeterialAllocationQty > m.MMBatchProductProductionNormItemMeterialAllocatedQty)
                            {
                                m.IsError = true;
                                isConflig = true;
                            }
                            else
                                m.IsError = false;
                        }
                    }
                });
            string mess = "Nguyên liệu";
            switch (type)
            {
                case "Material": mess = "Nguyên liệu"; break;
                case "Hardware": mess = "Hardware"; break;
                case "IngredientPaint": mess = "Sơn"; break;
                case "IngredientPackaging": mess = "PLDG"; break;
                case "GeneralMaterial": mess = "VTC"; break;
                default:
                    mess = "Nguyên liệu";
                    break;
            }
            if (isConflig)
                BOSApp.ShowMessage("Số lượng " + mess + " áp dụng lớn hơn SL được phép,vui lòng Đóng/Huỷ các KHSD đang dở dang!");
            return !isConflig;
        }
        public bool CheckApplyProcess(List<MMBatchProductProductionNormItemProcesssInfo> listProcess)
        {
            bool isConflig = false;
            bool isExitJobNotClose = false;
            listProcess.ForEach(m =>
            {
                if (m.MMBatchProductProductionNormItemType == "Delete" || m.MMBatchProductProductionNormItemType == "Decrease")
                {
                    if (m.MMBatchProductProductionNormItemApplyQuantity < m.MMBatchProductProductionNormItemRemainQty)
                    {
                        m.IsError = true;
                        isConflig = true;
                    }
                    else
                    {
                        if (m.MMOperationDetailPlanItemChildPlanActiveProductQty > 0)
                        {
                            m.IsError = true;
                            isExitJobNotClose = true;
                        }
                        else
                            m.IsError = false;
                        m.IsError = false;
                    }
                }
            });
            if (isConflig)
                BOSApp.ShowMessage("Số lượng đã Kế hoạch (KHSXCT, KH Gia công và tồn kho) lớn hơn số lượng áp dụng được phép, vui lòng Đóng/Huỷ/Hoàn thành các Kế hoạch");
            if (isExitJobNotClose)
            {
                BOSApp.ShowMessage("Tồn tại Kế hoạch (KHSXCT, KH Gia công và tồn kho) chưa đóng, vui lòng Đóng/Huỷ/Hoàn thành các Kế hoạch đang dở dang!");
                isConflig = true;
            }
            return !isConflig;
        }
        #region Event
        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_lkeMMProductionNormID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BatchProductEntities entity = (BatchProductEntities)((BatchProductModule)this.Module).CurrentModuleEntity;
            List<MMProductionNormsInfo> filterBomList = new List<MMProductionNormsInfo>();
            if (BOSApp.LookupTables.ContainsKey("MMProductionNorms"))
            {
                DataSet ds = (DataSet)BOSApp.LookupTables["MMProductionNorms"];
                if (ds != null && ds.Tables.Count > 0)
                {
                    filterBomList = (List<MMProductionNormsInfo>)(new MMProductionNormsController()).GetListFromDataSet(ds);
                    if (filterBomList != null)
                    {
                        if (fld_lkeFK_ICProductID1.EditValue != null)
                        {
                            MMBatchProductItemsInfo batchItem = entity.BatchProductItemList.Where(o => o.MMBatchProductItemID == int.Parse(fld_lkeFK_ICProductID1.EditValue.ToString())).FirstOrDefault();
                            if (batchItem != null)
                                filterBomList = filterBomList.Where(f => f.FK_ICProductID == batchItem.FK_ICProductID
                                && f.MMProductionNormWoodStatus == Status.Approved.ToString()
                                && f.MMProductionNormStatus != Status.Canceled.ToString()
                                ).ToList();
                        }
                        fld_lkeMMProductionNormID.Properties.DataSource = filterBomList;
                    }
                }
            }
        }
        private void fld_btnViewChange_Click(object sender, EventArgs e)
        {
            ViewBomChange();
        }
        public void ViewBomChange()
        {
            int fromNormID = fld_lkeMMProductionNormID.EditValue != null ? int.Parse(fld_lkeMMProductionNormID.EditValue.ToString()) : 0;
            int toBatchItemID = fld_lkeFK_ICProductID1.EditValue != null ? int.Parse(fld_lkeFK_ICProductID1.EditValue.ToString()) : 0;
            decimal qty = fld_txtProductQty.EditValue != null ? decimal.Parse(fld_txtProductQty.EditValue.ToString()) : SelectBatchProductItemList[0].MMBatchProductItemProductQty;
            // if(qty == 0 ) fld_txtProductQty.EditValue = SelectBatchProductItemList[0].MMBatchProductItemProductQty;
            string type = ProductType.SemiProduct.ToString();
            if (qty < 0)
            {
                BOSApp.ShowMessage("Số lượng thay thế không phù hợp!");
                return;
            }
            if (!CheckProductionPlanningQty(SelectBatchProductItemList[0].MMBatchProductItemID, qty)) return;
            BOSProgressBar.Start("Đang tải dữ liệu...");
            //MMProductionn
            List<MMBatchProductProductionNormItemsViewInfo> Semi;
            List<MMBatchProductProductionNormItemMeterialsInfo> Material;
            List<MMBatchProductProductionNormItemProcesssInfo> Process;
            List<MMBatchProductProductionNormItemMeterialsInfo> OtherMaterial;
            Semi = (new MMBatchProductProductionNormItemsViewController()).GetListBomChangeByBatchQtyAndSomeCriteria(fromNormID, toBatchItemID, qty);
            if (Semi != null)
            {
                try
                {
                    // Reset parent ID key in list => Error BOM
                    Semi.ForEach(s =>
                    {
                        MMBatchProductProductionNormItemsViewInfo parent = Semi.Where(r => r.MMBatchProductProductionNormItemParentOrderName == s.MMBatchProductProductionNormItemParentNo).FirstOrDefault();
                        if (parent != null) s.ParentID = parent.FK_MMProductionNormItemID;
                    });
                    dsSemi = Semi;
                    fld_trlMMViewChangeSemiBOMs.DataSource = Semi;
                    fld_trlMMViewChangeSemiBOMs.BestFitColumns();
                    fld_trlMMViewChangeSemiBOMs.ExpandAll();
                }
                catch (Exception e)
                {
                    BOSProgressBar.Close();
                    BOSApp.ShowMessage("Mã cây định mức trùng nhau, vui lòng phát sinh lại cấu trúc cây định mức.");
                    return;
                }
            }
            Material = (new MMBatchProductProductionNormItemMeterialsController()).GetListBomChangeMaterialByBatchQtyAndSomeCriteria(fromNormID, toBatchItemID, qty);
            if (Material != null)
            {
                dsMaterial = Material;
                fld_dgcViewChangeMaterialGridControl.DataSource = Material;
                GridControlMaterialHelper.ClearSelection();
            }
            Process = (new MMBatchProductProductionNormItemProcesssController()).GetChangeProcessOperationByBatchQtyAndSomeCriteria(fromNormID, toBatchItemID, qty);
            if (Process != null)
            {
                dsProcess = Process;
                fld_dgcViewChangeProcessGridControl.DataSource = Process;
            }

            OtherMaterial = (new MMBatchProductProductionNormItemMeterialsController()).GetListBomChangeOtherMaterialByBatchQtyAndSomeCriteria(fromNormID, toBatchItemID, qty);
            if (OtherMaterial != null)
            {
                dsOtherMaterial = OtherMaterial;
                fld_dgcViewChangeHWGridControl.DataSource = OtherMaterial.Where(o => o.MMBatchProductProductionNormItemGroup == ProductType.Hardware.ToString()).ToList();
                fld_dgcViewChangePaintGridControl.DataSource = OtherMaterial.Where(o => o.MMBatchProductProductionNormItemGroup == ProductType.IngredientPaint.ToString()).ToList();
                fld_dgcViewChangePackGridControl.DataSource = OtherMaterial.Where(o => o.MMBatchProductProductionNormItemGroup == ProductType.IngredientPackaging.ToString()).ToList();
                fld_dgcViewChangeOtherMaterialGridControl.DataSource = OtherMaterial.Where(o => o.MMBatchProductProductionNormItemGroup == ProductType.GeneralMaterial.ToString()).ToList();

                fld_dgcViewChangeHWGridControl?.RefreshDataSource();
                GridControlHWHelper.ClearSelection();
                fld_dgcViewChangePaintGridControl?.RefreshDataSource();
                GridControlPaintHelper.ClearSelection();
                fld_dgcViewChangePackGridControl?.RefreshDataSource();
                GridControlPackHelper.ClearSelection();
                fld_dgcViewChangeOtherMaterialGridControl?.RefreshDataSource();
                GridControlGenMaterialHelper.ClearSelection();

            }

            if (fld_trlMMViewChangeSemiBOMs != null)
            {
                if (fld_trlMMViewChangeSemiBOMs.Nodes.Count() > 0)
                {
                    MMBatchProductProductionNormItemsViewInfo childNote = (MMBatchProductProductionNormItemsViewInfo)fld_trlMMViewChangeSemiBOMs.GetDataRecordByNode(fld_trlMMViewChangeSemiBOMs.Nodes[0]);
                    List<MMBatchProductProductionNormItemsViewInfo> selectedNodes = new List<MMBatchProductProductionNormItemsViewInfo>();
                    if (childNote != null)
                    {
                        selectedNodes.Add(childNote);
                        childNote.MMBatchProductProductionNormItemApplyQuantity = GetMaxChangeProcess(childNote);
                    }
                    //fld_trlMMViewChangeSemiBOMs.SelectAllChildren(fld_trlMMViewChangeSemiBOMs.Nodes[0], selectedNodes);
                    if (selectedNodes != null)
                    {
                        if (CheckChangeMaterial(selectedNodes))
                            childNote.MMBatchProductProductionNormItemMaterialType = "Yes";
                        else childNote.MMBatchProductProductionNormItemMaterialType = "No";
                        //Hardware
                        if (CheckChangeOtherMaterial(selectedNodes, ProductType.Hardware.ToString()))
                            childNote.MMBatchProductProductionNormItemHWType = "Yes";
                        else childNote.MMBatchProductProductionNormItemHWType = "No";
                        //IngredientPaint
                        if (CheckChangeOtherMaterial(selectedNodes, ProductType.IngredientPaint.ToString()))
                            childNote.MMBatchProductProductionNormItemPaintType = "Yes";
                        else childNote.MMBatchProductProductionNormItemPaintType = "No";
                        //IngredientPackaging
                        if (CheckChangeOtherMaterial(selectedNodes, ProductType.IngredientPackaging.ToString()))
                            childNote.MMBatchProductProductionNormItemPackType = "Yes";
                        else childNote.MMBatchProductProductionNormItemPackType = "No";
                        //GeneralMaterial
                        if (CheckChangeOtherMaterial(selectedNodes, ProductType.GeneralMaterial.ToString()))
                            childNote.MMBatchProductProductionNormItemGeneralType = "Yes";
                        else childNote.MMBatchProductProductionNormItemGeneralType = "No";

                        if (CheckChangeProcess(selectedNodes))
                            childNote.MMBatchProductProductionNormItemProcessType = "Yes";
                        else
                            childNote.MMBatchProductProductionNormItemProcessType = "No";
                    }
                    selectedNodes.Clear();
                    BOSDisposeUtility.DisposeAll(selectedNodes, 0, GCCollectionMode.Forced);
                    if (fld_trlMMViewChangeSemiBOMs.Nodes[0].Nodes != null && fld_trlMMViewChangeSemiBOMs.Nodes[0].Nodes.Count > 0)
                        UpdateAllChildrenNote(fld_trlMMViewChangeSemiBOMs.Nodes[0]);
                }
                fld_trlMMViewChangeSemiBOMs.RefreshDataSource();

            }
            BOSProgressBar.Close();
        }
        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            if (IsMerge) DialogResult = DialogResult.OK;
            Close();
        }
        #endregion


        public void InitBatchProductData()
        {
            BatchProductEntities entity = (BatchProductEntities)((BatchProductModule)this.Module).CurrentModuleEntity;
            fld_lkeFK_ICProductID1.BOSDataSource = "MMBatchProductItems";
            fld_lkeFK_ICProductID1.BOSDataMember = "MMBatchProductItemID";
            fld_lkeFK_ICProductID1.Properties.DataSource = entity.BatchProductItemList;
            fld_lkeFK_ICProductID1.Properties.DisplayMember = "MMBatchProductItemProductNo";
            fld_lkeFK_ICProductID1.Properties.Columns.Clear();
            fld_lkeFK_ICProductID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
             new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductItemProductSerial", "Mã lô SX")
            ,new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductItemProductNo", "Mã sản phẩm")
            ,new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductItemProductName", "Tên sản phẩm")});
            fld_lkeFK_ICProductID1.Properties.ValueMember = "MMBatchProductItemID";
        }

        public void SemiSelectChange(List<MMBatchProductProductionNormItemsViewInfo> selectedNodes)
        {
            if (selectedNodes != null)
            {
                fld_dgcViewChangeMaterialGridControl.DataSource = dsMaterial.Where(m => selectedNodes.Any(s =>
                                        (m.MMBatchProductProductionNormItemParentOrderName == s.MMBatchProductProductionNormItemParentOrderName
                                        && m.MMBatchProductProductionNormItemParentNo == s.MMBatchProductProductionNormItemParentNo)
                                        //|| s.MMBatchProductProductionNormItemParentOrderName == m.MMBatchProductProductionNormItemParentNo
                                        )).ToList();
                fld_dgcViewChangeProcessGridControl.DataSource = dsProcess.Where(p => selectedNodes.Any(s =>
                                    (p.MMBatchProductProductionNormItemParentOrderName == s.MMBatchProductProductionNormItemParentOrderName
                                        && p.MMBatchProductProductionNormItemParentNo == s.MMBatchProductProductionNormItemParentNo)
                                        //|| s.MMBatchProductProductionNormItemParentOrderName == p.MMBatchProductProductionNormItemParentNo
                                        )).ToList();

                if (dsOtherMaterial != null)
                {
                    if (fld_dgcViewChangeHWGridControl != null)
                        fld_dgcViewChangeHWGridControl.DataSource = dsOtherMaterial.Where(m => selectedNodes.Any(s =>
                                        (m.MMBatchProductProductionNormItemParentOrderName == s.MMBatchProductProductionNormItemParentOrderName
                                        && m.MMBatchProductProductionNormItemParentNo == s.MMBatchProductProductionNormItemParentNo)
                                       //|| s.MMBatchProductProductionNormItemParentOrderName == m.MMBatchProductProductionNormItemParentNo
                                       )
                                        && m.MMBatchProductProductionNormItemGroup == ProductType.Hardware.ToString()).ToList();
                    if (fld_dgcViewChangePaintGridControl != null)
                        fld_dgcViewChangePaintGridControl.DataSource = dsOtherMaterial.Where(m => m.FK_ICProductID > 0 && selectedNodes.Any(s =>
                                        (m.MMBatchProductProductionNormItemParentOrderName == s.MMBatchProductProductionNormItemParentOrderName
                                        && m.MMBatchProductProductionNormItemParentNo == s.MMBatchProductProductionNormItemParentNo)
                                    //|| s.MMBatchProductProductionNormItemParentOrderName == m.MMBatchProductProductionNormItemParentNo
                                    )
                                     && m.MMBatchProductProductionNormItemGroup == ProductType.IngredientPaint.ToString()).ToList();
                    if (fld_dgcViewChangePackGridControl != null)
                        fld_dgcViewChangePackGridControl.DataSource = dsOtherMaterial.Where(m => selectedNodes.Any(s =>
                                        (m.MMBatchProductProductionNormItemParentOrderName == s.MMBatchProductProductionNormItemParentOrderName
                                        && m.MMBatchProductProductionNormItemParentNo == s.MMBatchProductProductionNormItemParentNo)
                                    //|| s.MMBatchProductProductionNormItemParentOrderName == m.MMBatchProductProductionNormItemParentNo
                                    )
                                    && m.MMBatchProductProductionNormItemGroup == ProductType.IngredientPackaging.ToString()).ToList();
                    if (fld_dgcViewChangeOtherMaterialGridControl != null)
                        fld_dgcViewChangeOtherMaterialGridControl.DataSource = dsOtherMaterial.Where(m => selectedNodes.Any(s =>
                                            (m.MMBatchProductProductionNormItemParentOrderName == s.MMBatchProductProductionNormItemParentOrderName
                                            && m.MMBatchProductProductionNormItemParentNo == s.MMBatchProductProductionNormItemParentNo)
                                        //|| s.MMBatchProductProductionNormItemParentOrderName == m.MMBatchProductProductionNormItemParentNo
                                        )
                                       && m.MMBatchProductProductionNormItemGroup == ProductType.GeneralMaterial.ToString()).ToList();
                }

                fld_dgcViewChangeMaterialGridControl?.RefreshDataSource();
            }
        }
        public void UpdateAllChildrenNote(TreeListNode node)
        {
            if (node.Nodes != null)
            {
                foreach (TreeListNode Child in node.Nodes)
                {
                    MMBatchProductProductionNormItemsViewInfo childNote = (MMBatchProductProductionNormItemsViewInfo)fld_trlMMViewChangeSemiBOMs.GetDataRecordByNode(Child);
                    List<MMBatchProductProductionNormItemsViewInfo> selectedNodes = new List<MMBatchProductProductionNormItemsViewInfo>();
                    if (childNote != null)
                    {
                        selectedNodes.Add(childNote);
                        childNote.MMBatchProductProductionNormItemApplyQuantity = GetMaxChangeProcess(childNote);
                    }
                    // fld_trlMMViewChangeSemiBOMs.SelectAllChildren(Child, selectedNodes);
                    if (selectedNodes != null)
                    {
                        if (CheckChangeMaterial(selectedNodes))
                            childNote.MMBatchProductProductionNormItemMaterialType = "Yes";
                        else childNote.MMBatchProductProductionNormItemMaterialType = "No";
                        //Hardware
                        if (CheckChangeOtherMaterial(selectedNodes, ProductType.Hardware.ToString()))
                            childNote.MMBatchProductProductionNormItemHWType = "Yes";
                        else childNote.MMBatchProductProductionNormItemHWType = "No";
                        //IngredientPaint
                        if (CheckChangeOtherMaterial(selectedNodes, ProductType.IngredientPaint.ToString()))
                            childNote.MMBatchProductProductionNormItemPaintType = "Yes";
                        else childNote.MMBatchProductProductionNormItemPaintType = "No";
                        //IngredientPackaging
                        if (CheckChangeOtherMaterial(selectedNodes, ProductType.IngredientPackaging.ToString()))
                            childNote.MMBatchProductProductionNormItemPackType = "Yes";
                        else childNote.MMBatchProductProductionNormItemPackType = "No";
                        //GeneralMaterial
                        if (CheckChangeOtherMaterial(selectedNodes, ProductType.GeneralMaterial.ToString()))
                            childNote.MMBatchProductProductionNormItemGeneralType = "Yes";
                        else childNote.MMBatchProductProductionNormItemGeneralType = "No";

                        if (CheckChangeProcess(selectedNodes))
                            childNote.MMBatchProductProductionNormItemProcessType = "Yes";
                        else childNote.MMBatchProductProductionNormItemProcessType = "No";
                    }
                    selectedNodes.Clear();
                    BOSDisposeUtility.DisposeAll(selectedNodes, 0, GCCollectionMode.Forced);
                    if (Child.Nodes != null && Child.Nodes.Count > 0)
                        UpdateAllChildrenNote(Child);
                }
            }
        }

        public bool CheckChangeMaterial(List<MMBatchProductProductionNormItemsViewInfo> selectedNodes)
        {
            List<MMBatchProductProductionNormItemMeterialsInfo> subMaterial
                    = dsMaterial.Where(m => selectedNodes.Any(s => m.MMBatchProductProductionNormItemParentOrderName == s.MMBatchProductProductionNormItemParentOrderName
                                                                && m.MMBatchProductProductionNormItemParentNo == s.MMBatchProductProductionNormItemParentNo
                                    //|| m.MMBatchProductProductionNormItemParentOrderName == s.MMBatchProductProductionNormItemParentNo
                                    ) && m.MMBatchProductProductionNormItemMaterialType == "Yes"
                                    ).ToList();
            if (subMaterial.Count() > 0)
            {
                //subMaterial.Clear();
                //BOSDisposeUtility.DisposeAll(subMaterial, 0, GCCollectionMode.Forced);
                MMBatchProductProductionNormItemsViewInfo foundDiff = selectedNodes.Where(o => o.MMBatchProductProductionNormItemApplyQuantity >= o.MMBatchProductProductionNormItemNewQuantity).FirstOrDefault();
                if (foundDiff != null && foundDiff.MMBatchProductProductionNormItemApplyQuantity > 0)
                {
                    subMaterial.ForEach(s =>
                    {
                        s.MMBatchProductProductionNormItemMeterialNewDepreciationQty = foundDiff.MMBatchProductProductionNormItemApplyQuantity * s.MMBatchProductProductionNormItemMeterialQtyPerOne;
                        if (s.MMBatchProductProductionNormItemMeterialApplyQty < s.MMBatchProductProductionNormItemMeterialNewDepreciationQty)
                            s.MMBatchProductProductionNormItemMeterialApplyQty = s.MMBatchProductProductionNormItemMeterialNewDepreciationQty;
                    });
                }
                return true;
            }
            return false;
        }
        public decimal GetMaxChangeProcess(MMBatchProductProductionNormItemsViewInfo selectedNodes)
        {
            List<MMBatchProductProductionNormItemProcesssInfo> subProcess
                    = dsProcess.Where(m => m.MMBatchProductProductionNormItemParentOrderName == selectedNodes.MMBatchProductProductionNormItemParentOrderName
                                            && m.MMBatchProductProductionNormItemParentNo == selectedNodes.MMBatchProductProductionNormItemParentNo

                                    ).ToList();
            if (subProcess.Count() > 0)
            {
                decimal result = subProcess.Max(o => o.MMBatchProductProductionNormItemApplyQuantity);
                subProcess.Clear();
                BOSDisposeUtility.DisposeAll(subProcess, 0, GCCollectionMode.Forced);
                return result;
            }
            return 0;
        }

        public bool CheckAllowChangeBOM()
        {
            int totalNode = dsSemi.Where(o => o.MMBatchProductProductionNormItemType != "New").Count();
            int totalChange = dsSemi.Where(o => o.MMBatchProductProductionNormItemType == "New" || o.MMBatchProductProductionNormItemType == "Delete")
                                    .GroupBy(o => o.MMBatchProductProductionNormItemType)
                                    .Select(o => new { Type = o.Key, ItemCount = o.Count() })
                                    .Select(o => o.ItemCount)
                                    .DefaultIfEmpty<int>(0)
                                    .Max();

            string value = ADConfigValueUtility.GetFirstConfigValueByGroup("ChangeBOMRate");
            string configText = ConfigurationManager.AppSettings["AllowNormChange"];
            decimal allowChangeRate = 0;
            bool isWarning = false;
            if (string.IsNullOrEmpty(configText))
                isWarning = false;
            else
                Boolean.TryParse(configText, out isWarning);

            Decimal.TryParse(value, out allowChangeRate);
            if (allowChangeRate == 0 || totalNode == 0)
                return true;

            if (allowChangeRate < 100 * totalChange / totalNode)
            {
                if (isWarning)
                {
                    DialogResult rs = MessageBox.Show(string.Format(BatchProductLocalizedResources.ChangeBOMErrorRateWarning, allowChangeRate), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs != DialogResult.Yes)
                        return false;
                }
                else
                {
                    MessageBox.Show(string.Format(BatchProductLocalizedResources.ChangeBOMErrorRateMessage, allowChangeRate), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        public bool CheckChangeOtherMaterial(List<MMBatchProductProductionNormItemsViewInfo> selectedNodes, string type)
        {
            List<MMBatchProductProductionNormItemMeterialsInfo> subMaterial
                    = dsOtherMaterial.Where(m => selectedNodes.Any(s => m.MMBatchProductProductionNormItemParentOrderName == s.MMBatchProductProductionNormItemParentOrderName
                                                                    && m.MMBatchProductProductionNormItemParentNo == s.MMBatchProductProductionNormItemParentNo
                                    //|| s.MMBatchProductProductionNormItemParentOrderName == m.MMBatchProductProductionNormItemParentNo
                                    ) && m.MMBatchProductProductionNormItemMaterialType == "Yes"
                                      && m.MMBatchProductProductionNormItemGroup == type
                                    ).ToList();
            if (subMaterial.Count() > 0)
            {
                //subMaterial.Clear();
                //BOSDisposeUtility.DisposeAll(subMaterial, 0, GCCollectionMode.Forced);
                MMBatchProductProductionNormItemsViewInfo foundDiff = selectedNodes.Where(o => o.MMBatchProductProductionNormItemApplyQuantity > o.MMBatchProductProductionNormItemNewQuantity).FirstOrDefault();
                if (foundDiff != null && foundDiff.MMBatchProductProductionNormItemApplyQuantity > 0)
                {
                    subMaterial.ForEach(s =>
                    {
                        s.MMBatchProductProductionNormItemMeterialNewDepreciationQty = foundDiff.MMBatchProductProductionNormItemApplyQuantity * s.MMBatchProductProductionNormItemMeterialQtyPerOne;
                        if (s.MMBatchProductProductionNormItemMeterialApplyQty < s.MMBatchProductProductionNormItemMeterialNewDepreciationQty)
                            s.MMBatchProductProductionNormItemMeterialApplyQty = s.MMBatchProductProductionNormItemMeterialNewDepreciationQty;
                    });
                }
                return true;
            }
            return false;
        }
        public bool CheckChangeProcess(List<MMBatchProductProductionNormItemsViewInfo> selectedNodes)
        {
            List<MMBatchProductProductionNormItemProcesssInfo> subProcess
                   = dsProcess.Where(m => selectedNodes.Any(s => m.MMBatchProductProductionNormItemParentOrderName == s.MMBatchProductProductionNormItemParentOrderName
                                                                 && m.MMBatchProductProductionNormItemParentNo == s.MMBatchProductProductionNormItemParentNo
                                    //|| m.MMBatchProductProductionNormItemParentOrderName == s.MMBatchProductProductionNormItemParentNo
                                    ) && m.MMBatchProductProductionNormItemProcessType == "Yes"
                                   ).ToList();
            if (subProcess.Count() > 0)
            {
                subProcess.Clear();
                BOSDisposeUtility.DisposeAll(subProcess, 0, GCCollectionMode.Forced);
                return true;
            }
            return false;
        }

        #region Zoom
        public void ShowFullScreen(Control ctl)
        {
            // Setup host form to be full screen
            guiZoom host = new guiZoom();
            host.MaximizeBox = false;
            host.MinimizeBox = false;
            // Save properties of control
            var loc = ctl.Location;
            var dock = ctl.Dock;
            var parent = ctl.Parent;
            var form = parent;
            var anchor = ctl.Anchor;
            var size = ctl.Size;
            while (!(form is Form)) form = form.Parent;
            // Move control to host
            //ctl.Parent = host;
            host.AddCtrl(ctl);
            ctl.Location = Point.Empty;
            ctl.Dock = DockStyle.Fill;
            // Setup event handler to restore control back to form
            host.FormClosing += delegate
            {
                ctl.Parent = parent;
                ctl.Dock = dock;
                ctl.Location = loc;
                ctl.Anchor = anchor;
                ctl.Size = size;
                form.Refresh();
            };


            // Exit full screen with escape key
            host.KeyPreview = true;
            host.KeyDown += (KeyEventHandler)((s, e) =>
            {
                if (e.KeyCode == Keys.Escape) host.Close();
            });
            // And go full screen
            host.ShowDialog();
            //  form.Hide();
        }

        private void fld_btnZoomHuman_Click(object sender, EventArgs e)
        {
            //fld_spcGroupSemi
            ShowFullScreen(fld_spcGroupSemi);
        }
        #endregion

        private void fld_btnApplyAllItem_Click(object sender, EventArgs e)
        {

            if (fld_trlMMViewChangeSemiBOMs.Nodes != null && fld_trlMMViewChangeSemiBOMs.Nodes.Count > 0
                //&& ( fld_trlMMViewChangeSemiBOMs.Nodes[0].Nodes != null && fld_trlMMViewChangeSemiBOMs.Nodes[0].Nodes.Count > 0)
                )
            {
                if (!CheckAllowChangeBOM())
                    return;

                MMBatchProductProductionNormItemsViewInfo itemNote = (MMBatchProductProductionNormItemsViewInfo)fld_trlMMViewChangeSemiBOMs.GetDataRecordByNode(fld_trlMMViewChangeSemiBOMs.Nodes[0]);
                List<MMBatchProductProductionNormItemsViewInfo> selectedNodes = new List<MMBatchProductProductionNormItemsViewInfo>();
                if (itemNote != null) selectedNodes.Add(itemNote);
                fld_trlMMViewChangeSemiBOMs.SelectAllChildren(fld_trlMMViewChangeSemiBOMs.Nodes[0], selectedNodes);
                if (selectedNodes.Count() > 0) ApplySemiProduct(selectedNodes, null, "All");
            }
        }

        private void fld_lkeFK_ICProductID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                BatchProductEntities entity = (BatchProductEntities)((BatchProductModule)this.Module).CurrentModuleEntity;
                MMBatchProductItemsInfo batchItem = entity.BatchProductItemList.Where(o => o.MMBatchProductItemID == int.Parse(e.Value.ToString())).FirstOrDefault();
                if (batchItem != null)
                {
                    SelectBatchProductItemList = new BOSList<MMBatchProductItemsInfo>();
                    SelectBatchProductItemList.Add(batchItem);

                    fld_lkeMMProductionNormID.EditValue = SelectBatchProductItemList[0].FK_MMProductionNormID;
                    fld_lkeMMProductionNormID.Refresh();
                    fld_txtProductQty.EditValue = SelectBatchProductItemList[0].MMBatchProductItemProductQty;
                }
            }
        }

        private void fld_tabVProductionNorm_SelectedPageChanging(object sender, TabPageChangingEventArgs e)
        {

            if (fld_tabVProductionNorm != null)
                foreach (XtraTabPage page in fld_tabVProductionNorm.TabPages)
                {
                    if (e.Page.Name == "fld_tabVMaterial")
                    {
                        applyType = ProductType.Material.ToString();
                        fld_btnApplyDetail.Text = "Áp dụng nguyên liệu";

                    }
                    else if (e.Page.Name == "fld_tabVHardware")
                    {
                        applyType = ProductType.Hardware.ToString();
                        fld_btnApplyDetail.Text = "Áp dụng hardware";

                    }
                    else if (e.Page.Name == "fld_tabVPaint")
                    {
                        applyType = ProductType.IngredientPaint.ToString();
                        fld_btnApplyDetail.Text = "Áp dụng sơn";

                    }
                    else if (e.Page.Name == "fld_tabVPackaging")
                    {
                        applyType = ProductType.IngredientPackaging.ToString();
                        fld_btnApplyDetail.Text = "Áp dụng PLĐG";

                    }
                    else if (e.Page.Name == "fld_tabVGeneral")
                    {
                        applyType = ProductType.GeneralMaterial.ToString();
                        fld_btnApplyDetail.Text = "Áp dụng VTSXC";

                    }
                }
        }

        private void fld_btnApplyDetail_Click(object sender, EventArgs e)
        {
            if (!CheckAllowChangeBOM())
                return;

            List<MMBatchProductProductionNormItemMeterialsInfo> subMaterial = new List<MMBatchProductProductionNormItemMeterialsInfo>();
            if (applyType == ProductType.Material.ToString())
            {
                subMaterial = GridControlMaterialHelper.Selection.OfType<MMBatchProductProductionNormItemMeterialsInfo>().ToList();
            }
            else if (applyType == ProductType.Hardware.ToString())
            {
                subMaterial = GridControlHWHelper.Selection.OfType<MMBatchProductProductionNormItemMeterialsInfo>().ToList();
            }
            else if (applyType == ProductType.IngredientPaint.ToString())
            {
                subMaterial = GridControlPaintHelper.Selection.OfType<MMBatchProductProductionNormItemMeterialsInfo>().ToList();
            }
            else if (applyType == ProductType.IngredientPackaging.ToString())
            {
                subMaterial = GridControlPackHelper.Selection.OfType<MMBatchProductProductionNormItemMeterialsInfo>().ToList();
            }
            else if (applyType == ProductType.GeneralMaterial.ToString())
            {
                subMaterial = GridControlGenMaterialHelper.Selection.OfType<MMBatchProductProductionNormItemMeterialsInfo>().ToList();
            }
            if (subMaterial.Count() > 0)
            {
                List<MMBatchProductProductionNormItemsViewInfo> dsSemiCheckList = dsSemi.Where(d =>
                subMaterial.Any(m => m.MMBatchProductProductionNormItemParentNo == d.MMBatchProductProductionNormItemParentNo
                    && m.MMBatchProductProductionNormItemParentOrderName == d.MMBatchProductProductionNormItemParentOrderName)
                    && d.MMBatchProductProductionNormItemType == "New").ToList();
                ApplySemiProduct(dsSemiCheckList, subMaterial, applyType);
            }
            else
            {
                BOSApp.ShowMessage("Vui lòng chọn chi tiết cần áp dụng!");
            }
        }
    }
}
