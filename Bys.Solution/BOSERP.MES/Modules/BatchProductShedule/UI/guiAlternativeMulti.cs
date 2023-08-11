using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BOSCommon.Extensions;

namespace BOSERP.Modules.BatchProductShedule
{
    public partial class guiAlternativeMulti : BOSERPScreen
    {
        private GridView PlanItemGridView => (GridView)fld_dgcPnItemsGridControl.MainView;

        private GridView AlternativeGridView => (GridView)fld_dgcProductMultisGridControl.MainView;

        public List<ICProductAlternativesInfo> ProductAlternativesList { get; set; }

        public List<MMAllocationPlanItemsInfo> PlanItems { get; set; }

        public List<MMAllocationPlanItemsInfo> CurrentPlanItemDataSource { get; set; }

        public Dictionary<Guid, List<MMAllocationPlanItemsInfo>> DicDataSource { get; set; }

        public ICProductAlternativesInfo SelectedObject { get; set; }

        public string AllocationPlanGroup { get; set; }

        public bool IsAlterOverConfigMaterial { get; set; }

        public int ICProductID { get; set; }

        private List<MMProductionNormItemConfigsInfo> Configs { get; set; }

        private List<MMExchangeRateConfigsInfo> ExchangeRateConfigs { get; set; }

        public guiAlternativeMulti(string allocationPlanGroup)
        {
            InitializeComponent();
            ProductAlternativesList = new List<ICProductAlternativesInfo>();
            PlanItems = new List<MMAllocationPlanItemsInfo>();
            Configs = new BOSList<MMProductionNormItemConfigsInfo>();
            ExchangeRateConfigs = new BOSList<MMExchangeRateConfigsInfo>();
            DicDataSource = new Dictionary<Guid, List<MMAllocationPlanItemsInfo>>();
            AllocationPlanGroup = allocationPlanGroup;
        }

        private void guiAlternativeMulti_Load(object sender, EventArgs e)
        {
            fld_dgcProductMultisGridControl.IsAlterOverConfigMaterial = IsAlterOverConfigMaterial;
            InitializeControls(Controls);
            CurrentPlanItemDataSource = PlanItems.Select(o => (MMAllocationPlanItemsInfo)o.Clone()).ToList();
            DicDataSource.Add(Guid.Empty, CurrentPlanItemDataSource);
            fld_dgcProductMultisGridControl.InvalidateDataSource(ProductAlternativesList);
            ICProductID = CurrentPlanItemDataSource.Select(o => o.FK_ICProductID).FirstOrDefault();
            fld_dgcProductMultisGridControl.ICProductID = ICProductID;
            fld_dgcPnItemsGridControl.DataSource = CurrentPlanItemDataSource;
            fld_dgcPnItemsGridControl.RefreshDataSource();
            fld_dgcProductMultisGridControl.UpdateView();
            InitializeEvents();
            InitializeCommonData();
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

        private void InitializeEvents()
        {
            PlanItemGridView.KeyUp += GridView_KeyUp;
            PlanItemGridView.CellValueChanged += GridView_CellValueChanged;
            AlternativeGridView.CellValueChanging += AlternativeGridView_CellValueChanging;
            AlternativeGridView.CellValueChanged += AlternativeGridView_CellValueChanged;
            AlternativeGridView.FocusedRowChanged += AlternativeGridView_FocusedRowChanged;
        }

        private void InitializeCommonData()
        {
            List<int> attributeIds = PlanItems.Select(o => o.FK_ICProductAttributeWoodTypeID).Distinct().ToList();
            Configs = (new MMProductionNormItemConfigsController()).GetAllConfigByWoodTypeIds(attributeIds);
        }

        private void AlternativeGridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ICProductAlternativesInfo item = (ICProductAlternativesInfo)AlternativeGridView.GetRow(AlternativeGridView.FocusedRowHandle);
            if (item == null)
                return;

            if (e.Column.FieldName == "Selected")
            {
                ProductAlternativesList.ForEach(o =>
                {
                    if (o.FK_ICProductAlternativeChildID != item.FK_ICProductAlternativeChildID)
                    {
                        o.Selected = false;
                    }
                });
                AlternativeGridView.RefreshData();
            }
        }

        private void AlternativeGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ICProductAlternativesInfo item = (ICProductAlternativesInfo)AlternativeGridView.GetRow(AlternativeGridView.FocusedRowHandle);
            if (item == null)
                return;

            if (DicDataSource.ContainsKey(item.VirtualID))
                CurrentPlanItemDataSource = DicDataSource[item.VirtualID];

            fld_dgcPnItemsGridControl.DataSource = CurrentPlanItemDataSource;
            fld_dgcPnItemsGridControl.RefreshDataSource();
            UpdateInfoAlternative(item);
        }

        private void AlternativeGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ICProductAlternativesInfo item = (ICProductAlternativesInfo)AlternativeGridView.GetRow(AlternativeGridView.FocusedRowHandle);
            if (item == null)
                return;

            BOSDbUtil dbUtil = new BOSDbUtil();
            if (e.Column.FieldName == "FK_ICProductAlternativeChildID")
            {
                ChangeProduct(item);
            }
            else if (e.Column.FieldName == "ICProductAlternativeQty")
            {
                CurrentPlanItemDataSource.ForEach(o => o.MMAllocationPlanItemAltFactor = item.ICProductAlternativeQty);
            }
            else if (e.Column.FieldName == "ICProductAlternativeDepreciationRate")
            {
                CurrentPlanItemDataSource.ForEach(o =>
                {
                    o.MMAllocationPlanItemDepreciationRate = item.ICProductAlternativeDepreciationRate;

                    if (o.MMBatchProductProductionNormItemTSHH != 0)
                        o.MMAllocationPlanItemRate = item.ICProductAlternativeDepreciationRate / o.MMBatchProductProductionNormItemTSHH;
                    if (o.MMAllocationPlanItemRate == 0)
                        o.MMAllocationPlanItemRate = 1m;
                    o.MMAllocationPlanItemRate = Math.Round(o.MMAllocationPlanItemRate, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                });
            }
            else if (e.Column.FieldName == "ICProductHeight"
                     || e.Column.FieldName == "ICProductWidth"
                     || e.Column.FieldName == "ICProductLength"
                     || e.Column.FieldName == "IsChangeDepreciationRate"
                     || e.Column.FieldName == "IsChangeAlternativeProduct")
            {
                CalculateDetailInfo(item);
            }
            UpdateInfoAlternative(item);
        }

        public void ChangeProduct(ICProductAlternativesInfo item)
        {
            ICProductsInfo found = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductAlternativeChildID);
            if (found != null)
            {
                item.VirtualID = Guid.NewGuid();
                item.ICProductNo = found.ICProductNo;
                item.ICProductAlternativeName = found.ICProductName;
                item.ICProductAlternativeDesc = found.ICProductDesc;
                item.ICProductHeight = found.ICProductHeight;
                item.ICProductWidth = found.ICProductWidth;
                item.ICProductLength = found.ICProductLength;
                item.FK_ICMeasureUnitID = found.FK_ICProductBasicUnitID;
                item.ICProductAlternativeRate = 1;
                item.ICProductAlternativeQty = 1;
                item.IsChangeAlternativeProduct = ICProductID != found.ICProductID;
                item.IsChangeDepreciationRate = ICProductID == found.ICProductID;
                item.ICProductAlternativeDepreciationRate = PlanItems.Max(o => o.MMBatchProductProductionNormItemTSHH);
            }
            DicDataSource.Add(item.VirtualID, PlanItems.Select(o => (MMAllocationPlanItemsInfo)o.Clone()).ToList());
        }

        private void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)PlanItemGridView.GetRow(PlanItemGridView.FocusedRowHandle);
            if (item == null)
                return;

            if (e.Column.FieldName == "ICProductAlternativeProductQty")
            {
                ChangePlanItemAlternativeQty(item);
            }
            else if (e.Column.FieldName == "MMAllocationPlanItemDepreciationRate")
            {
                ChangePlanItemDepreciationRate(item);
            }
            ChangePlanItem(item);
            PlanItemGridView.RefreshData();
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)PlanItemGridView.GetRow(PlanItemGridView.FocusedRowHandle);
                if (item == null)
                    return;

                PlanItemGridView.DeleteRow(PlanItemGridView.FocusedRowHandle);
                PlanItemGridView.RefreshData();
                foreach (var items in DicDataSource.Values)
                {
                    items.RemoveAll(o => o.VirtualID == item.VirtualID);
                }
                PlanItems.RemoveAll(o => o.VirtualID == item.VirtualID);
                PlanItemGridView.RefreshData();
            }
        }

        private void ChangePlanItem(MMAllocationPlanItemsInfo item)
        {
            if (item.MMAllocationPlanItemRate == 0)
                item.MMAllocationPlanItemRate = 1m;
            if (item.MMAllocationPlanItemAltFactor == 0)
                item.MMAllocationPlanItemAltFactor = 1m;

            item.ICProductAlternativeProductQty = item.MMAllocationPlanItemQty * item.MMAllocationPlanItemAltFactor * item.MMAllocationPlanItemRate;
            item.ICProductAlternativeProductQty = Math.Round(item.ICProductAlternativeProductQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
        }

        public void ChangePlanItemAlternativeQty(MMAllocationPlanItemsInfo item)
        {
            item.MMAllocationPlanItemRate = item.MMAllocationPlanItemQty == 0 ? 1m : item.ICProductAlternativeProductQty / item.MMAllocationPlanItemQty;
            item.MMAllocationPlanItemRate = Math.Round(item.MMAllocationPlanItemRate, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
            if (item.MMBatchProductProductionNormItemTSHH != 0)
                item.MMAllocationPlanItemDepreciationRate = item.MMAllocationPlanItemRate * item.MMBatchProductProductionNormItemTSHH;
            if (item.MMAllocationPlanItemDepreciationRate == 0)
                item.MMAllocationPlanItemDepreciationRate = 1m;
            item.MMAllocationPlanItemDepreciationRate = Math.Round(item.MMAllocationPlanItemDepreciationRate, RoundingNumber.FormatN2, MidpointRounding.AwayFromZero);
        }

        private void ChangePlanItemDepreciationRate(MMAllocationPlanItemsInfo item)
        {
            if (item.MMBatchProductProductionNormItemTSHH != 0)
                item.MMAllocationPlanItemRate = item.MMAllocationPlanItemDepreciationRate / item.MMBatchProductProductionNormItemTSHH;
            else
                item.MMAllocationPlanItemRate = 1m;
            item.MMAllocationPlanItemRate = Math.Round(item.MMAllocationPlanItemRate, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
        }

        private void UpdateInfoAlternative(ICProductAlternativesInfo item)
        {
            decimal alternativeQty = 0;
            CurrentPlanItemDataSource.ForEach(o =>
            {
                if (o.MMAllocationPlanItemAltFactor == 0)
                    o.MMAllocationPlanItemAltFactor = 1m;

                if (o.MMAllocationPlanItemDepreciationRate == 0)
                {
                    o.MMAllocationPlanItemDepreciationRate = o.MMBatchProductProductionNormItemTSHH;
                    if (o.MMBatchProductProductionNormItemTSHH != 0)
                        o.MMAllocationPlanItemRate = item.ICProductAlternativeDepreciationRate / o.MMBatchProductProductionNormItemTSHH;
                    if (o.MMAllocationPlanItemRate == 0)
                        o.MMAllocationPlanItemRate = 1m;

                    o.MMAllocationPlanItemRate = Math.Round(o.MMAllocationPlanItemRate, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                }
                alternativeQty = o.MMAllocationPlanItemQty * o.MMAllocationPlanItemAltFactor * o.MMAllocationPlanItemRate;
                o.ICProductAlternativeProductQty = alternativeQty;
            });
            PlanItemGridView.RefreshData();
        }

        public void CalculateDetailInfo(ICProductAlternativesInfo alternativesInfo)
        {
            if (IsAlterOverConfigMaterial)
            {
                MMProductionNormItemConfigsInfo configInfo = new MMProductionNormItemConfigsInfo();
                decimal productBlocks = 0;
                decimal rate = 0;
                decimal alternativeQty = 0;
                alternativesInfo.ICProductAlternativeQty = 1m;
                alternativesInfo.ICProductAlternativeDepreciationRate = PlanItems.Max(o => o.MMBatchProductProductionNormItemTSHH);
                CurrentPlanItemDataSource.ForEach(o =>
                {
                    productBlocks = 0;
                    alternativeQty = o.MMAllocationPlanItemQty;
                    #region Khối tinh
                    configInfo = Configs.Where(cfg => cfg.FK_ICProductAttributeID == o.FK_ICProductAttributeWoodTypeID).FirstOrDefault();
                    if (configInfo != null)
                    {
                        if (configInfo.MMProductionNormItemConfigBlocks || configInfo.MMProductionNormItemConfigMDFBlocks)
                        {
                            productBlocks = (alternativesInfo.ICProductLength / 1000)
                                            * (alternativesInfo.ICProductWidth / 1000)
                                            * (alternativesInfo.ICProductHeight / 1000)
                                            * o.MMBatchProductProductionNormItemQuantity;
                        }
                        else if (configInfo.MMProductionNormItemConfigPlyWood || configInfo.MMProductionNormItemConfigVeneer)
                        {
                            productBlocks = (alternativesInfo.ICProductLength / 1000)
                                            * (alternativesInfo.ICProductWidth / 1000)
                                            * o.MMBatchProductProductionNormItemQuantity;
                        }
                        productBlocks = Math.Round(productBlocks, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                    }
                    #endregion
                    #region Phách
                    productBlocks = productBlocks * alternativesInfo.ICProductAlternativeDepreciationRate;
                    if (alternativesInfo.IsChangeAlternativeProduct)
                    {
                        rate = productBlocks == 0 ? 1m : o.MMAllocationPlanItemQty / productBlocks;
                        rate = Math.Round(rate, RoundingNumber.FormatN2, MidpointRounding.AwayFromZero);
                        if (rate > alternativesInfo.ICProductAlternativeQty)
                            alternativesInfo.ICProductAlternativeQty = rate;
                        o.MMAllocationPlanItemAltFactor = rate;
                    }
                    else if (alternativesInfo.IsChangeDepreciationRate)
                    {
                        rate = productBlocks == 0 ? 1m : o.MMAllocationPlanItemQty / productBlocks;
                        rate = o.MMBatchProductProductionNormItemTSHH == 0 ? 1m : rate / o.MMBatchProductProductionNormItemTSHH;
                        rate = Math.Round(rate, RoundingNumber.FormatN2, MidpointRounding.AwayFromZero);
                        if (rate > alternativesInfo.ICProductAlternativeDepreciationRate)
                            alternativesInfo.ICProductAlternativeDepreciationRate = rate;

                        o.MMAllocationPlanItemDepreciationRate = rate;
                        if (o.MMBatchProductProductionNormItemTSHH != 0)
                            o.MMAllocationPlanItemRate = o.MMAllocationPlanItemDepreciationRate / o.MMBatchProductProductionNormItemTSHH;
                        if (o.MMAllocationPlanItemRate == 0)
                            o.MMAllocationPlanItemRate = 1m;
                    }
                    #endregion
                });
                alternativesInfo.ICProductAlternativeQty = CurrentPlanItemDataSource.Max(o => o.MMAllocationPlanItemAltFactor);
                alternativesInfo.ICProductAlternativeDepreciationRate = CurrentPlanItemDataSource.Max(o => o.MMAllocationPlanItemDepreciationRate);
            }
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            List<ICProductAlternativesInfo> selected = ProductAlternativesList.Where(o => o.Selected).ToList();
            if (!selected.Any())
            {
                MessageBox.Show("Vui lòng xác định danh sách vật tư thay thế!", BaseLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selected.Where(o => o.ICProductAlternativeQty == 0).Any())
            {
                MessageBox.Show("Hệ số quy đổi không thể bằng 0. Vui lòng kiểm tra lại!", BaseLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selected.Where(o => o.ICProductAlternativeRate == 0).Any())
            {
                MessageBox.Show("Hệ số phân bổ không thể bằng 0. Vui lòng kiểm tra lại!", BaseLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SelectedObject = selected.FirstOrDefault();
            PlanItems.Clear();
            if (DicDataSource.ContainsKey(SelectedObject.VirtualID))
                PlanItems = DicDataSource[SelectedObject.VirtualID];

            DialogResult = DialogResult.OK;
            Close();
            ProductAlternativesList = selected;
        }
    }
}