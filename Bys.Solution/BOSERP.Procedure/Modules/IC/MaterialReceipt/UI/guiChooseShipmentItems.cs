using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BOSERP.Modules.MaterialReceipt
{
    public partial class guiChooseShipmentItems : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<ICShipmentItemsInfo> SelectedObjects { get; set; }

        public List<IPShipmentItemsInfo> ImportObjects { get; set; }

        #endregion

        public guiChooseShipmentItems()
        {
            InitializeComponent();
        }

        private void guiChooseShipmentItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SetDefault();
            SelectedObjects = new List<ICShipmentItemsInfo>();
            GridView gridView = (GridView)fld_dgcICShipmentItemsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            GridControlHelper = new GridControlHelper(gridView);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            List<ICShipmentItemsInfo> listSelectedShipmentsInfo = new List<ICShipmentItemsInfo>();
            SelectedObjects = GridControlHelper.Selection.OfType<ICShipmentItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (ImportObjects != null && ImportObjects.Count > 0)
            {
                if (ImportObjects.Where(o => !string.IsNullOrWhiteSpace(o.MessageError)).Count() > 0)
                {
                    string MessageError = string.Join("", ImportObjects.Select(o => o.MessageError).ToArray());
                    MessageBox.Show(MessageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string ErrorMessage = string.Empty;
                List<IPShipmentItemsInfo> listIPShipmentsInfo = ImportObjects.GroupBy(o => new
                {
                    o.FK_MMBatchProductID,
                    o.FK_ICProductID,
                    o.ICShipmentItemProductNo,
                    o.MMBatchProductNo
                }).Select(o => new IPShipmentItemsInfo()
                {
                    FK_MMBatchProductID = o.Key.FK_MMBatchProductID,
                    FK_ICProductID = o.Key.FK_ICProductID,
                    ICShipmentItemProductNo = o.Key.ICShipmentItemProductNo,
                    MMBatchProductNo = o.Key.MMBatchProductNo
                }).ToList();
                listIPShipmentsInfo.ForEach(o =>
                {
                    if (SelectedObjects.Where(p => p.FK_ICProductID == o.FK_ICProductID && p.FK_MMBatchProductID == o.FK_MMBatchProductID).Count() == 0)
                    {
                        ErrorMessage += string.Format("Mã gỗ xuất [{0}] của lệnh sản xuất [{1}] không được chọn bên danh sách tìm kiếm.", o.ICShipmentItemProductNo, o.MMBatchProductNo);
                        ErrorMessage += Environment.NewLine;
                    }    
                });
                if (!string.IsNullOrWhiteSpace(ErrorMessage))
                {
                    MessageBox.Show(ErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ImportObjects.Count > SelectedObjects.Count)
                {
                    MessageBox.Show("Số dòng chọn xuất kho nhỏ hơn số dòng import, vui lòng chọn thêm", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                ICImportAndExportReasonsController objImportAndExportReasonsController = new ICImportAndExportReasonsController();
                int recordNumber = 1;
                ImportObjects.ForEach(o =>
                {
                    if (o.FK_ICShipmentItemID == 0 && SelectedObjects.Where(p => o.FK_ICProductID == p.FK_ICProductID && p.FK_MMBatchProductID == o.FK_MMBatchProductID).Count() > 0)
                    {
                        objShipmentItemsInfo = SelectedObjects.Where(p => o.FK_ICProductID == p.FK_ICProductID && p.FK_MMBatchProductID == o.FK_MMBatchProductID).OrderBy(p => p.Id).FirstOrDefault();
                        SelectedObjects.RemoveAll(r => r.Id == objShipmentItemsInfo.Id);
                    }
                    else
                    {
                        objShipmentItemsInfo = (ICShipmentItemsInfo)listSelectedShipmentsInfo.Where(p => o.ICShipmentItemProductNo == p.ICShipmentItemCode06Combo && p.FK_MMBatchProductID == o.FK_MMBatchProductID).OrderByDescending(p => p.Id).FirstOrDefault().Clone();
                        objShipmentItemsInfo.ICShipmentItemProductSerialNo = objShipmentItemsInfo.ICShipmentItemProductSerialNo.Substring(0, objShipmentItemsInfo.ICShipmentItemProductSerialNo.Length - 3);
                    }
                    if (objShipmentItemsInfo == null)
                        return;
                    objShipmentItemsInfo.FK_ICProductID = o.FK_ICShipmentItemProductID;
                    objShipmentItemsInfo.ICShipmentItemCode06Combo = o.ICShipmentItemProductNo;
                    objShipmentItemsInfo.ICShipmentItemProductName = o.ICProductName;
                    objShipmentItemsInfo.FK_ICMeasureUnitID = o.FK_ICMeasureUnitID;
                    objShipmentItemsInfo.ICShipmentItemHeight = o.ICShipmentItemProductHeight;
                    objShipmentItemsInfo.ICShipmentItemLength = o.ICShipmentItemProductLength;
                    objShipmentItemsInfo.ICShipmentItemWidth = o.ICShipmentItemProductWidth;
                    objShipmentItemsInfo.ICShipmentItemWoodQty = o.ICShipmentItemQty1;
                    objShipmentItemsInfo.ICShipmentItemProductQty = o.ICShipmentItemProductQty;
                    objShipmentItemsInfo.ICShipmentItemProductFactor = 1M;
                    objShipmentItemsInfo.ICShipmentItemProductExchangeQty = o.ICShipmentItemProductQty;
                    objShipmentItemsInfo.ICShipmentItemProductUnitCost = o.ICShipmentItemProductUnitPrice;
                    objShipmentItemsInfo.ICShipmentItemSOName = o.ICShipmentItemSOName;
                    objShipmentItemsInfo.FK_ICProductSerieID = 0;
                    objShipmentItemsInfo.ICShipmentItemProductSerialNo = objShipmentItemsInfo.ICShipmentItemProductSerialNo + "." + recordNumber.ToString().PadLeft(2, '0');
                    ICImportAndExportReasonsInfo objImportAndExportReasonsInfo = (ICImportAndExportReasonsInfo)objImportAndExportReasonsController.GetObjectByName(o.ICImportAndExportReasonName);
                    objShipmentItemsInfo.FK_ICImportAndExportReasonID = objImportAndExportReasonsInfo != null ? objImportAndExportReasonsInfo.ICImportAndExportReasonID : 0;
                    listSelectedShipmentsInfo.Add(objShipmentItemsInfo);
                    recordNumber++;
                });
            }
            if (listSelectedShipmentsInfo.Count > 0)
                SelectedObjects = listSelectedShipmentsInfo;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SetDefault()
        {
            fld_dteFromDate.EditValue = BOSApp.GetCurrentServerDate();
            fld_dteToDate.EditValue = BOSApp.GetCurrentServerDate().AddDays(7);
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            int shipmentID = Convert.ToInt32(fld_lkeFK_ICShipmentID.EditValue);
            int workShopID = Convert.ToInt32(fld_lkeFK_MMWorkShopID.EditValue);
            int lineID = Convert.ToInt32(fld_lkeFK_LineID.EditValue);
            DateTime fromDate = Convert.ToDateTime(fld_dteFromDate.DateTime);
            DateTime toDate = Convert.ToDateTime(fld_dteToDate.DateTime);
            int batchProductID = Convert.ToInt32(fld_lkeFK_MMBatchProductID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            int woodType = Convert.ToInt32(fld_lkeICProductIdentifyWoodType.EditValue);
            List<ICShipmentItemsInfo> shipments = (new ICShipmentItemsController()).GetShipmentItemForMaterialReceiptBySomeCriteria(
                                                                                        BOSApp.CurrentUsersInfo.ADUserID,
                                                                                        ModuleName.MaterialShipment,
                                                                                        ADDataViewPermissionType.Module,
                                                                                        BOSApp.CurrentCompanyInfo.FK_BRBranchID,
                                                                                        shipmentID,
                                                                                        workShopID,
                                                                                        lineID,
                                                                                        fromDate,
                                                                                        toDate,
                                                                                        batchProductID,
                                                                                        departmentID,
                                                                                        woodType);
            BOSList<ICShipmentItemsInfo> shipmentItemList = new BOSList<ICShipmentItemsInfo>(TableName.ICShipmentItemsTableName);
            shipmentItemList.Invalidate(shipments);
            fld_dgcICShipmentItemsGridControl.InvalidateDataSource(shipmentItemList);
        }

        private void fld_btnImport_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = TransferLocalizedResources.DialogFilter;
            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;
            filePath = dialog.FileName;
            string extension = Path.GetExtension(filePath);
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + filePath + "';Extended Properties=\"Excel 8.0;HDR=YES;\"";
            if (extension.Equals(".xlsx"))
            {
                connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + filePath + "';Extended Properties=\"Excel 12.0;HDR=YES;\"";
            }
            BOSProgressBar.Start("Đang khởi tạo dữ liệu");
            DataSet ds = GetDataFromExcel(filePath, connectionString);
            BOSProgressBar.Close();
            InitializeImport(ds);
        }
        public DataSet GetDataFromExcel(string filePath, string connectionString)
        {
            DataSet ds = new DataSet();
            try
            {
                List<string> sheetNames = new List<string>();
                OleDbDataAdapter command;

                string commandTemplate = "SELECT * FROM [{0}]";
                string commandRun = string.Empty;
                using (OleDbConnection cn = new OleDbConnection(connectionString))
                {
                    cn.Open();
                    System.Data.DataTable dt = cn.GetSchema("Tables");
                    foreach (DataRow dr in dt.Rows)
                    {
                        sheetNames.Add(dr["TABLE_NAME"].ToString());
                    }
                    sheetNames.ForEach(o =>
                    {
                        commandRun = string.Format(commandTemplate, o);
                        command = new System.Data.OleDb.OleDbDataAdapter(commandRun, cn);
                        command.TableMappings.Add("Table", o);
                        command.Fill(ds);
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ds;
        }
        public void InitializeImport(DataSet ds)
        {
            AAColumnAliasController objColumnAliasController = new AAColumnAliasController();
            List<AAColumnAliasInfo> aliasImportsList = BOSApp.LstColumnAlias.Where(o => o.AATableName == "IPShipmentItems").ToList();
            List<IPShipmentItemsInfo> shipmentItemList = new List<IPShipmentItemsInfo>();
            IPShipmentItemsInfo objShipmentItemsInfo = new IPShipmentItemsInfo();

            System.Data.DataTable dt = ds.Tables["'Template $'"];
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    objShipmentItemsInfo = (IPShipmentItemsInfo)GetObjectFromDataRow(dr, objShipmentItemsInfo.GetType(), aliasImportsList);
                    if (objShipmentItemsInfo != null && !string.IsNullOrWhiteSpace(objShipmentItemsInfo.MMBatchProductNo))
                    {
                        shipmentItemList.Add(objShipmentItemsInfo);
                    }
                }
            }
            fld_dgcIPShipmentItemsGridControl.InvalidateDataSource(shipmentItemList);
            if (shipmentItemList.Where(o => !string.IsNullOrWhiteSpace(o.MessageError)).Count() > 0)
            {
                string MessageError = string.Join("", shipmentItemList.Select(o => o.MessageError).ToArray());
                MessageBox.Show(MessageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ImportObjects = shipmentItemList;
        }
        public object GetObjectFromDataRow(DataRow row, Type type, List<AAColumnAliasInfo> aliasList)
        {
            object obj = type.InvokeMember("", System.Reflection.BindingFlags.CreateInstance, null, null, null);
            string columnName = string.Empty;
            AAColumnAliasInfo objColumnAliasInfo = new AAColumnAliasInfo();
            decimal decimalValue = 0;
            bool isConverter = false;
            foreach (DataColumn column in row.Table.Columns)
            {
                isConverter = false;
                object objValue = row[column];
                objColumnAliasInfo = aliasList.Where(o => o.AAColumnAliasCaption.ToLower().Trim() == column.ColumnName.ToLower().Trim()).FirstOrDefault();
                if (objColumnAliasInfo == null)
                    continue;

                PropertyInfo property = obj.GetType().GetProperty(objColumnAliasInfo.AAColumnAliasName);
                if (property != null)
                    property.SetValue(obj, ToPropertyDataType(column.DataType, property.PropertyType, objValue), null);
            }
            return obj;
        }
        public object ToPropertyDataType(Type fromType, Type toType, object objValue)
        {
            if (toType.Equals(typeof(string)) || toType.Equals(typeof(String)))
            {
                return objValue == null ? string.Empty : objValue.ToString().Trim();
            }
            if (objValue == null)
                return objValue;

            if (fromType.Equals(toType))
                return objValue;

            if (toType.Equals(typeof(decimal)) || toType.Equals(typeof(Decimal)))
            {
                decimal value = 0;
                Decimal.TryParse(objValue.ToString(), out value);
                return Math.Round(value, 5, MidpointRounding.AwayFromZero);
            }
            if (toType.Equals(typeof(int)))
            {
                decimal value = 0;
                Decimal.TryParse(objValue.ToString(), out value);
                return (int)value;
            }
            if (toType.Equals(typeof(bool)) || toType.Equals(typeof(Boolean)))
            {
                return !string.IsNullOrWhiteSpace(objValue.ToString());
            }
            return objValue;
        }
        public void ValidateShipmentItemImport(IPShipmentItemsInfo item)
        {
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            MMBatchProductsInfo objBatchProductsInfo = new MMBatchProductsInfo();
            ICProductsForViewInfo objProductsInfo = new ICProductsForViewInfo();
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            List<ICMeasureUnitsInfo> measureUnitList = (List<ICMeasureUnitsInfo>)objMeasureUnitsController.GetAllAliveMeasureUnit();
            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();

            item.MessageError = string.Empty;
            if (string.IsNullOrWhiteSpace(item.ICShipmentItemProductNo))
            {
                item.MessageError += string.Format("Mã sản phẩm (Gỗ xuất) [{0}] không tồn tại trong hệ thống.", item.ICShipmentItemProductNo);
                item.MessageError += Environment.NewLine;
            }
            objProductsInfo = BOSApp.CurrentProductList.Where(p => p.ICProductNo == item.ICShipmentItemProductNo).FirstOrDefault();
            item.FK_ICProductID = objProductsInfo != null ? objProductsInfo.ICProductID : 0;
            if (objProductsInfo == null)
            {
                item.MessageError += string.Format("Mã sản phẩm (Gỗ xuất) [{0}] không tồn tại trong hệ thống.", item.ICShipmentItemProductNo);
                item.MessageError += Environment.NewLine;
            }
            if (string.IsNullOrWhiteSpace(item.ICProductNo))
            {
                item.MessageError += string.Format("Mã sản phẩm [{0}] không tồn tại trong hệ thống.", item.ICProductNo);
                item.MessageError += Environment.NewLine;
            }
            objProductsInfo = BOSApp.CurrentProductList.Where(p => p.ICProductNo == item.ICProductNo).FirstOrDefault();
            item.FK_ICShipmentItemProductID = objProductsInfo != null ? objProductsInfo.ICProductID : 0;
            if (objProductsInfo == null)
            {
                item.MessageError += string.Format("Mã sản phẩm [{0}] không tồn tại trong hệ thống.", item.ICProductNo);
                item.MessageError += Environment.NewLine;
            }
            //else if (objProductsInfo.ICProductName.Trim() != item.ICProductName)
            //{
            //    item.MessageError += string.Format("Mã sản phẩm [{0}] có tên khác với tên đã tồn tại trong hệ thống.", item.ICProductNo);
            //    item.MessageError += Environment.NewLine;
            //}
            objBatchProductsInfo = (MMBatchProductsInfo)objBatchProductsController.GetObjectByNo(item.MMBatchProductNo);
            item.FK_MMBatchProductID = objBatchProductsInfo != null ? objBatchProductsInfo.MMBatchProductID : 0;
            if (objBatchProductsInfo == null)
            {
                item.MessageError += string.Format("Lệnh sản xuất [{0}] không tồn tại trong hệ thống", item.MMBatchProductNo);
                item.MessageError += Environment.NewLine;
            }
            objMeasureUnitsInfo = measureUnitList.Where(o => o.ICMeasureUnitName == item.ICMeasureUnitName).FirstOrDefault();
            item.FK_ICMeasureUnitID = objMeasureUnitsInfo != null ? objMeasureUnitsInfo.ICMeasureUnitID : 0;
            if (objMeasureUnitsInfo == null)
            {
                item.MessageError += string.Format("ĐVT [{0}] của sản phẩm [{1}] không tồn tại trong hệ thống", item.ICMeasureUnitName, item.ICProductNo);
                item.MessageError += Environment.NewLine;
            }    
            if (item.MessageError.Length > 1)
            {
                item.MessageError = item.MessageError.TrimStart();
            }
        }
    }
}
