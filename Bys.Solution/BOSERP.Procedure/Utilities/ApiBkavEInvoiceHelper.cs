using BOSCommon.Constants;
using BSECUS;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Utilities
{
    public class ApiBkavEInvoiceHelper
    {
        RemoteCommand remoteCommand = null;

        public ApiBkavEInvoiceHelper(int taxUnitID)
        {
            ACTaxUnitsController objTaxUnitsController = new ACTaxUnitsController();
            ACTaxUnitsInfo objTaxUnitsInfo = (ACTaxUnitsInfo)objTaxUnitsController.GetObjectByID(taxUnitID);
            if(objTaxUnitsInfo == null)
            {
                MessageBox.Show("Vui lòng kiểm tra lại Đơn vị chịu thuế cho chứng từ này!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ACEInvoiceConfigsController objEInvoiceConfigsController = new ACEInvoiceConfigsController();
            ACEInvoiceConfigsInfo objEInvoiceConfigsInfo = objEInvoiceConfigsController.GetLastEInvoiceConfigByTaxUnitID(taxUnitID);
            if (objEInvoiceConfigsInfo == null)
            {
                MessageBox.Show(string.Format("Vui lòng cấu hình Hóa đơn điện tử cho đơn vị chịu thuế {0}!", objTaxUnitsInfo.ACTaxUnitName)
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ExecCommandFunc wsExecCommand = null;
            var webservice = new WSPublicEHoaDon.WSPublicEHoaDon();

            wsExecCommand = webservice.ExecuteCommand;
            webservice.Url = objEInvoiceConfigsInfo.ACEInvoiceConfigLinkWS; //"https://ws.ehoadon.vn/WSPublicEHoaDon.asmx";

            // Khởi tạo đối tượng RemoteCommand, đối tượng có nhiệm vụ gửi Mã lệnh CommandType và Đối tượng lệnh CommandObject lên Webservice eHoadon của Bkav
            remoteCommand = new RemoteCommand(wsExecCommand, objEInvoiceConfigsInfo.ACEInvoiceConfigBkavPartnerGUID, objEInvoiceConfigsInfo.ACEInvoiceConfigBkavPartnerToken, Constants.Mode);
        }

        public void CreateEInvoiceBKAV(ACEInvoiceGeneralsInfo eInvoice)
        {
            string sGUID = null;
            string msg = DoCreateInvoice(eInvoice, out sGUID);
            if (msg.Length > 0)
            {
                MessageBox.Show("Có lỗi: " + msg, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eInvoice.PublicKey = sGUID;
                eInvoice.ACEInvoiceGeneralStatus = "Value1";
                (new ACEInvoiceGeneralsController()).UpdateObject(eInvoice);
                MessageBox.Show("Đã chuyển dữ liệu thành công nhưng chưa phát hành HD: " + sGUID, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string DoCreateInvoice(ACEInvoiceGeneralsInfo eInvoice, out string sGUID)
        {
            string msg = "";
            sGUID = null;
            string listInvoiceDataWS = null;
            Result result = null;

            if (String.IsNullOrEmpty(eInvoice.TemplateCode) || String.IsNullOrEmpty(eInvoice.InvoiceSeries))
            {
                if (Convert.ToInt32(eInvoice.InvoiceNumber) > 0)
                {
                    // Bước 1: Gọi hàm lấy dữ liệu Hóa đơn để gửi lên Webservice eHoadon của Bkav                    
                    msg = GetListInvoiceDataWS(CommandType.CreateInvoiceTR, out listInvoiceDataWS, eInvoice);
                    if (msg.Length > 0) return msg;

                    // Bước 2: Gửi lên Webservice và nhận đối tượng Result chứa kết quả trả về
                    msg = remoteCommand.TransferCommandAndProcessResult(CommandType.CreateInvoiceTR, listInvoiceDataWS, out result);
                    if (msg.Length > 0) return msg;
                }
                else
                {
                    // Bước 1: Gọi hàm lấy dữ liệu Hóa đơn để gửi lên Webservice eHoadon của Bkav
                    msg = GetListInvoiceDataWS(CommandType.CreateInvoiceMT, out listInvoiceDataWS, eInvoice);
                    if (msg.Length > 0) return msg;

                    // Bước 2: Gửi lên Webservice và nhận đối tượng Result chứa kết quả trả về
                    msg = remoteCommand.TransferCommandAndProcessResult(CommandType.CreateInvoiceMT, listInvoiceDataWS, out result);
                    if (msg.Length > 0) return msg;
                }
            }
            else
            {
                if (Convert.ToInt32(eInvoice.InvoiceNumber) > 0)
                {
                    // Bước 1: Gọi hàm lấy dữ liệu Hóa đơn để gửi lên Webservice eHoadon của Bkav                    
                    msg = GetListInvoiceDataWS(CommandType.CreateInvoiceWithFormSerialNo, out listInvoiceDataWS, eInvoice);
                    if (msg.Length > 0) return msg;

                    // Bước 2: Gửi lên Webservice và nhận đối tượng Result chứa kết quả trả về
                    msg = remoteCommand.TransferCommandAndProcessResult(CommandType.CreateInvoiceWithFormSerialNo, listInvoiceDataWS, out result);
                    if (msg.Length > 0) return msg;
                }
                else
                {
                    // Bước 1: Gọi hàm lấy dữ liệu Hóa đơn để gửi lên Webservice eHoadon của Bkav
                    msg = GetListInvoiceDataWS(CommandType.CreateInvoiceWithFormSerial, out listInvoiceDataWS, eInvoice);
                    if (msg.Length > 0) return msg;

                    // Bước 2: Gửi lên Webservice và nhận đối tượng Result chứa kết quả trả về
                    msg = remoteCommand.TransferCommandAndProcessResult(CommandType.CreateInvoiceWithFormSerial, listInvoiceDataWS, out result);
                    if (msg.Length > 0) return msg;
                }
            }

            // Bước 3: Không có lỗi, Hệ thống trả ra danh sách kết quả của Hóa đơn
            List<InvoiceResult> listInvoiceResult = null;
            msg = Convertor.StringToObject(false, Convert.ToString(result.Object), out listInvoiceResult);
            if (msg.Length > 0) return msg;

            // Bước 4: Xử lý từng kết quả trong Danh sách kết quả trả về (mỗi 1 kết quả ứng với 1 Hóa đơn trong danh sách được gửi lên WS)
            foreach (InvoiceResult invoiceResult in listInvoiceResult)
            {
                if (invoiceResult.Status == 0)
                {
                    sGUID += String.IsNullOrEmpty(sGUID) ? invoiceResult.InvoiceGUID.ToString() : (";" + invoiceResult.InvoiceGUID.ToString());
                    eInvoice.InvoiceNumber = invoiceResult.InvoiceNo.ToString().PadLeft(8);
                    if (eInvoice.InvoiceNumber.Contains(" "))
                        eInvoice.InvoiceNumber = eInvoice.InvoiceNumber.Replace(' ', '0');
                    eInvoice.TemplateCode = invoiceResult.InvoiceForm;
                    eInvoice.InvoiceSeries = invoiceResult.InvoiceSerial;
                }
                else msg = msg + "; " + invoiceResult.MessLog;
            }

            return msg;
        }

        public bool UpdateEInvoiceBKAV(ACEInvoiceGeneralsInfo eInvoice)
        {
            try
            {
                int invoiceNumber = Convert.ToInt32(eInvoice.InvoiceNumber);
                if (invoiceNumber <= 0)
                {
                    MessageBox.Show("Không thể Cập nhật dữ liệu cho hóa đơn chưa được cấp số!", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Vui lòng kiểm tra lại Số hóa đơn", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string msg = DoUpdateInvoice(eInvoice);
            if (msg.Length > 0)
            {
                MessageBox.Show("Có lỗi: " + msg, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Đã cập nhật dữ liệu thành công!", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        private string DoUpdateInvoice(ACEInvoiceGeneralsInfo eInvoice)
        {
            string msg = "";

            string list = null;
            msg = GetListInvoiceDataWS(CommandType.UpdateInvoiceByInvoiceGUID, out list, eInvoice);
            if (msg.Length > 0) return msg;

            Result result = null;
            msg = remoteCommand.TransferCommandAndProcessResult(CommandType.UpdateInvoiceByInvoiceGUID, list, out result);
            if (msg.Length > 0) return msg;

            // Không có lỗi, Hệ thống trả ra danh sách kết quả của Hóa đơn
            List<InvoiceResult> listInvoiceResult = null;
            msg = Convertor.StringToObject(false, Convert.ToString(result.Object), out listInvoiceResult);
            if (msg.Length > 0) return msg;

            foreach (InvoiceResult invoiceResult in listInvoiceResult)
            {
                if (invoiceResult.Status != 0)
                {
                    return invoiceResult.MessLog;
                }
            }
            return msg;
        }

        public void GetStatusEInvoiceBKAV(ACEInvoiceGeneralsInfo eInvoice)
        {
            string msg = "";

            Result result = null;
            msg = remoteCommand.TransferCommandAndProcessResult(CommandType.GetInvoiceStatusID, eInvoice.PublicKey, out result);
            if (msg.Length > 0)
            {
                MessageBox.Show("Có lỗi: " + msg, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eInvoice.ACEInvoiceGeneralStatus = GetStringStatus(result.Object.ToString());
                (new ACEInvoiceGeneralsController()).UpdateObject(eInvoice);
                MessageBox.Show("Lấy trạng thái hóa đơn thành công!", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool GetInfoEInvoiceBKAV(ACEInvoiceGeneralsInfo eInvoice)
        {
            string msg = "";
            int InvoiceNo = 0;
            msg = DoGetInfo(eInvoice, out InvoiceNo);
            if (msg.Length > 0)
            {
                return false;
            }
            else
            {
                (new ACEInvoiceGeneralsController()).UpdateObject(eInvoice);
                return true;
            }
        }

        public string DoGetInfo(ACEInvoiceGeneralsInfo eInvoice, out int InvoiceNo)
        {
            string msg = "";
            InvoiceNo = 0;

            Result result = null;
            msg = remoteCommand.TransferCommandAndProcessResult(CommandType.GetInvoiceDataWS, eInvoice.PublicKey, out result);
            if (msg.Length > 0) return msg;

            InvoiceDataWS invoiceDataWS = null;
            msg = Convertor.StringToObject(false, Convert.ToString(result.Object), out invoiceDataWS);
            if (msg.Length > 0) return msg;

            InvoiceNo = invoiceDataWS.Invoice.InvoiceNo;
            eInvoice.InvoiceNumber = invoiceDataWS.Invoice.InvoiceNo.ToString().PadLeft(8);
            if (eInvoice.InvoiceNumber.Contains(" "))
                eInvoice.InvoiceNumber = eInvoice.InvoiceNumber.Replace(' ', '0');
            eInvoice.ACEInvoiceGeneralStatus = GetStringStatus(invoiceDataWS.Invoice.InvoiceStatusID.ToString());
            eInvoice.SubmittedDate = invoiceDataWS.Invoice.SignedDate;
            return msg;
        }

        public void ReplaceEInvoiceBKAV(ACEInvoiceGeneralsInfo eInvoice)
        {
            string msg = DoReplaceInvoice(eInvoice);
            if (msg.Length > 0)
            {
                MessageBox.Show("Có lỗi: " + msg, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eInvoice.ACEInvoiceGeneralStatus = "Value5";
                (new ACEInvoiceGeneralsController()).UpdateObject(eInvoice);
                MessageBox.Show("Thay thế thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string DoReplaceInvoice(ACEInvoiceGeneralsInfo eInvoice)
        {
            string msg = "";

            string list = null;
            msg = GetListInvoiceDataWS(CommandType.CreateInvoiceReplace, out list, eInvoice);
            if (msg.Length > 0) return msg;

            Result result = null;
            msg = remoteCommand.TransferCommandAndProcessResult(CommandType.CreateInvoiceReplace, list, out result);
            if (msg.Length > 0) return msg;

            // Không có lỗi, Hệ thống trả ra danh sách kết quả của Hóa đơn
            List<InvoiceResult> listInvoiceResult = null;
            msg = Convertor.StringToObject(false, Convert.ToString(result.Object), out listInvoiceResult);
            if (msg.Length > 0) return msg;

            foreach (InvoiceResult invoiceResult in listInvoiceResult)
            {
                if (invoiceResult.Status == 0)
                {
                    eInvoice.PublicKey = invoiceResult.InvoiceGUID.ToString();
                    eInvoice.InvoiceNumber = invoiceResult.InvoiceNo.ToString().PadLeft(8);
                    if (eInvoice.InvoiceNumber.Contains(" "))
                        eInvoice.InvoiceNumber = eInvoice.InvoiceNumber.Replace(' ', '0');
                    eInvoice.TemplateCode = invoiceResult.InvoiceForm;
                    eInvoice.InvoiceSeries = invoiceResult.InvoiceSerial;
                }
                else
                    return invoiceResult.MessLog;
            }
            return msg;
        }

        public void AdjustEInvoiceBKAV(ACEInvoiceGeneralsInfo eInvoice)
        {
            string msg = DoAdjustInvoice(eInvoice);
            if (msg.Length > 0)
            {
                MessageBox.Show("Có lỗi: " + msg, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eInvoice.ACEInvoiceGeneralStatus = "Value7";
                (new ACEInvoiceGeneralsController()).UpdateObject(eInvoice);
                MessageBox.Show("Điều chỉnh thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string DoAdjustInvoice(ACEInvoiceGeneralsInfo eInvoice)
        {
            string msg = "";

            string list = null;
            msg = GetListInvoiceDataWS(CommandType.CreateInvoiceAdjust, out list, eInvoice);
            if (msg.Length > 0) return msg;

            Result result = null;
            msg = remoteCommand.TransferCommandAndProcessResult(CommandType.CreateInvoiceAdjust, list, out result);
            if (msg.Length > 0) return msg;

            // Không có lỗi, Hệ thống trả ra danh sách kết quả của Hóa đơn
            List<InvoiceResult> listInvoiceResult = null;
            msg = Convertor.StringToObject(false, Convert.ToString(result.Object), out listInvoiceResult);
            if (msg.Length > 0) return msg;

            foreach (InvoiceResult invoiceResult in listInvoiceResult)
            {
                if (invoiceResult.Status == 0)
                {
                    eInvoice.PublicKey = invoiceResult.InvoiceGUID.ToString();
                    eInvoice.InvoiceNumber = invoiceResult.InvoiceNo.ToString().PadLeft(8);
                    if (eInvoice.InvoiceNumber.Contains(" "))
                        eInvoice.InvoiceNumber = eInvoice.InvoiceNumber.Replace(' ', '0');
                    eInvoice.TemplateCode = invoiceResult.InvoiceForm;
                    eInvoice.InvoiceSeries = invoiceResult.InvoiceSerial;
                }
                else
                    return invoiceResult.MessLog;
            }
            return msg;
        }

        public void DeleteEInvoiceBKAVByInvoiceGUID(ACEInvoiceGeneralsInfo eInvoice)
        {
            string msg = DeleteInvoice(CommandType.DeleteInvoiceByInvoiceGUID, eInvoice);
            if (msg.Length > 0)
            {
                MessageBox.Show("Có lỗi: Đã tồn tại Hóa đơn có số hóa đơn lớn hơn Hóa đơn này!", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eInvoice.ACEInvoiceGeneralStatus = "Value4";
                (new ACEInvoiceGeneralsController()).UpdateObject(eInvoice);
                MessageBox.Show("Update thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string DeleteInvoice(int CmdType, ACEInvoiceGeneralsInfo eInvoice)
        {
            string msg = "";

            List<InvoiceDataWS> listInvoiceDataWS = new List<InvoiceDataWS>();
            InvoiceDataWS invoiceDataWS = new InvoiceDataWS();
            if (CmdType == CommandType.DeleteInvoiceByPartnerInvoiceID)
            {
                //Chỉ được truyền giá trị cho PartnerInvoiceID trong hoặc PartnerInvoiceStringID
                //invoiceDataWS.PartnerInvoiceID = (txtDeleteInvoice.Text.Length > 0 ? long.Parse(txtDeleteInvoice.Text) : (long.Parse(DateTime.Now.ToString("ddMMyyy HH:mm:ss").Replace(" ", "").Replace(":", ""))));
                //invoiceDataWS.PartnerInvoiceStringID = "";
            }
            else
            {
                invoiceDataWS.Invoice = new InvoiceWS();
                Guid guid = Guid.Empty;
                msg = Convertor.StringToGuid(eInvoice.PublicKey, out guid);
                if (msg.Length > 0) return "Giá trị không thể convert sang GUID";
                invoiceDataWS.Invoice.InvoiceGUID = guid;
            }

            listInvoiceDataWS.Add(invoiceDataWS);

            string list = null;
            msg = Convertor.ObjectToString<List<InvoiceDataWS>>(false, listInvoiceDataWS, out list);
            if (msg.Length > 0) return msg;

            Result result = null;
            msg = remoteCommand.TransferCommandAndProcessResult(CmdType, list, out result);
            if (msg.Length > 0) return msg;

            // Không có lỗi, Hệ thống trả ra danh sách kết quả của Hóa đơn
            List<InvoiceResult> listInvoiceResult = null;
            msg = Convertor.StringToObject(false, Convert.ToString(result.Object), out listInvoiceResult);
            if (msg.Length > 0) return msg;

            foreach (InvoiceResult invoiceResult in listInvoiceResult)
            {
                if (invoiceResult.Status == 0)
                {
                    eInvoice.InvoiceNumber = invoiceResult.InvoiceNo.ToString().PadLeft(8);
                    if (eInvoice.InvoiceNumber.Contains(" "))
                        eInvoice.InvoiceNumber = eInvoice.InvoiceNumber.Replace(' ', '0');
                }
                else
                    return invoiceResult.MessLog;
            }
            return msg;
        }

        public void CancelEInvoiceBKAVByInvoiceGUID(ACEInvoiceGeneralsInfo eInvoice)
        {
            string msg = CancelInvoice(CommandType.CancelInvoiceByInvoiceGUID, eInvoice);
            if (msg.Length > 0)
            {
                MessageBox.Show("Có lỗi: " + msg, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eInvoice.ACEInvoiceGeneralStatus = "Value3";
                (new ACEInvoiceGeneralsController()).UpdateObject(eInvoice);
                MessageBox.Show("Update thành công", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string CancelInvoice(int CmdType, ACEInvoiceGeneralsInfo eInvoice)
        {
            string msg = "";

            List<InvoiceDataWS> listInvoiceDataWS = new List<InvoiceDataWS>();
            InvoiceDataWS invoiceDataWS = new InvoiceDataWS();
            if (CmdType == CommandType.CancelInvoiceByPartnerInvoiceID)
            {
                //invoiceDataWS.PartnerInvoiceID = (txtCancelPartnerInvoiceID.Text.Length > 0 ? long.Parse(txtCancelPartnerInvoiceID.Text) : (long.Parse(DateTime.Now.ToString("ddMMyyy HH:mm:ss").Replace(" ", "").Replace(":", ""))));//hoắc   
                //invoiceDataWS.PartnerInvoiceStringID = "";
            }
            else
            {
                invoiceDataWS.Invoice = new InvoiceWS();
                Guid guid = Guid.Empty;
                msg = Convertor.StringToGuid(eInvoice.PublicKey, out guid);
                if (msg.Length > 0) return "Giá trị không thể convert sang GUID";
                invoiceDataWS.Invoice.InvoiceGUID = guid;
            }

            listInvoiceDataWS.Add(invoiceDataWS);

            string list = null;
            msg = Convertor.ObjectToString<List<InvoiceDataWS>>(false, listInvoiceDataWS, out list);
            if (msg.Length > 0) return msg;

            Result result = null;
            msg = remoteCommand.TransferCommandAndProcessResult(CmdType, list, out result);
            if (msg.Length > 0) return msg;

            // Không có lỗi, Hệ thống trả ra danh sách kết quả của Hóa đơn
            List<InvoiceResult> listInvoiceResult = null;
            msg = Convertor.StringToObject(false, Convert.ToString(result.Object), out listInvoiceResult);
            if (msg.Length > 0) return msg;

            foreach (InvoiceResult invoiceResult in listInvoiceResult)
            {
                if (invoiceResult.Status == 0)
                {

                }
                else
                    return invoiceResult.MessLog;
            }
            return msg;
        }

        #region Tạo và gán dữ liệu cho 1 tờ hóa đơn (object InvoiceDataWS)
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Ví dụ đoạn code tạo và gán dữ liệu cho 1 tờ hóa đơn (object InvoiceDataWS) 
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// GetListInvoiceDataWS trả về 1 danh sách Hóa đơn (được serialize về string) ở biến listInvoiceDataWS
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="listInvoiceDataWS"></param>
        /// <returns></returns>
        string GetListInvoiceDataWS(int commandType, out string listInvoiceDataWS, ACEInvoiceGeneralsInfo eInvoice)
        {
            listInvoiceDataWS = null;

            List<InvoiceDataWS> listID = null;
            PrepareInvoiceData(commandType, out listID, eInvoice);

            //return Convertor.ObjectToString<List<InvoiceDataWS>>(rdXML.Checked, listID, out listInvoiceDataWS);
            return Convertor.ObjectToString<List<InvoiceDataWS>>(false, listID, out listInvoiceDataWS);
        }
        void PrepareInvoiceData(int commandType, out List<InvoiceDataWS> listInvoiceDataWS, ACEInvoiceGeneralsInfo eInvoice)
        {
            listInvoiceDataWS = new List<InvoiceDataWS>();
            // Một tờ Hóa đơn được lưu trong 1 object InvoiceDataWS. Object này có 4 properties Invoice, ListInvoiceDetails, IsSetInvoiceNo, TransactionID
            // Header của tờ Hóa đơn (như thông tin người bán, người mua...) được lưu trong Invoice
            // Chi tiết của tờ Hóa đơn (là các item hàng hóa, dịch vụ) được lưu trong InvoiceDetails. Nhiều item được lưu trong ListInvoiceDetails

            // Tạo Header của tờ Hóa đơn
            InvoiceWS invoice = GetOneInvoiceWS(commandType, eInvoice);

            // Tạo danh sách các item
            List<InvoiceDetailsWS> invoiceDetails = new List<InvoiceDetailsWS>();
            InvoiceDetailsWS invoiceDetail = null;

            ACEInvoiceDetailsController objEInvoiceDetailsController = new ACEInvoiceDetailsController();
            List<ACEInvoiceDetailsInfo> listEInvoiceDetails = (List<ACEInvoiceDetailsInfo>)objEInvoiceDetailsController.GetListFromDataSet(objEInvoiceDetailsController.GetAllDataByForeignColumn("FK_ACEInvoiceGeneralID", eInvoice.ACEInvoiceGeneralID));
            listEInvoiceDetails = listEInvoiceDetails.OrderBy(o => o.LineNumber).ToList();
            foreach (ACEInvoiceDetailsInfo item in listEInvoiceDetails)
            {
                // Tạo 1 item
                if (commandType == CommandType.CreateInvoiceAdjust)
                {
                    invoiceDetail = GetOneInvoiceDetailsWS(item, eInvoice.TaxOfficeCode, false, true); // Điều chỉnh thì sẽ bổ sung thêm IsIncrease: True là báo tăng, False báo giảm
                }
                else
                {
                    invoiceDetail = GetOneInvoiceDetailsWS(item, eInvoice.TaxOfficeCode, false);
                }
                // Add item vào list các item
                invoiceDetails.Add(invoiceDetail);
            }

            ////Tạo item Chiết khấu
            if (eInvoice.DiscountAmount > 0)
            {
                decimal vatPercen = 0;
                try
                {
                    vatPercen = Convert.ToDecimal(eInvoice.TaxOfficeCode.Substring(0, eInvoice.TaxOfficeCode.Length - 1));
                }
                catch (Exception e)
                {
                    vatPercen = 0;
                }
                ACEInvoiceDetailsInfo itemDiscount = new ACEInvoiceDetailsInfo();
                itemDiscount.ItemName = "Chiết khấu";
                itemDiscount.UnitName = string.Empty;  //eInvoice.CurrencyCode;
                itemDiscount.Quantity = 1;
                itemDiscount.UnitPrice = eInvoice.DiscountAmount;
                itemDiscount.VatAmount = Math.Round(eInvoice.DiscountAmount * vatPercen / 100, 0, MidpointRounding.AwayFromZero);
                if (commandType == CommandType.CreateInvoiceAdjust)
                {
                    invoiceDetail = GetOneInvoiceDetailsWS(itemDiscount, eInvoice.TaxOfficeCode, true, true); // Điều chỉnh thì sẽ bổ sung thêm IsIncrease: True là báo tăng, False báo giảm
                }
                else
                {
                    invoiceDetail = GetOneInvoiceDetailsWS(itemDiscount, eInvoice.TaxOfficeCode, true);
                }
                // Add item vào list các item
                invoiceDetail.Qty = 0;
                invoiceDetail.Price = 0;
                invoiceDetails.Add(invoiceDetail);
            }

            ////Tạo List tương tự
            InvoiceDataWS invoiceDataWS = new InvoiceDataWS();
            invoiceDataWS.Invoice = invoice;
            invoiceDataWS.ListInvoiceDetailsWS = invoiceDetails;
            invoiceDataWS.PartnerInvoiceID = eInvoice.ACEInvoiceGeneralID;
            invoiceDataWS.PartnerInvoiceStringID = null;
            listInvoiceDataWS.Add(invoiceDataWS);
        }

        /// <summary>
        /// Khởi tạo dữ ilệu InvoiceWS
        /// </summary>
        /// <returns></returns>
        InvoiceWS GetOneInvoiceWS(int commandType, ACEInvoiceGeneralsInfo eInvoice)
        {
            InvoiceWS invoiceWS = new InvoiceWS();
            invoiceWS.InvoiceTypeID = 1;
            invoiceWS.InvoiceDate = eInvoice.ContractDate;         //Ngày hóa đơn
            invoiceWS.BuyerName = eInvoice.BuyerDisplayName;            //Tên người mua hàng            
            invoiceWS.BuyerTaxCode = eInvoice.BuyerTaxCode;             //Mã số thuế
            invoiceWS.BuyerUnitName = eInvoice.BuyerLegalName;          //Tên đơn vị mua hàng
            invoiceWS.BuyerAddress = eInvoice.BuyerAddressLine;         //Địa chỉ đơn vị mua hàng
            invoiceWS.BuyerBankAccount = eInvoice.BuyerBankNumber + "-" + eInvoice.BuyerBankName;   //Thông tin ngân hàng

            //Hình thức thanh toán
            if (eInvoice.ACEInvoicePaymentMethodName == EInvoicePaymentMethodName.Cash.ToString())
                invoiceWS.PayMethodID = 1; //Tiền mặt
            else if (eInvoice.ACEInvoicePaymentMethodName == EInvoicePaymentMethodName.Transfer.ToString())
                invoiceWS.PayMethodID = 2; //Chuyển khoản
            else if (eInvoice.ACEInvoicePaymentMethodName == EInvoicePaymentMethodName.CashTransfer.ToString())
                invoiceWS.PayMethodID = 3; //Tiền mặt/Chuyển khoản
            else if (eInvoice.ACEInvoicePaymentMethodName == EInvoicePaymentMethodName.ShipmentInternal.ToString())
                invoiceWS.PayMethodID = 4; //Xuất kho nội bộ
            else if (eInvoice.ACEInvoicePaymentMethodName == EInvoicePaymentMethodName.GiftVoucher.ToString())
                invoiceWS.PayMethodID = 5; //Hàng biếu tặng
            else
                invoiceWS.PayMethodID = 1;

            //Hình thức nhận hóa đơn
            if (eInvoice.ACEInvoiceGeneralReceiveType == "Email")
                invoiceWS.ReceiveTypeID = 1;
            else if (eInvoice.ACEInvoiceGeneralReceiveType == "Tin nhắn")
                invoiceWS.ReceiveTypeID = 2;
            else if (eInvoice.ACEInvoiceGeneralReceiveType == "Email và tin nhắn")
                invoiceWS.ReceiveTypeID = 3;
            else if (eInvoice.ACEInvoiceGeneralReceiveType == "Chuyển phát nhanh")
                invoiceWS.ReceiveTypeID = 4;
            else
                invoiceWS.ReceiveTypeID = 1;

            invoiceWS.ReceiverEmail = eInvoice.BuyerEmail.Replace(" ", string.Empty);              //email
            invoiceWS.ReceiverMobile = eInvoice.BuyerPhoneNumber.Replace(" ", string.Empty);       //sdt
            invoiceWS.ReceiverAddress = eInvoice.BuyerAddressLine;      //Địa chỉ nhận hóa đơn
            invoiceWS.ReceiverName = eInvoice.BuyerLegalName;           //Tên người nhận hóa đơn
            invoiceWS.Note = eInvoice.InvoiceNote;                      //Ghi chú hóa đơn
            invoiceWS.BillCode = eInvoice.ACEInvoiceGeneralNo;           //Mã tham chiếu
            invoiceWS.CurrencyID = eInvoice.CurrencyCode;               //Mã tiền tệ
            invoiceWS.ExchangeRate = Convert.ToDouble(eInvoice.ExchangeRate); //Tỷ giá
            invoiceWS.InvoiceStatusID = 1;
            invoiceWS.SignedDate = DateTime.Now;

            switch (commandType)
            {
                case CommandType.CreateInvoiceMT:
                    invoiceWS.InvoiceNo = 0;                    //Số hóa đơn
                    invoiceWS.InvoiceForm = "";                 //Mẫu số hóa đơn
                    invoiceWS.InvoiceSerial = ""; break;        //Kí hiệu hóa đơn
                case CommandType.CreateInvoiceTR:
                    invoiceWS.InvoiceNo = 0;
                    invoiceWS.InvoiceForm = "";
                    invoiceWS.InvoiceSerial = ""; break;
                case CommandType.CreateInvoiceWithFormSerial:
                    invoiceWS.InvoiceNo = 0;
                    invoiceWS.InvoiceForm = eInvoice.TemplateCode;
                    invoiceWS.InvoiceSerial = eInvoice.InvoiceSeries; break;
                case CommandType.CreateInvoiceWithFormSerialNo:
                    invoiceWS.InvoiceNo = Convert.ToInt32(eInvoice.InvoiceNumber);
                    invoiceWS.InvoiceForm = eInvoice.TemplateCode;
                    invoiceWS.InvoiceSerial = eInvoice.InvoiceSeries; break;
                case CommandType.CreateInvoiceReplace:
                    invoiceWS.InvoiceNo = 0;
                    invoiceWS.InvoiceForm = "";
                    invoiceWS.InvoiceSerial = "";
                    invoiceWS.OriginalInvoiceIdentify = "[" + eInvoice.TemplateCode + "]_[" + eInvoice.InvoiceSeries + "]_[" + eInvoice.OriginalInvoiceId + "]"; break;
                case CommandType.CreateInvoiceAdjust:
                    invoiceWS.InvoiceNo = 0;
                    invoiceWS.InvoiceForm = "";
                    invoiceWS.InvoiceSerial = "";
                    invoiceWS.OriginalInvoiceIdentify = "[" + eInvoice.TemplateCode + "]_[" + eInvoice.InvoiceSeries + "]_[" + eInvoice.OriginalInvoiceId + "]"; break;
                case CommandType.UpdateInvoiceByInvoiceGUID:
                    Guid guid = Guid.Empty;
                    Convertor.StringToGuid(eInvoice.PublicKey, out guid);
                    invoiceWS.InvoiceGUID = guid;
                    break;

                default:
                    invoiceWS.InvoiceNo = 0;
                    invoiceWS.InvoiceForm = "";
                    invoiceWS.InvoiceSerial = "";
                    break;
            }
            return invoiceWS;
        }

        /// <summary>
        /// Khởi tạo dữ liệu InvoiceDetailsWS
        /// </summary>
        /// <returns></returns>
        InvoiceDetailsWS GetOneInvoiceDetailsWS(ACEInvoiceDetailsInfo eInvoiceDetail, string taxOfficeCode, bool isDiscount)
        {
            InvoiceDetailsWS invoiceDetailsWS = new InvoiceDetailsWS();
            invoiceDetailsWS.ItemTypeID = 0;
            invoiceDetailsWS.ItemCode = eInvoiceDetail.ACEInvoiceDetailVATCode;
            invoiceDetailsWS.ItemName = eInvoiceDetail.ItemName;
            invoiceDetailsWS.UnitName = eInvoiceDetail.UnitName;
            invoiceDetailsWS.Qty = Convert.ToDouble(eInvoiceDetail.Quantity);
            invoiceDetailsWS.Price = Convert.ToDouble(eInvoiceDetail.UnitPrice);
            invoiceDetailsWS.Amount = Math.Round(Convert.ToDouble(invoiceDetailsWS.Qty * invoiceDetailsWS.Price), 0, MidpointRounding.AwayFromZero);

            if (taxOfficeCode == "0%")
            {
                invoiceDetailsWS.TaxRateID = 1;
            }
            else if (taxOfficeCode == "5%")
            {
                invoiceDetailsWS.TaxRateID = 2;
            }
            else if (taxOfficeCode == "10%")
            {
                invoiceDetailsWS.TaxRateID = 3;
            }
            else if (taxOfficeCode == "8%")
            {
                invoiceDetailsWS.TaxRateID = 9;
            }
            else
            {
                invoiceDetailsWS.TaxRateID = 4;
            }
            invoiceDetailsWS.TaxAmount = Convert.ToDouble(eInvoiceDetail.VatAmount);
            invoiceDetailsWS.IsDiscount = isDiscount; // Có giảm giá hay không?
            invoiceDetailsWS.UserDefineDetails = "string đối tượng dạng json hoặc xml";
            return invoiceDetailsWS;
        }

        /// <summary>
        /// Khởi tạo dữ liệu InvoiceDetailsWS
        /// </summary>
        /// <returns></returns>
        InvoiceDetailsWS GetOneInvoiceDetailsWS(ACEInvoiceDetailsInfo eInvoiceDetail, string taxOfficeCode, bool isDiscount, bool isIncrease)
        {
            InvoiceDetailsWS invoiceDetailsWS = new InvoiceDetailsWS();
            invoiceDetailsWS.ItemTypeID = 0;
            invoiceDetailsWS.ItemCode = eInvoiceDetail.ACEInvoiceDetailVATCode;
            invoiceDetailsWS.ItemName = eInvoiceDetail.ItemName;
            invoiceDetailsWS.UnitName = eInvoiceDetail.UnitName;
            invoiceDetailsWS.Qty = Convert.ToDouble(eInvoiceDetail.Quantity);
            invoiceDetailsWS.Price = Convert.ToDouble(eInvoiceDetail.UnitPrice);
            invoiceDetailsWS.Amount = Math.Round(Convert.ToDouble(invoiceDetailsWS.Qty * invoiceDetailsWS.Price), 0, MidpointRounding.AwayFromZero);
            
            if (taxOfficeCode == "0%")
            {
                invoiceDetailsWS.TaxRateID = 1;
            }
            else if (taxOfficeCode == "5%")
            {
                invoiceDetailsWS.TaxRateID = 2;
            }
            else if (taxOfficeCode == "10%")
            {
                invoiceDetailsWS.TaxRateID = 3;
            }
            else if (taxOfficeCode == "8%")
            {
                invoiceDetailsWS.TaxRateID = 9;
            }
            else
            {
                invoiceDetailsWS.TaxRateID = 4;
            }
            invoiceDetailsWS.TaxAmount = Convert.ToDouble(eInvoiceDetail.VatAmount);
            invoiceDetailsWS.IsDiscount = isDiscount; // Có giảm giá hay không?
            invoiceDetailsWS.UserDefineDetails = "string đối tượng dạng json hoặc xml";
            invoiceDetailsWS.IsIncrease = true;// Fix mặc định báo tăng
            return invoiceDetailsWS;
        }
        #endregion

        public static string GetStringStatus(string value)
        {
            string result = "New";
            switch (value)
            {
                case "1":
                    result = "Value1";
                    break;
                case "2":
                    result = "Value2";
                    break;
                case "3":
                    result = "Value3";
                    break;
                case "4":
                    result = "Value4";
                    break;
                case "5":
                    result = "Value5";
                    break;
                case "6":
                    result = "Value6";
                    break;
                case "7":
                    result = "Value7";
                    break;
                case "8":
                    result = "Value8";
                    break;
                case "9":
                    result = "Value9";
                    break;
                case "10":
                    result = "Value10";
                    break;
                case "11":
                    result = "Value11";
                    break;
                case "12":
                    result = "Value12";
                    break;

                default:
                    break;
            }
            return result;
        }
    }
}
