using BOSCommon.Constants;
using BOSCommon.Extensions.Helper;
using BOSLib;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.DeliveryPlan
{
    public partial class guiAttributionItemToTruck : BOSERPScreen
    {
        #region Variables
        public BOSList<ARDeliveryPlanItemsInfo> DeliveryPlanItemsList { get; set; }

        public List<ARDeliveryPlanTrucksInfo> DeliveryPlanTrucksList { get; set; }

        DataTable dt;
        #endregion

        public guiAttributionItemToTruck(List<ARDeliveryPlanItemsInfo> deliveryPlanItems, List<ARDeliveryPlanTrucksInfo> objDeliveryPlanTrucksList)
        {
            InitializeComponent();
            DeliveryPlanItemsList = new BOSList<ARDeliveryPlanItemsInfo>(TableName.ARDeliveryPlanItemsTableName);
            DeliveryPlanItemsList.Invalidate(deliveryPlanItems);
            DeliveryPlanItemsList.ForEach(o =>
            {
                o.ARDeliveryPlanItemProductQty = o.ARDeliveryPlanItemProductQty - o.ARDeliveryPlanItemCancelQty;
            });
            DeliveryPlanTrucksList = objDeliveryPlanTrucksList;
        }

        private void guiAttributionItemToTruck_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            //this.Text = string.Format(DeliveryPlanLocalizedResources.guiAttributionItemToTruckTitle, DeliveryPlanTrucksInfo.ARDeliveryPlanTruckName, DeliveryPlanTrucksInfo.ARDeliveryPlanTruckNumber);
            dt = InitDataTable();
            FillDataTable(dt, DeliveryPlanItemsList, DeliveryPlanTrucksList);
            fld_dgcAttributionItemToTruckGridControl.DataSource = dt;
            GridView gridView = (GridView)fld_dgcAttributionItemToTruckGridControl.MainView;
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
            DeliveryPlanTrucksList.ForEach(o => o.DeliveryPlanTruckItemsList = new BOSList<ARDeliveryPlanTruckItemsInfo>(TableName.ARDeliveryPlanTruckItemsTableName));
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow[] rows = dt.Select("ARDeliveryPlanItemRemainedQty < 0");
                if (rows != null && rows.Count() > 0)
                {
                    MessageBox.Show(DeliveryPlanLocalizedResources.CheckDeliveryPlanItemRemainedQty, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string columnName = string.Empty;
                DeliveryPlanTrucksList.ForEach(o =>
                {
                    columnName = "SLNhap_" + StringHelper.ConvertUnicodeStringToUnSign(o.ARDeliveryPlanTruckNumber);
                    rows = dt.Select(columnName + " < 0");
                    if (rows != null && rows.Count() > 0)
                    {
                        MessageBox.Show(DeliveryPlanLocalizedResources.CheckDeliveryPlanItemAttributionQty, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                });
            }
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in row.Table.Columns)
                {
                    if (column.ColumnName.Contains("SLNhap"))
                    {
                        foreach (ARDeliveryPlanTrucksInfo truck in DeliveryPlanTrucksList)
                        {
                            if (column.ColumnName == "SLNhap_" + StringHelper.ConvertUnicodeStringToUnSign(truck.ARDeliveryPlanTruckNumber))
                            {
                                ARDeliveryPlanTruckItemsInfo objectsInfo;
                                if (decimal.Parse(row[column.ColumnName].ToString()) > 0)
                                {
                                    objectsInfo = new ARDeliveryPlanTruckItemsInfo();
                                    objectsInfo.FK_ARDeliveryPlanTruckID = truck.ARDeliveryPlanTruckID;
                                    objectsInfo.FK_ICProductTruckID = truck.FK_ICProductID;
                                    objectsInfo.FK_ARDeliveryPlanID = truck.FK_ARDeliveryPlanID;
                                    objectsInfo.ARDeliveryPlanTruckItemDeliveryQty = decimal.Parse(row[column.ColumnName].ToString());
                                    objectsInfo.FK_ICProductID = Int32.Parse(row["FK_ICProductID"].ToString());
                                    objectsInfo.ARDeliveryPlanTruckNumber = truck.ARDeliveryPlanTruckNumber;
                                    objectsInfo.FK_ARSaleOrderID = Int32.Parse(row["FK_ARSaleOrderID"].ToString());
                                    objectsInfo.FK_ICMeasureUnitID = Int32.Parse(row["FK_ICMeasureUnitID"].ToString());
                                    objectsInfo.FK_ARSaleOrderItemID = Int32.Parse(row["FK_ARSaleOrderItemID"].ToString());
                                    objectsInfo.FK_ARDeliveryPlanItemID = Int32.Parse(row["FK_ARDeliveryPlanItemID"].ToString());
                                    objectsInfo.ARDeliveryPlanTruckItemProductNo = row["ARDeliveryPlanTruckItemProductNo"].ToString();
                                    objectsInfo.ARDeliveryPlanTruckItemProductDesc = row["ARDeliveryPlanTruckItemProductDesc"].ToString();
                                    objectsInfo.ARDeliveryPlanTruckItemAddress = row["ARDeliveryPlanTruckItemAddress"].ToString();
                                    objectsInfo.ARDeliveryPlanTruckItemProductWidth = decimal.Parse(row["ARDeliveryPlanTruckItemProductWidth"].ToString());
                                    objectsInfo.ARDeliveryPlanTruckItemProductHeight = decimal.Parse(row["ARDeliveryPlanTruckItemProductHeight"].ToString());
                                    objectsInfo.ARDeliveryPlanTruckItemProductLength = decimal.Parse(row["ARDeliveryPlanTruckItemProductLength"].ToString());
                                    truck.DeliveryPlanTruckItemsList.Add(objectsInfo);
                                }
                            }
                        }
                    }
                }
            }


            //SelectedObjects = DeliveryPlanItemsList.Where(o => o.Selected == true).ToList();            
            //if (SelectedObjects.Count == 0)
            //{
            //    MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            this.DialogResult = DialogResult.OK;
            this.Close();
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

        private void fld_chkCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            //GridView gridView = (GridView)fld_dgcAttributionItemToTruckGridControl.MainView;
            //BOSList<ARDeliveryPlanItemsInfo> listView = new BOSList<ARDeliveryPlanItemsInfo>();
            //BindingSource bds = (BindingSource)fld_dgcAttributionItemToTruckGridControl.DataSource;

            //BOSList<ARDeliveryPlanItemsInfo> objects = (BOSList<ARDeliveryPlanItemsInfo>)bds.DataSource;
            //for (int j = 0; j < gridView.RowCount; j++)
            //{
            //    ARDeliveryPlanItemsInfo objDataViewPermissionsInfo = (ARDeliveryPlanItemsInfo)gridView.GetRow(j);
            //    if (objDataViewPermissionsInfo != null)
            //    {
            //        listView.Add(objDataViewPermissionsInfo);
            //    }
            //}
            //for (int i = 0; i < objects.Count; i++)
            //{
            //    foreach (var dataViewItem in listView)
            //    {
            //        if (objects[i] == dataViewItem)
            //        {
            //            objects[i].Selected = fld_chkCheckAll.Checked;
            //        }
            //    }

            //}
            //fld_dgcAttributionItemToTruckGridControl.RefreshDataSource();
        }

        private void FillDataTable(DataTable dt, List<ARDeliveryPlanItemsInfo> deliveryPlanItemList, List<ARDeliveryPlanTrucksInfo> deliveryPlanTruckList)
        {
            MMOperationsController operationController = new MMOperationsController();
            ARDeliveryPlanTruckItemsController objDeliveryPlanTruckItemsController = new ARDeliveryPlanTruckItemsController();
            List<ARDeliveryPlanTruckItemsInfo> truckItemList = new List<ARDeliveryPlanTruckItemsInfo>(); ;
            List<ARDeliveryPlanTruckItemsInfo> truckItemListByProduct;
            foreach (ARDeliveryPlanItemsInfo item in deliveryPlanItemList)
            {
                DataRow newRow = dt.NewRow();
                newRow["ARDeliveryPlanItemProductName"] = item.ARDeliveryPlanItemProductName;
                newRow["ARDeliveryPlanItemQty"] = item.ARDeliveryPlanItemProductQty;
                newRow["FK_ARSaleOrderID"] = item.FK_ARSaleOrderID;
                newRow["FK_ICMeasureUnitID"] = item.FK_ICMeasureUnitID;
                newRow["FK_ARSaleOrderItemID"] = item.FK_ARSaleOrderItemID;
                newRow["FK_ARDeliveryPlanItemID"] = item.ARDeliveryPlanItemID;
                newRow["ARDeliveryPlanTruckItemProductNo"] = item.ARDeliveryPlanItemProductNo;
                newRow["ARDeliveryPlanTruckItemProductDesc"] = item.ARDeliveryPlanItemProductDesc;
                newRow["ARDeliveryPlanTruckItemAddress"] = item.ARDeliveryPlanItemAddress;
                newRow["ARDeliveryPlanTruckItemProductWidth"] = item.ARDeliveryPlanItemProductWidth;
                newRow["ARDeliveryPlanTruckItemProductHeight"] = item.ARDeliveryPlanItemProductHeight;
                newRow["ARDeliveryPlanTruckItemProductLength"] = item.ARDeliveryPlanItemProductLength;
                newRow["ACObjectName"] = item.ACObjectName;
                newRow["ARSaleOrderNo"] = item.ARDeliveryPlanItemSaleOrderNo;
                decimal SLChuaPB = 0;
                decimal TongSLPB = 0;
                newRow["FK_ICProductID"] = item.FK_ICProductID;

                foreach (ARDeliveryPlanTrucksInfo truck in deliveryPlanTruckList)
                {
                    if (truck.DeliveryPlanTruckItemsList == null)
                        truck.DeliveryPlanTruckItemsList = new BOSList<ARDeliveryPlanTruckItemsInfo>();
                    truckItemList = truck.DeliveryPlanTruckItemsList.ToList();
                    decimal SLPB = 0;
                    truckItemListByProduct = truckItemList.Where(t => t.FK_ICProductID == item.FK_ICProductID
                                                                    && t.FK_ARSaleOrderItemID == item.FK_ARSaleOrderItemID
                                                                    && t.FK_ARDeliveryPlanTruckID == truck.ARDeliveryPlanTruckID).ToList();
                    if (truckItemListByProduct != null && truckItemListByProduct.Count > 0)
                    {
                        SLPB = truckItemListByProduct.Sum(i => i.ARDeliveryPlanTruckItemDeliveryQty);
                    }
                    if (SLPB != 0)
                    {
                        newRow["SLNhap_" + StringHelper.ConvertUnicodeStringToUnSign(truck.ARDeliveryPlanTruckNumber)] = decimal.Parse(SLPB.ToString("N0"));
                        TongSLPB += SLPB;
                    }
                    else
                        newRow["SLNhap_" + StringHelper.ConvertUnicodeStringToUnSign(truck.ARDeliveryPlanTruckNumber)] = decimal.Parse("0");
                }
                SLChuaPB = item.ARDeliveryPlanItemProductQty - TongSLPB;
                if (TongSLPB != 0)
                {
                    newRow["ARDeliveryPlanItemAttributionQty"] = decimal.Parse(TongSLPB.ToString("N0"));
                }
                else
                {
                    newRow["ARDeliveryPlanItemAttributionQty"] = decimal.Parse("0"); ;
                }
                if (SLChuaPB != 0)
                {
                    newRow["ARDeliveryPlanItemRemainedQty"] = decimal.Parse(SLChuaPB.ToString("N0"));
                }
                else
                {
                    newRow["ARDeliveryPlanItemRemainedQty"] = decimal.Parse("0");
                }
                dt.Rows.Add(newRow);
            }

        }
        public void ChangeRowItemlist(DataRow row)
        {
            decimal TongSl = 0;
            foreach (ARDeliveryPlanTrucksInfo truck in DeliveryPlanTrucksList)
            {
                TongSl += decimal.Parse(row["SLNhap_" + StringHelper.ConvertUnicodeStringToUnSign(truck.ARDeliveryPlanTruckNumber)].ToString());
            }
            if (TongSl != 0)
            {
                row["ARDeliveryPlanItemAttributionQty"] = decimal.Parse(TongSl.ToString());
            }
            else
                row["ARDeliveryPlanItemAttributionQty"] = decimal.Parse(TongSl.ToString());
            decimal SlDPB = decimal.Parse(row["ARDeliveryPlanItemQty"].ToString()) - TongSl;
            if (SlDPB != 0)
            {
                row["ARDeliveryPlanItemRemainedQty"] = decimal.Parse(SlDPB.ToString());
            }
            else
                row["ARDeliveryPlanItemRemainedQty"] = decimal.Parse("0");
        }
        public BandedGridView InitBandedGridView()
        {
            BandedGridView bandedView = new BandedGridView();
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;

            //Thông tin
            GridBand gridBand = CreateNewGridBand("ARDeliveryPlanName", ReportLocalizedResources.ICProductGoupInfo);
            bandedView.Bands.Add(gridBand);
            BandedGridColumn gridColumnDeliveryPlanItemProductName = CreateNewColumn("ARDeliveryPlanItemProductName", "Tên sản phẩm", gridBand, false);
            BandedGridColumn gridColumnDeliveryPlanTruckItemProductNo = CreateNewColumn("ARDeliveryPlanTruckItemProductNo", "Mã sản phẩm", gridBand, false);
            BandedGridColumn gridColumnDeliveryPlanTruckItemProductDesc = CreateNewColumn("ARDeliveryPlanTruckItemProductDesc", "Mô tả", gridBand, false);
            BandedGridColumn gridColumnACObjectName = CreateNewColumn("ACObjectName", "Đối tượng", gridBand, false);
            BandedGridColumn gridColumnARSaleOrderNo = CreateNewColumn("ARSaleOrderNo", "Mã đơn bán hàng", gridBand, false);

            bandedView.Columns.Add(gridColumnDeliveryPlanItemProductName);
            bandedView.Columns.Add(gridColumnDeliveryPlanTruckItemProductNo);
            bandedView.Columns.Add(gridColumnDeliveryPlanTruckItemProductDesc);
            bandedView.Columns.Add(gridColumnACObjectName);
            bandedView.Columns.Add(gridColumnARSaleOrderNo);

            //gridBand.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridBand.MinWidth = 400;

            if (DeliveryPlanTrucksList != null && DeliveryPlanTrucksList.Count > 0)
            {
                foreach (ARDeliveryPlanTrucksInfo truck in DeliveryPlanTrucksList)
                {
                    GridBand band = CreateNewGridBand(truck.ARDeliveryPlanTruckNumber, truck.ARDeliveryPlanTruckName);
                    bandedView.Bands.Add(band);
                    band.MinWidth = 100;
                    BandedGridColumn gridColumnTruckQty = CreateNewColumn("SLNhap_" + StringHelper.ConvertUnicodeStringToUnSign(truck.ARDeliveryPlanTruckNumber), "Số lượng nhập", band, true);

                    bandedView.Columns.Add(gridColumnTruckQty);
                }
            }
            BandedGridColumn gridColumnDeliveryPlanItemQty = CreateNewColumn("ARDeliveryPlanItemQty", "SL sản phẩm", gridBand, false);
            BandedGridColumn gridColumnDeliveryPlanItemRemainedQty = CreateNewColumn("ARDeliveryPlanItemRemainedQty", "SL chưa phân bổ", gridBand, false);
            BandedGridColumn gridColumnDeliveryPlanItemAttributionQty = CreateNewColumn("ARDeliveryPlanItemAttributionQty", "SL Đã phân bổ", gridBand, false);
            bandedView.Columns.Add(gridColumnDeliveryPlanItemQty);
            bandedView.Columns.Add(gridColumnDeliveryPlanItemRemainedQty);
            bandedView.Columns.Add(gridColumnDeliveryPlanItemAttributionQty);
            return bandedView;
        }
        private DataTable InitDataTable()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("ARDeliveryPlanItemProductName", typeof(string)));

            if (DeliveryPlanTrucksList != null && DeliveryPlanTrucksList.Count > 0)
            {
                foreach (ARDeliveryPlanTrucksInfo truck in DeliveryPlanTrucksList)
                {
                    dt.Columns.Add(new DataColumn("SLNhap_" + StringHelper.ConvertUnicodeStringToUnSign(truck.ARDeliveryPlanTruckNumber), typeof(decimal)));
                }
            }
            dt.Columns.Add(new DataColumn("ARDeliveryPlanItemQty", typeof(string)));
            dt.Columns.Add(new DataColumn("ARDeliveryPlanItemRemainedQty", typeof(decimal)));
            dt.Columns.Add(new DataColumn("ARDeliveryPlanItemAttributionQty", typeof(decimal)));
            dt.Columns.Add(new DataColumn("FK_ICProductID", typeof(string)));
            dt.Columns.Add(new DataColumn("FK_ARSaleOrderID", typeof(string)));
            dt.Columns.Add(new DataColumn("FK_ICMeasureUnitID", typeof(string)));
            dt.Columns.Add(new DataColumn("FK_ARSaleOrderItemID", typeof(string)));
            dt.Columns.Add(new DataColumn("FK_ARDeliveryPlanItemID", typeof(string)));
            dt.Columns.Add(new DataColumn("ARDeliveryPlanTruckItemProductNo", typeof(string)));
            dt.Columns.Add(new DataColumn("ARDeliveryPlanTruckItemProductDesc", typeof(string)));
            dt.Columns.Add(new DataColumn("ARDeliveryPlanTruckItemAddress", typeof(string)));
            dt.Columns.Add(new DataColumn("ARDeliveryPlanTruckItemProductWidth", typeof(string)));
            dt.Columns.Add(new DataColumn("ARDeliveryPlanTruckItemProductHeight", typeof(string)));
            dt.Columns.Add(new DataColumn("ARDeliveryPlanTruckItemProductLength", typeof(string)));
            dt.Columns.Add(new DataColumn("ACObjectName", typeof(string)));
            dt.Columns.Add(new DataColumn("ARSaleOrderNo", typeof(string)));

            return dt;
        }
        private GridBand CreateNewGridBand(string name, string header)
        {
            GridBand gridBand1 = new GridBand();
            gridBand1.Caption = header;
            gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand1.Name = name;
            return gridBand1;
        }
        private BandedGridColumn CreateNewColumnNoneBand(string name, string header)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = name;
            bandedColumn.Caption = header;
            bandedColumn.FieldName = name;
            bandedColumn.Visible = true;
            bandedColumn.OptionsColumn.AllowEdit = false;
            // bandedColumn.OwnerBand = owner;
            return bandedColumn;
        }
        private BandedGridColumn CreateNewColumn(string name, string header, GridBand owner, bool allowEdit)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = name;
            bandedColumn.Caption = header;
            bandedColumn.FieldName = name;
            bandedColumn.Visible = true;
            bandedColumn.OptionsColumn.AllowEdit = allowEdit;
            bandedColumn.OwnerBand = owner;
            return bandedColumn;
        }
    }
}