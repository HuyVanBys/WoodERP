using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.DeliveryPlan
{
    public partial class guiDeliveryPlanTruck : BOSERPScreen
    {
        #region Variables
        public List<ARDeliveryPlanTrucksInfo> SelectedObjects { get; set; }

        public List<ARDeliveryPlanTrucksInfo> DeliveryPlanTrucksList { get; set; }

        public List<ARDeliveryPlanItemsInfo> DeliveryPlanItemsList { get; set; }
        #endregion

        public guiDeliveryPlanTruck(List<ARDeliveryPlanTrucksInfo> deliveryPlanTrucks, List<ARDeliveryPlanItemsInfo> deliveryPlanItems)
        {
            InitializeComponent();
            DeliveryPlanTrucksList = new List<ARDeliveryPlanTrucksInfo>();
            DeliveryPlanTrucksList = deliveryPlanTrucks;
            DeliveryPlanItemsList = new List<ARDeliveryPlanItemsInfo>();
            DeliveryPlanItemsList = deliveryPlanItems;
        }

        private void guiAddWorkGroup_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dgcARDeliveryPlanTrucksGridControl.InvalidateDataSource(DeliveryPlanTrucksList);
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

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            SelectedObjects = DeliveryPlanTrucksList.Where(o => o.Selected == true).ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_lkeFK_PMPhaseTypeID_KeyUp(object sender, KeyEventArgs e)
        {
            string value = string.Empty;
            SearchData(value);
        }

        private void SearchData(String keyWord)
        {
            //fld_dgcProductWorkGroupsGridControl.DataSource = ProductWorkGroupList;
            //fld_dgcProductWorkGroupsGridControl.RefreshDataSource();

            //if (string.IsNullOrEmpty(keyWord))
            //    return;

            //DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcProductWorkGroupsGridControl.MainView;

            //List<GridColumn> lstColVisible = new List<GridColumn>();
            //lstColVisible.Add(gridView.Columns["FK_PMPhaseTypeID"]);

            //List<ICProductWorkGroupsInfo> bindingList = new List<ICProductWorkGroupsInfo>();

            //for (int i = 0; i < ProductWorkGroupList.Count; i++)
            //{
            //    ICProductWorkGroupsInfo obj = ProductWorkGroupList[i];
            //    bool isExist = false;
            //    foreach (GridColumn column in lstColVisible)
            //    {
            //        int rowHandle = gridView.GetRowHandle(i);
            //        string value = gridView.GetRowCellDisplayText(rowHandle, column);
            //        isExist = IsExistKeyWord(value, keyWord);
            //        if (isExist)
            //            break;
            //    }
            //    if (isExist)
            //    {
            //        bindingList.Add(obj);
            //    }
            //}
            //fld_dgcProductWorkGroupsGridControl.DataSource = bindingList;
            //fld_dgcProductWorkGroupsGridControl.RefreshDataSource();
        }

        private bool IsExistKeyWord(String value, String keyWord)
        {
            value = value.ToLower();
            keyWord = keyWord.ToLower();
            String[] arrElement = keyWord.Split(new char[] { ' ' });
            bool isExist = false;
            foreach (String element in arrElement)
            {
                if (value.Contains(element))
                {
                    isExist = true;
                }
            }

            if (!isExist)
            {
                value = BOSUtil.ConvertUnicodeStringToUnSign(value);
                foreach (String element in arrElement)
                {
                    if (value.Contains(element))
                    {
                        isExist = true;
                    }
                }
            }
            return isExist;
        }

        private void fld_btnAddProduct_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcARDeliveryPlanTrucksGridControl.MainView;
            ARDeliveryPlanTrucksInfo objDeliveryPlanTrucksInfo = (ARDeliveryPlanTrucksInfo)gridView.GetRow(gridView.FocusedRowHandle);

            List<ARDeliveryPlanTruckItemsInfo> deliveryPlanTruckItems = new List<ARDeliveryPlanTruckItemsInfo>();
            DeliveryPlanItemsList.Where(s => s.ARDeliveryPlanItemProductQty - s.ARDeliveryPlanItemPlanQty > 0)
                                 .ToList()
                                 .ForEach(o => deliveryPlanTruckItems.Add(ToARDeliveryPlanTruckItemsInfo(o)));
            if (deliveryPlanTruckItems.Count == 0)
                return;

            deliveryPlanTruckItems.ForEach(o =>
            {
                deliveryPlanTruckItems.ForEach(x =>
                {
                    if (x.FK_ARDeliveryPlanItemID == o.FK_ARDeliveryPlanItemID)
                    {
                        o.Selected = true;
                        o.ARDeliveryPlanTruckItemID = x.ARDeliveryPlanTruckItemID;
                    }
                });
            });

            guiDeliveryPlanTruckItem guiDeliveryPlanTruckItem = new guiDeliveryPlanTruckItem(deliveryPlanTruckItems);
            guiDeliveryPlanTruckItem.Module = this.Module;
            guiDeliveryPlanTruckItem.ShowDialog();
            if (guiDeliveryPlanTruckItem.DialogResult != DialogResult.OK)
                return;
            if (guiDeliveryPlanTruckItem.SelectedObjects.Count == 0)
                return;
            deliveryPlanTruckItems = (List<ARDeliveryPlanTruckItemsInfo>)guiDeliveryPlanTruckItem.SelectedObjects;
            objDeliveryPlanTrucksInfo.DeliveryPlanTruckItemsList = new BOSList<ARDeliveryPlanTruckItemsInfo>(TableName.ARDeliveryPlanTruckItemsTableName);
            objDeliveryPlanTrucksInfo.DeliveryPlanTruckItemsList.Invalidate(deliveryPlanTruckItems);
            objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckTotalQty = objDeliveryPlanTrucksInfo.DeliveryPlanTruckItemsList.Sum(o => o.ARDeliveryPlanTruckItemDeliveryQty);
            objDeliveryPlanTrucksInfo.DeliveryPlanTruckItemsList.All(o =>
            {
                DeliveryPlanItemsList.Where(s => s.FK_ARSaleOrderItemID == o.FK_ARSaleOrderItemID).FirstOrDefault().ARDeliveryPlanItemPlanQty += o.ARDeliveryPlanTruckItemDeliveryQty;
                return true;
            });
        }

        public ARDeliveryPlanTruckItemsInfo ToARDeliveryPlanTruckItemsInfo(ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo)
        {
            return new ARDeliveryPlanTruckItemsInfo()
            {
                ARDeliveryPlanTruckItemDeliveryQty = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty - objDeliveryPlanItemsInfo.ARDeliveryPlanItemPlanQty,
                FK_ARSaleOrderID = objDeliveryPlanItemsInfo.FK_ARSaleOrderID,
                FK_ICMeasureUnitID = objDeliveryPlanItemsInfo.FK_ICMeasureUnitID,
                FK_ICProductID = objDeliveryPlanItemsInfo.FK_ICProductID,
                FK_ARSaleOrderItemID = objDeliveryPlanItemsInfo.FK_ARSaleOrderItemID,
                FK_ARDeliveryPlanItemID = objDeliveryPlanItemsInfo.ARDeliveryPlanItemID,
                ARDeliveryPlanTruckItemProductNo = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductNo,
                ARDeliveryPlanTruckItemProductDesc = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductDesc,
                ARDeliveryPlanTruckItemAddress = objDeliveryPlanItemsInfo.ARDeliveryPlanItemAddress
            };
        }
    }
}