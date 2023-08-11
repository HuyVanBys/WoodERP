using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using Localization;
using Microsoft.Office.Interop.Excel;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using System.Data.SqlClient;
using BOSERP.Procedure.Modules.AD.ImportData;

namespace BOSERP.Modules.ImportData
{
    public class ImportDataModule : BaseModuleERP
    {
        #region Public properties

        public BOSDateEdit SearchFromDateControl;
        public BOSDateEdit SearchToDateControl;
        public BOSGridControl GridControlResult;
        public BOSGridControl GridControlResult1;
        public BOSGridControl GridControlResult2;
        public DataSet DataSource { get; set; }
        public DataSet DataSource1 { get; set; }
        public DataSet DataSource2 { get; set; }
        public BOSLookupEdit fld_lkeShipmentTypeTab2;
        public CheckCostGridControl fld_dgcCheckCostGridControl;
        public MMCostUpdatePricesGridControl fld_dgcMMCostUpdatePricestGridControl;
        public CheckShipmentAffterFullReceiptGridControl fld_dgcCheckShipmentAffterCompleteReceipt;
        public BOSDateEdit fld_dteCheckToDate;
        public BOSDateEdit fld_dteCostDate1;
        public BOSDateEdit fld_dteDateTab2;
        public BOSDateEdit fld_dteCheckToDate3;
        public List<CheckCostInfo> dataCheckCostResult;
        public List<MMCostUpdatePricesInfo> CostUpdatePriceHistoryList;
        public List<CheckShipmentAffterCompleteReceiptInfo> ShipmentAffterCompleteReceiptList;
        #endregion

        public ImportDataModule()
        {
            Name = "ImportData";
            InitializeModule();

            SearchFromDateControl = (BOSDateEdit)Controls["fld_dteCheckFromDate"];
            if (SearchFromDateControl != null) SearchFromDateControl.DateTime = BOSUtil.GetMonthBeginDate(DateTime.Now);
            SearchToDateControl = (BOSDateEdit)Controls["fld_dteCheckToDate"];
            if (SearchToDateControl != null) SearchToDateControl.DateTime = BOSUtil.GetMonthEndDate(DateTime.Now);
            fld_lkeShipmentTypeTab2 = (BOSLookupEdit)Controls["fld_lkeShipmentTypeTab2"];
            if (fld_lkeShipmentTypeTab2 != null) fld_lkeShipmentTypeTab2.EditValue = "MaterialShipment";
            fld_dgcCheckCostGridControl = (CheckCostGridControl)Controls["fld_dgcCheckCostGridControl"];
            fld_dgcMMCostUpdatePricestGridControl = (MMCostUpdatePricesGridControl)Controls["fld_dgcMMCostUpdatePrices"];
            fld_dgcCheckShipmentAffterCompleteReceipt = (CheckShipmentAffterFullReceiptGridControl)Controls["fld_dgcCheckShipmentAffterCompleteReceipt"];

            fld_dteCheckToDate = (BOSDateEdit)Controls["fld_dteCheckToDate"];
            if (fld_dteCheckToDate != null) fld_dteCheckToDate.DateTime = DateTime.Now;
            fld_dteCostDate1 = (BOSDateEdit)Controls["fld_dteCostDate1"];
            if (fld_dteCostDate1 != null) fld_dteCostDate1.DateTime = DateTime.Now;
            fld_dteDateTab2 = (BOSDateEdit)Controls["fld_dteDateTab2"];
            if (fld_dteDateTab2 != null) fld_dteDateTab2.DateTime = DateTime.Now;
            fld_dteCheckToDate3 = (BOSDateEdit)Controls["fld_dteCheckToDate3"];
            if (fld_dteCheckToDate3 != null) fld_dteCheckToDate3.DateTime = DateTime.Now;
            dataCheckCostResult = new List<CheckCostInfo>();
            CostUpdatePriceHistoryList = new List<MMCostUpdatePricesInfo>();
        }

        public void CheckData(string type, DateTime fromDate, DateTime toDate, BOSMemoEdit resultView)
        {
            ICTransactionsController control = new ICTransactionsController();
            List<ICTransactionsInfo> dataResult = new List<ICTransactionsInfo>();
            dataResult = control.CheckDataBySomeCriteria(type, fromDate, toDate);
            if (dataResult == null)
            {
                BOSApp.ShowMessage("Vùng tìm dữ liệu quá lớn, vui lòng hạn chế ngày tìm kiếm!");
                return;
            }
            if (dataResult.Count() > 0)
            {
                resultView.Text = string.Join(Environment.NewLine, dataResult.Select(t => t.ICTransactionReferenceNo).Distinct().ToArray());
            }
            else
            {
                BOSApp.ShowMessage("Không tìm thấy dữ liệu");
                resultView.Text = string.Empty;
            }
        }
        public void GetDataError(string ProducttionCostNo, int factorID)
        {
            object[] arParam = new object[2];
            arParam[0] = ProducttionCostNo;
            arParam[1] = factorID;
            ADReportsController objMainObjectController = new ADReportsController();
            DataSource = objMainObjectController.GetTimeOutDataSet("ADReports_CheckCostNotAllowcation", 500, arParam);
            if (DataSource.Tables.Count > 0)
                GridControlResult.DataSource = DataSource.Tables[0];
            GridControlResult.RefreshDataSource();
        }
        public void GetDataShipmentAfterCompleteReceipt(string typeShipment, int operationID, DateTime fromDate, DateTime ToDate, DateTime prevDate)
        {
            object[] arParam = new object[5];
            arParam[0] = typeShipment;
            arParam[1] = operationID;
            arParam[2] = fromDate;
            arParam[3] = ToDate;
            arParam[4] = prevDate;
            CheckShipmentAffterCompleteReceiptControler objMainObjectController = new CheckShipmentAffterCompleteReceiptControler();
            List<CheckShipmentAffterCompleteReceiptInfo> result = objMainObjectController.GetDataErrorAndPrevProductionCost("ADReports_CheckShipmentAffterFullReceipt", 500, arParam);
            ShipmentAffterCompleteReceiptList = result;
            fld_dgcCheckShipmentAffterCompleteReceipt.DataSource = ShipmentAffterCompleteReceiptList;
            fld_dgcCheckShipmentAffterCompleteReceipt.RefreshDataSource();
        }
        public void GetDataShipmentErrorOperation(string LoaiModule, int OperationID, DateTime XuatTuNgay, DateTime XuatDenNgay, int ReesonID)
        {
            object[] arParam = new object[5];
            arParam[0] = LoaiModule;
            arParam[1] = OperationID;
            arParam[2] = XuatTuNgay;
            arParam[3] = XuatDenNgay;
            arParam[4] = ReesonID;
            ADReportsController objMainObjectController = new ADReportsController();
            DataSource2 = objMainObjectController.GetTimeOutDataSet("ADReports_CheckShipmentErrorOperation", 500, arParam);
            if (DataSource2.Tables.Count > 0)
                GridControlResult2.DataSource = DataSource2.Tables[0];
            GridControlResult2.RefreshDataSource();
        }
        public void GetDataErrorAndPrevProductionCost(string ProducttionCostNo, int factorID, int prevOperationID, int OperationID)
        {
            object[] arParam = new object[3];
            arParam[0] = ProducttionCostNo;
            arParam[1] = factorID;
            arParam[2] = prevOperationID;
            CheckCostControler objController = new CheckCostControler();
            dataCheckCostResult = objController.GetDataErrorAndPrevProductionCost("CheckCost_GetDataErrorAndPrevProductionCost", 500, arParam);
            if (fld_dgcCheckCostGridControl != null)
            {
                fld_dgcCheckCostGridControl.DataSource = dataCheckCostResult;
                fld_dgcCheckCostGridControl.RefreshDataSource();
            }
            arParam[2] = OperationID;
            CostUpdatePriceHistoryList = (new MMCostUpdatePricesController()).GetDataErrorAndPrevProductionCost("MMCostUpdatePrices_GetDataErrorAndPrevProductionCost", 500, arParam);
            if (fld_dgcMMCostUpdatePricestGridControl != null)
            {
                fld_dgcMMCostUpdatePricestGridControl.DataSource = CostUpdatePriceHistoryList;
                fld_dgcMMCostUpdatePricestGridControl.RefreshDataSource();
            }
        }
        public void UpdateSelectedItem(int reason)
        {
            ShipmentAffterCompleteReceiptList.ForEach(o =>
            {
                if (o.Selected)
                {
                    o.FK_ICImportAndExportReasonID = reason;
                }
            });
            fld_dgcMMCostUpdatePricestGridControl.RefreshDataSource();
        }
        public bool UpdateReferItem()
        {
            if (ShipmentAffterCompleteReceiptList.Where(o => o.Selected).Count() == 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn chi tiết cần chuyển phí!");
                return false;
            }
            if (ShipmentAffterCompleteReceiptList.Where(o => o.Selected && o.FK_ICImportAndExportReasonID == 0).Count() > 0)
            {
                BOSApp.ShowMessage("Vui lòng chỉ định lý do nhập xuất!");
                return false;
            }
            try
            {
                SaveItemWithDataTableType.SaveItemWithoutDelete<CheckShipmentAffterCompleteReceiptInfo>(ShipmentAffterCompleteReceiptList.Where(o => o.Selected && o.FK_ICImportAndExportReasonID >0).ToList(), "CheckShipmentAffterCompleteReceiptID", "CheckShipmentAffterCompleteReceipt", 0, BOSApp.CurrentUsersInfo.ADUserName);

            }
            catch (Exception ex)
            {
                BOSApp.ShowMessage("Có lổi xãy ra!" + Environment.NewLine + ex.Message);
                return false;
            }
            fld_dgcMMCostUpdatePricestGridControl.RefreshDataSource();
            return true;
        }
        public void UpdateCostPrice(string ProducttionCostNo, int factorID, int operationID)
        {
            if (dataCheckCostResult.Where(o => o.Selected).Count() == 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn chi tiết cần chuyển phí!");
                return;
            }
            if (dataCheckCostResult.Where(o => o.Selected && string.IsNullOrEmpty(o.MMProductionCostCalculationNoUpdate)).Count() > 0)
            {
                BOSApp.ShowMessage("Vui lòng chỉ định chứng từ phù hợp cần cập nhật!");
                return;
            }
            if (dataCheckCostResult.Where(o => o.Selected && o.TongchiphiTranfer <= 0).Count() > 0)
            {
                BOSApp.ShowMessage("Chi phí chuyển không thể <= 0!");
                return;
            }
            List<MMCostUpdatePricesInfo> PriceHistoryList = new List<MMCostUpdatePricesInfo>();
            dataCheckCostResult.ForEach(o => {
                if (o.Selected)
                {
                    MMCostUpdatePricesInfo newobj = new MMCostUpdatePricesInfo();
                    newobj.MMProductionCostCalculationNo = o.MMProductionCostCalculationNoUpdate;
                    newobj.FK_MMBatchProductID = o.FK_MMBatchProductID;
                    newobj.FK_ICProductID = o.ICProductID;
                    newobj.MMCostUpdatePriceProductNo = o.ICProductNo;
                    newobj.MMCostUpdatePriceProductName = o.ICProductName;
                    newobj.MMCostUpdatePriceSerialNo = o.MMBatchProductItemProductSerial;
                    newobj.FK_MMOperationID = o.FK_MMOperationID;
                    newobj.MMCostUpdatePriceShipmentNo = o.ICShipmentNo;
                    newobj.MMCostUpdatePriceReceiptQty = o.MMProductionCostCalculationPriceReceiptQty;
                    newobj.MMCostUpdatePriceUnitCost = o.MMProductionCostCalculationUnitCost;
                    newobj.MMCostUpdatePriceTotalCost = o.MMProductionCostCalculationTotalCost;
                    newobj.MMCostUpdatePriceTranferTotalCost = o.TongchiphiTranfer;
                    newobj.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;
                    PriceHistoryList.Add(newobj);
                }
            });
            if (PriceHistoryList.Count() > 0)
            {
                try
                {
                    SaveItemWithDataTableType.SaveItemWithoutDelete<MMCostUpdatePricesInfo>(PriceHistoryList, "MMCostUpdatePriceID", "MMCostUpdatePrices", 0, BOSApp.CurrentUsersInfo.ADUserName);
                    BOSApp.ShowMessage("Cập nhật xong, vui lòng chạy cập nhật chứng từ của TGT tương ứng!");


                    object[] arParam = new object[3];
                    arParam[0] = ProducttionCostNo;
                    arParam[1] = factorID;
                    arParam[2] = operationID;
                    CostUpdatePriceHistoryList = (new MMCostUpdatePricesController()).GetDataErrorAndPrevProductionCost("MMCostUpdatePrices_GetDataErrorAndPrevProductionCost", 500, arParam);
                    if (CostUpdatePriceHistoryList.Count() > 0 && fld_dgcMMCostUpdatePricestGridControl != null)
                    {
                        fld_dgcMMCostUpdatePricestGridControl.DataSource = CostUpdatePriceHistoryList;
                        fld_dgcMMCostUpdatePricestGridControl.RefreshDataSource();
                    }
                }
                catch (Exception ex)
                {
                    BOSApp.ShowMessage("Có lổi xãy ra!" + Environment.NewLine + ex.Message);
                }
                
            }
        }
        public MMProductionCostCalculationPricesInfo GetReferPrice(CheckCostInfo costObj)
        {
            MMProductionCostCalculationPricesInfo result = new MMProductionCostCalculationPricesInfo();
            List<MMProductionCostCalculationPricesInfo> PricesList = (new MMProductionCostCalculationPricesController()).GetPricesBySomeCreteria(costObj.MMProductionCostCalculationNoUpdate, costObj.MMBatchProductItemProductSerial, costObj.FK_MMBatchProductID, costObj.ICProductID);
            if (PricesList.Count() > 1)
            {
                BOSApp.ShowMessage("Có nhiều hơn 1 chi tiết tương ứng trong kỳ TGT này, vui lòng kiểm tra lại!");
                return null;
            }
            if (PricesList.Count() == 1)
            {
                return PricesList[0];
            }
            return null;
        }
        public bool UpdateShipmentReason(string ProducttionCostNo, int factorID ,int reasonID)
        {
            bool result = false;
            if (DataSource.Tables.Count > 0)
            {
                object[] arParam = new object[3];
                arParam[0] = ProducttionCostNo;
                arParam[1] = factorID;
                arParam[2] = reasonID;
                ADReportsController objMainObjectController = new ADReportsController();
                DataSource = objMainObjectController.GetTimeOutDataSet("ADReports_CheckCostNotAllowcationAndUpdate", 500, arParam);
                if (DataSource.Tables.Count > 0)
                {
                    GridControlResult.DataSource = DataSource.Tables[0];
                    GridControlResult.RefreshDataSource();
                    result = true;
                }

            }
            return result;
        }
        public bool UpdateShipmentErrorOperation(string LoaiModule, int OperationID, DateTime XuatTuNgay, DateTime XuatDenNgay, int ReesonID, int UpdateOperationID)
        {
            bool result = false;
            if (DataSource2.Tables.Count > 0)
            {
                object[] arParam = new object[6];
                arParam[0] = LoaiModule;
                arParam[1] = OperationID;
                arParam[2] = XuatTuNgay;
                arParam[3] = XuatDenNgay;
                arParam[4] = ReesonID;
                arParam[5] = UpdateOperationID;
                ADReportsController objMainObjectController = new ADReportsController();
                DataSource2 = objMainObjectController.GetTimeOutDataSet("ADReports_UpdateShipmentErrorOperation", 500, arParam);
                if (DataSource2.Tables.Count > 0)
                {
                    GridControlResult2.DataSource = DataSource2.Tables[0];
                    GridControlResult2.RefreshDataSource();
                    result = true;
                }

            }
            return result;
        }
        public void InitGridView(string DataSourceName, BOSERPScreen screen, BOSGroupControl fld_pnlMainGroup)
        {
            if (GridControlResult != null) return;
            string gridName = "fld_dgv" + DataSourceName;
            if (string.IsNullOrEmpty(gridName))
            {
                gridName = DataSourceName;
            }
            GridControlResult = BOSGridControl.Instance(gridName, this.Name);
            GridControlResult.Name = "fld_dgc" + DataSourceName;
            GridControlResult.Screen = screen;
            GridControlResult.BOSDataSource = DataSourceName;
            //GridControlResult.Width = fld_pnlMainGroup.Width - 10;
            //GridControlResult.Height = fld_pnlMainGroup.Height - 50;
            GridControlResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            GridControlResult.Dock = DockStyle.Fill;
            GridControlResult.TabIndex = 0;
            GridControlResult.InitializeControl();

            //Init the grid view of the result grid control
            GridView gridView = (GridView)GridControlResult.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;//dòng autofilter để nhập trực tiếp
            GridColumn column = new GridColumn();
            List<AAColumnAliasInfo> AddColumnNames;
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            DataSet ds;
            if (!BOSApp.LookupTables.ContainsKey("AAColumnAlias"))
            {
                ds = objAAColumnAliasController.GetColumnPermissionByTableName(DataSourceName);
            }
            else
            {
                ds = BOSApp.LookupTables[DataSourceName] as DataSet;
            }
            AddColumnNames = (List<AAColumnAliasInfo>)objAAColumnAliasController.GetListFromDataSet(ds);
            int visibleIndex = 1;
            if (AddColumnNames != null && AddColumnNames.Count > 0)
            {
                foreach (AAColumnAliasInfo objColumnAliasInfo in AddColumnNames.Where(x => x.AAColumnAliasCaption != "").ToList())
                {
                    column = new GridColumn();
                    column.Caption = objColumnAliasInfo.AAColumnAliasCaption;
                    column.FieldName = objColumnAliasInfo.AAColumnAliasName;
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = visibleIndex;
                    gridView.Columns.Add(column);
                    visibleIndex++;
                    GridControlResult.InitColumnRepositoryFormat(column, DataSourceName, objColumnAliasInfo.AAColumnAliasName);
                }
                //BOSGridControl.InitColumnFormat(GridControlResult);
            }
            else if (DataSource != null && DataSource.Tables.Count > 0)
            {
                foreach (DataColumn col in DataSource.Tables[0].Columns)
                {
                    column = new GridColumn();
                    column.Caption = col.Caption;
                    column.FieldName = col.ColumnName;
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = visibleIndex;
                    gridView.Columns.Add(column);
                    visibleIndex++;
                }
            }
            fld_pnlMainGroup.Controls.Add(GridControlResult);
        }
        public void InitGridViewTab1(string DataSourceName, BOSERPScreen screen, BOSGroupControl fld_pnlMainGroup)
        {
            if (GridControlResult1 != null) return;
            string gridName = "fld_dgv" + DataSourceName;
            if (string.IsNullOrEmpty(gridName))
            {
                gridName = DataSourceName;
            }
            GridControlResult1 = BOSGridControl.Instance(gridName, this.Name);
            GridControlResult1.Name = "fld_dgc" + DataSourceName;
            GridControlResult1.Screen = screen;
            GridControlResult1.BOSDataSource = DataSourceName;
            //GridControlResult.Width = fld_pnlMainGroup.Width - 10;
            //GridControlResult.Height = fld_pnlMainGroup.Height - 50;
            GridControlResult1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            GridControlResult1.Dock = DockStyle.Fill;
            GridControlResult1.TabIndex = 0;
            GridControlResult1.InitializeControl();

            //Init the grid view of the result grid control
            GridView gridView = (GridView)GridControlResult1.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;//dòng autofilter để nhập trực tiếp
            GridColumn column = new GridColumn();
            List<AAColumnAliasInfo> AddColumnNames;
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            DataSet ds;
            if (!BOSApp.LookupTables.ContainsKey("AAColumnAlias"))
            {
                ds = objAAColumnAliasController.GetColumnPermissionByTableName(DataSourceName);
            }
            else
            {
                ds = BOSApp.LookupTables[DataSourceName] as DataSet;
            }
            AddColumnNames = (List<AAColumnAliasInfo>)objAAColumnAliasController.GetListFromDataSet(ds);
            int visibleIndex = 1;
            if (AddColumnNames != null && AddColumnNames.Count > 0)
            {
                foreach (AAColumnAliasInfo objColumnAliasInfo in AddColumnNames.Where(x => x.AAColumnAliasCaption != "").ToList())
                {
                    column = new GridColumn();
                    column.Caption = objColumnAliasInfo.AAColumnAliasCaption;
                    column.FieldName = objColumnAliasInfo.AAColumnAliasName;
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = visibleIndex;
                    gridView.Columns.Add(column);
                    visibleIndex++;
                    GridControlResult1.InitColumnRepositoryFormat(column, DataSourceName, objColumnAliasInfo.AAColumnAliasName);
                }
                //BOSGridControl.InitColumnFormat(GridControlResult);
            }
            else if (DataSource1 != null && DataSource1.Tables.Count > 0)
            {
                foreach (DataColumn col in DataSource1.Tables[0].Columns)
                {
                    column = new GridColumn();
                    column.Caption = col.Caption;
                    column.FieldName = col.ColumnName;
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = visibleIndex;
                    gridView.Columns.Add(column);
                    visibleIndex++;
                }
            }
            fld_pnlMainGroup.Controls.Add(GridControlResult1);
        }
        public void InitGridViewTab2(string DataSourceName, BOSERPScreen screen, BOSGroupControl fld_pnlMainGroup)
        {
            if (GridControlResult2 != null) return;
            string gridName = "fld_dgv" + DataSourceName;
            if (string.IsNullOrEmpty(gridName))
            {
                gridName = DataSourceName;
            }
            GridControlResult2 = BOSGridControl.Instance(gridName, this.Name);
            GridControlResult2.Name = "fld_dgc" + DataSourceName;
            GridControlResult2.Screen = screen;
            GridControlResult2.BOSDataSource = DataSourceName;
            //GridControlResult.Width = fld_pnlMainGroup.Width - 10;
            //GridControlResult.Height = fld_pnlMainGroup.Height - 50;
            GridControlResult2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            GridControlResult2.Dock = DockStyle.Fill;
            GridControlResult2.TabIndex = 0;
            GridControlResult2.InitializeControl();

            //Init the grid view of the result grid control
            GridView gridView = (GridView)GridControlResult2.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;//dòng autofilter để nhập trực tiếp
            GridColumn column = new GridColumn();
            List<AAColumnAliasInfo> AddColumnNames;
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            DataSet ds;
            if (!BOSApp.LookupTables.ContainsKey("AAColumnAlias"))
            {
                ds = objAAColumnAliasController.GetColumnPermissionByTableName(DataSourceName);
            }
            else
            {
                ds = BOSApp.LookupTables[DataSourceName] as DataSet;
            }
            AddColumnNames = (List<AAColumnAliasInfo>)objAAColumnAliasController.GetListFromDataSet(ds);
            int visibleIndex = 1;
            if (AddColumnNames != null && AddColumnNames.Count > 0)
            {
                foreach (AAColumnAliasInfo objColumnAliasInfo in AddColumnNames.Where(x => x.AAColumnAliasCaption != "").ToList())
                {
                    column = new GridColumn();
                    column.Caption = objColumnAliasInfo.AAColumnAliasCaption;
                    column.FieldName = objColumnAliasInfo.AAColumnAliasName;
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = visibleIndex;
                    gridView.Columns.Add(column);
                    visibleIndex++;
                    GridControlResult2.InitColumnRepositoryFormat(column, DataSourceName, objColumnAliasInfo.AAColumnAliasName);
                }
                //BOSGridControl.InitColumnFormat(GridControlResult);
            }
            else if (DataSource2 != null && DataSource2.Tables.Count > 0)
            {
                foreach (DataColumn col in DataSource2.Tables[0].Columns)
                {
                    column = new GridColumn();
                    column.Caption = col.Caption;
                    column.FieldName = col.ColumnName;
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = visibleIndex;
                    gridView.Columns.Add(column);
                    visibleIndex++;
                }
            }
            fld_pnlMainGroup.Controls.Add(GridControlResult2);
        }
    }
}
