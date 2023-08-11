using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferPlan
{
    public partial class guiTransferToTruck : BOSERPScreen
    {
        #region Variables
        public BOSList<ICTransfersInfo> TransfersList { get; set; }

        public List<ARDeliveryPlanTrucksInfo> DeliveryPlanTrucksList { get; set; }

        DataTable dt;
        #endregion

        public guiTransferToTruck(List<ICTransfersInfo> transfers, List<ARDeliveryPlanTrucksInfo> objDeliveryPlanTrucksList)
        {
            InitializeComponent();
            TransfersList = new BOSList<ICTransfersInfo>(TableName.ICTransfersTableName);
            TransfersList.Invalidate(transfers);
            DeliveryPlanTrucksList = objDeliveryPlanTrucksList;
        }

        private void guiAttributionItemToTruck_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            dt = InitDataTable();
            FillDataTable(dt, TransfersList, DeliveryPlanTrucksList);
            fld_dgcTransferToTruckGridControl.DataSource = dt;
            GridView gridView = (GridView)fld_dgcTransferToTruckGridControl.MainView;
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
            DeliveryPlanTrucksList.ForEach(o => o.SaleOrderIDsList = new List<int>());
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in row.Table.Columns)
                {
                    if (column.ColumnName.Contains("Select_"))
                    {
                        foreach (ARDeliveryPlanTrucksInfo truck in DeliveryPlanTrucksList)
                        {
                            if (column.ColumnName == "Select_" + truck.ARDeliveryPlanTruckNumber)
                            {
                                if (!string.IsNullOrEmpty(row[column.ColumnName].ToString()) && bool.Parse(row[column.ColumnName].ToString()))
                                    truck.TransferIDsList.Add(Int32.Parse(row["ICTransferID"].ToString()));
                            }
                        }
                    }
                }
            }

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
        }

        private void FillDataTable(DataTable dt, List<ICTransfersInfo> transfers, List<ARDeliveryPlanTrucksInfo> deliveryPlanTruckList)
        {
            ARDeliveryPlanTruckItemsController objDeliveryPlanTruckItemsController = new ARDeliveryPlanTruckItemsController();
            List<ARDeliveryPlanTruckItemsInfo> truckItemList = new List<ARDeliveryPlanTruckItemsInfo>();
            foreach (ICTransfersInfo item in transfers)
            {
                DataRow newRow = dt.NewRow();
                newRow["ICTransferID"] = item.ICTransferID;
                //newRow["ACObjectName"] = item.ACObjectName;
                newRow["ICTransferNo"] = item.ICTransferNo;
                //newRow["ARSaleOrderSaleAgreement"] = item.ARSaleOrderSaleAgreement;

                foreach (ARDeliveryPlanTrucksInfo truck in deliveryPlanTruckList)
                {
                    if (truck.TransferIDsList == null)
                        truck.TransferIDsList = new List<int>();
                    if (truck.TransferIDsList.Any(o => o == item.ICTransferID))
                        newRow["Select_" + truck.ARDeliveryPlanTruckNumber] = true;
                }

                dt.Rows.Add(newRow);
            }

        }
        public void ChangeRowItemlist(DataRow row)
        {
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
            //BandedGridColumn gridColumnACObjectName = CreateNewColumn("ACObjectName", "Đối tượng", gridBand, false);
            BandedGridColumn gridColumnICTransferNo = CreateNewColumn("ICTransferNo", "Mã chuyển kho", gridBand, false);
            //BandedGridColumn gridColumnARSaleOrderSaleAgreement = CreateNewColumn("ARSaleOrderSaleAgreement", "Số hợp đồng", gridBand, false);

            //bandedView.Columns.Add(gridColumnACObjectName);
            bandedView.Columns.Add(gridColumnICTransferNo);
            //bandedView.Columns.Add(gridColumnARSaleOrderSaleAgreement);  

            //gridBand.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridBand.MinWidth = 400;

            if (DeliveryPlanTrucksList != null && DeliveryPlanTrucksList.Count > 0)
            {
                foreach (ARDeliveryPlanTrucksInfo truck in DeliveryPlanTrucksList)
                {
                    GridBand band = CreateNewGridBand(truck.ARDeliveryPlanTruckNumber, truck.ARDeliveryPlanTruckName);
                    bandedView.Bands.Add(band);
                    band.MinWidth = 100;
                    BandedGridColumn gridColumnTruckQty = CreateNewColumn("Select_" + truck.ARDeliveryPlanTruckNumber, "Phân bổ", band, true);

                    bandedView.Columns.Add(gridColumnTruckQty);
                }
            }

            return bandedView;
        }
        private DataTable InitDataTable()
        {
            DataTable dt = new DataTable();

            if (DeliveryPlanTrucksList != null && DeliveryPlanTrucksList.Count > 0)
            {
                foreach (ARDeliveryPlanTrucksInfo truck in DeliveryPlanTrucksList)
                {
                    dt.Columns.Add(new DataColumn("Select_" + truck.ARDeliveryPlanTruckNumber, typeof(bool)));
                }
            }
            dt.Columns.Add(new DataColumn("ICTransferID", typeof(string)));
            //dt.Columns.Add(new DataColumn("ACObjectName", typeof(string)));
            dt.Columns.Add(new DataColumn("ICTransferNo", typeof(string)));
            //dt.Columns.Add(new DataColumn("ARSaleOrderSaleAgreement", typeof(string)));

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