using MimeTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace BOSERP.Utilities
{
    public class ApiClientHelper
    {
        public static Func<string> GetAuth { get; private set; }

        public static string Login(String username, String password)
        {
            if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ApiBaseUrl"]))
                return null;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return "Username or password is empty";
            }
            var user = new
            {
                userName = username,
                password = password
            };
            var client = new RestClient(ConfigurationManager.AppSettings["ApiBaseUrl"]);
            var request = new RestRequest("/user/loginerp", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(user);
            var response = client.Execute(request);
            if (response.ErrorException == null && response.StatusCode == HttpStatusCode.OK)
            {
                var content = (JObject)JsonConvert.DeserializeObject(response.Content);
                var result = (JObject)JsonConvert.DeserializeObject(content["result"].ToString());
                GetAuth = () => (result["tokenType"] + " " + result["accessToken"]);
                return null;
            }

            return "Login error";
        }

        public static bool AddImage(List<String> paths, int productID)
        {
            if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ApiBaseUrl"]) || !paths.Any())
                return false;

            ApiClientHelper.Login(BOSApp.CurrentUsersInfo.ADUserName, BOSApp.CurrentUsersInfo.ADPassword);
            var client = new RestClient(ConfigurationManager.AppSettings["ApiBaseUrl"]);
            var request = new RestRequest("/products/images/add", Method.POST);
            request.AddHeader("Authorization", GetAuth());
            request.AlwaysMultipartFormData = true;
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddParameter("ProductId", productID, ParameterType.RequestBody);
            paths.ForEach(o => request.AddFileBytes("ImageFiles", File.ReadAllBytes(o), Path.GetFileName(o), "image/jpg"));
            var response = client.Execute(request);
            if (response.ErrorException == null && response.StatusCode == HttpStatusCode.OK)
                return true;

            return false;
        }

        public static bool UpdatePrimaryImage(String path, int productID)
        {
            if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ApiBaseUrl"]))
                return false;

            ApiClientHelper.Login(BOSApp.CurrentUsersInfo.ADUserName, BOSApp.CurrentUsersInfo.ADPassword);
            var client = new RestClient(ConfigurationManager.AppSettings["ApiBaseUrl"]);
            var request = new RestRequest("/products/images/updateprimaryimage", Method.POST);
            request.AddHeader("Authorization", GetAuth());
            request.AlwaysMultipartFormData = true;
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddParameter("ProductId", productID, ParameterType.RequestBody);
            request.AddFileBytes("ImageFile", File.ReadAllBytes(path), Path.GetFileName(path), "image/jpg");
            var response = client.Execute(request);
            if (response.ErrorException == null && response.StatusCode == HttpStatusCode.OK)
                return true;
            return false;
        }

        public static List<ICProductFilesInfo> GetImages(int productID)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ApiBaseUrl"]))
                    return null;

                ApiClientHelper.Login(BOSApp.CurrentUsersInfo.ADUserName, BOSApp.CurrentUsersInfo.ADPassword);
                var client = new RestClient(ConfigurationManager.AppSettings["ApiBaseUrl"]);
                var request = new RestRequest("/products/" + productID + "/images", Method.GET);
                request.AddHeader("Authorization", GetAuth());
                var response = client.Execute(request);
                if (response.ErrorException == null && response.StatusCode == HttpStatusCode.OK)
                {
                    var content = (JObject)JsonConvert.DeserializeObject(response.Content);
                    JArray result = (JArray)JsonConvert.DeserializeObject(content["result"].ToString());
                    List<ICProductFilesInfo> productFiles = new List<ICProductFilesInfo>();
                    result.All(o =>
                    {
                        productFiles.Add(ToProductFilesInfo(o));
                        return true;
                    });
                    return productFiles;
                }
                return new List<ICProductFilesInfo>();
            }
            catch (Exception)
            {
                return new List<ICProductFilesInfo>();
            }
        }

        public static ICProductFilesInfo ToProductFilesInfo(JToken image)
        {
            return new ICProductFilesInfo()
            {
                ICProductFileName = (Guid)GuidHelper.Parse(image["guid"].ToString()),
                ICProductFileLargeSizeUrlImage = image["largeSizeUrl"].ToString(),
                ICProductFileImage = GetImage(image["thumbSizeUrl"].ToString())
            };
        }

        public static Image GetImage(String url)
        {
            WebRequest req = WebRequest.Create(url);

            WebResponse res = req.GetResponse();


            using (Stream imgStream = res.GetResponseStream())
            {
                return Image.FromStream(imgStream);
            }
        }

        public static List<ICProductFilesInfo> GetPrimaryImages(int[] productIDs)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ApiBaseUrl"]))
                    return null;

                ApiClientHelper.Login(BOSApp.CurrentUsersInfo.ADUserName, BOSApp.CurrentUsersInfo.ADPassword);
                var client = new RestClient(ConfigurationManager.AppSettings["ApiBaseUrl"]);
                var request = new RestRequest("/products/getprimaryimages", Method.POST);
                request.AddHeader("Authorization", GetAuth());
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "application/json");
                request.RequestFormat = DataFormat.Json;
                request.AddBody(new { ProductIds = productIDs });
                var response = client.Execute(request);
                if (response.ErrorException == null && response.StatusCode == HttpStatusCode.OK)
                {
                    var content = (JObject)JsonConvert.DeserializeObject(response.Content);
                    JArray result = (JArray)JsonConvert.DeserializeObject(content["result"].ToString());
                    List<ICProductFilesInfo> productFiles = new List<ICProductFilesInfo>();
                    int productID = 0;
                    result.All(o =>
                    {
                        productID = 0;
                        Int32.TryParse(o["productId"].ToString(), out productID);
                        JObject inner = o["imageUrl"].Value<JObject>();
                        if (inner != null)
                            productFiles.Add(ToProductFilesInfo(productID, inner));
                        return true;
                    });
                    return productFiles;
                }
                return new List<ICProductFilesInfo>();
            }
            catch (Exception)
            {
                return new List<ICProductFilesInfo>();
            }
        }

        public static ICProductFilesInfo ToProductFilesInfo(int productID, JObject productFile)
        {
            return new ICProductFilesInfo()
            {
                FK_ICProductID = productID,
                ICProductFileName = (Guid)GuidHelper.Parse(productFile["guid"].ToString()),
                ICProductFileLargeSizeUrlImage = productFile["largeSizeUrl"].ToString(),
                ICProductFileImage = GetImage(productFile["thumbSizeUrl"].ToString())
            };
        }

        public static void GetProductPrimaryImage(ICProductsInfo objProductsInfo)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ApiBaseUrl"]))
                    return;

                ApiClientHelper.Login(BOSApp.CurrentUsersInfo.ADUserName, BOSApp.CurrentUsersInfo.ADPassword);
                var client = new RestClient(ConfigurationManager.AppSettings["ApiBaseUrl"]);
                var request = new RestRequest("/products/" + objProductsInfo.ICProductID, Method.GET);
                request.AddHeader("Authorization", GetAuth());
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "application/json");
                var response = client.Execute(request);
                if (response.ErrorException == null && response.StatusCode == HttpStatusCode.OK)
                {
                    var content = (JObject)JsonConvert.DeserializeObject(response.Content);
                    JToken result = (JToken)JsonConvert.DeserializeObject(content["result"].ToString());
                    objProductsInfo.ICProductPrimaryImage = GetImage(result["productImageUrl"].ToString());
                }
            }
            catch (Exception e)
            {
                return;
            }
        }

        public static Image GetProductPrimaryImage(int productID)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ApiBaseUrl"]))
                    return null;

                ApiClientHelper.Login(BOSApp.CurrentUsersInfo.ADUserName, BOSApp.CurrentUsersInfo.ADPassword);
                var client = new RestClient(ConfigurationManager.AppSettings["ApiBaseUrl"]);
                var request = new RestRequest("/products/" + productID, Method.GET);
                request.AddHeader("Authorization", GetAuth());
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "application/json");
                var response = client.Execute(request);
                Image productImage = null;
                if (response.ErrorException == null && response.StatusCode == HttpStatusCode.OK)
                {
                    var content = (JObject)JsonConvert.DeserializeObject(response.Content);
                    JToken result = (JToken)JsonConvert.DeserializeObject(content["result"].ToString());
                    productImage = GetImage(result["productImageUrl"].ToString());
                }
                return productImage;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Image GetProductPrimaryImage(int productID, out byte[] productPicture)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ApiBaseUrl"]))
                {
                    productPicture = null;
                    return null;
                }

                ApiClientHelper.Login(BOSApp.CurrentUsersInfo.ADUserName, BOSApp.CurrentUsersInfo.ADPassword);
                var client = new RestClient(ConfigurationManager.AppSettings["ApiBaseUrl"]);
                var request = new RestRequest("/products/" + productID, Method.GET);
                request.AddHeader("Authorization", GetAuth());
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "application/json");
                var response = client.Execute(request);
                Image productImage = null;
                if (response.ErrorException == null && response.StatusCode == HttpStatusCode.OK)
                {
                    var content = (JObject)JsonConvert.DeserializeObject(response.Content);
                    JToken result = (JToken)JsonConvert.DeserializeObject(content["result"].ToString());
                    productImage = GetImage(result["productImageUrl"].ToString());
                }
                productPicture = ImageToByteArray(productImage);
                return productImage;
            }
            catch (Exception e)
            {
                productPicture = null;
                return null;
            }
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn == null)
                return null;

            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public static string UpdateFile(string filePath)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ApiBaseUrl"]))
                    return null;

                var client = new RestClient(ConfigurationManager.AppSettings["ApiBaseUrl"]);
                var request = new RestRequest("/file/upload", Method.POST);
                request.AlwaysMultipartFormData = true;
                request.AddHeader("Content-Type", "multipart/form-data");
                request.AddHeader("Accept", "*/*");
                string contentType = MimeTypeMap.GetMimeType(Path.GetExtension(filePath));
                request.AddFileBytes("FileReference", File.ReadAllBytes(filePath), Path.GetFileName(filePath), contentType);
                var response = client.Execute(request);
                if (response.ErrorException == null && response.StatusCode == HttpStatusCode.OK)
                {
                    var content = (JObject)JsonConvert.DeserializeObject(response.Content);
                    return content["result"].ToString();
                }
                return string.Empty;
            }
            catch (Exception e)
            {
                return string.Empty;
            }
        }

        public static void DownloadFile(string guidFile, string fileName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ApiBaseUrl"]))
                    return;

                var client = new RestClient(ConfigurationManager.AppSettings["ApiBaseUrl"]);
                var request = new RestRequest(string.Format("/file/{0}/download", guidFile), Method.GET);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "application/json");
                byte[] response = client.DownloadData(request);
                if (response.Count() == 0)
                    return;

                string extension = Path.GetExtension(fileName);
                SaveFileDialog file = new SaveFileDialog();
                file.Filter = "(*" + extension + ")|*" + extension + "|All files (*.*)|*.*";
                file.FileName = fileName;
                file.RestoreDirectory = true;
                if (file.ShowDialog() != DialogResult.OK)
                    return;

                File.WriteAllBytes(file.FileName, response);
            }
            catch (Exception e)
            {

            }
        }
        public static bool UpdatePrimaryImageEmployee(String path, int employeeID)
        {
            if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ApiBaseUrl"]))
                return false;

            Login(BOSApp.CurrentUsersInfo.ADUserName, BOSApp.CurrentUsersInfo.ADPassword);
            var client = new RestClient(ConfigurationManager.AppSettings["ApiBaseUrl"]);
            var request = new RestRequest("/employees/avatar/update", Method.POST);
            request.AddHeader("Authorization", GetAuth());
            request.AlwaysMultipartFormData = true;
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddParameter("EmployeeId", employeeID, ParameterType.RequestBody);
            request.AddFileBytes("ImageFile", File.ReadAllBytes(path), Path.GetFileName(path), "image/jpg");
            var response = client.Execute(request);
            if (response.ErrorException == null && response.StatusCode == HttpStatusCode.OK)
                return true;
            return false;
        }

        public static Image GetEmployeeImages(int employeeID)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ApiBaseUrl"]))
                    return null;

                Login(BOSApp.CurrentUsersInfo.ADUserName, BOSApp.CurrentUsersInfo.ADPassword);
                var client = new RestClient(ConfigurationManager.AppSettings["ApiBaseUrl"]);
                var request = new RestRequest("/employees/" + employeeID + "/getavatar", Method.GET);
                if (request == null)
                    return null;

                request.AddHeader("Authorization", GetAuth());
                var response = client.Execute(request);
                if (response.ErrorException == null && response.StatusCode == HttpStatusCode.OK)
                {
                    var content = (JObject)JsonConvert.DeserializeObject(response.Content);
                    JToken result = (JToken)JsonConvert.DeserializeObject(content["result"].ToString());
                    if (result == null)
                        return null;

                    return GetImage(result["thumbSizeUrl"].ToString());
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Image ByteArrayToImage(byte[] bArray)
        {
            if (bArray == null)
                return null;

            Image newImage;

            try
            {
                MemoryStream ms = new MemoryStream(bArray);
                newImage = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                newImage = null;
            }

            return newImage;
        }

        public static List<HRRequestLeaveDayFilesInfo> GetImageLeaveDays(int requestLeaveDayID, int employeeID)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ApiBaseUrl"]))
                    return null;

                ApiClientHelper.Login(BOSApp.CurrentUsersInfo.ADUserName, BOSApp.CurrentUsersInfo.ADPassword);
                var client = new RestClient(ConfigurationManager.AppSettings["ApiBaseUrl"]);
                var request = new RestRequest("employee/" + employeeID + "/leavedayrequest/" + requestLeaveDayID + "/images", Method.GET);
                request.AddHeader("Authorization", GetAuth());
                var response = client.Execute(request);
                if (response.ErrorException == null && response.StatusCode == HttpStatusCode.OK)
                {
                    var content = (JObject)JsonConvert.DeserializeObject(response.Content);
                    JArray result = (JArray)JsonConvert.DeserializeObject(content["result"].ToString());
                    List<HRRequestLeaveDayFilesInfo> listFiles = new List<HRRequestLeaveDayFilesInfo>();
                    result.All(o =>
                    {
                        if (ToLeaveDayFilesInfo(o) != null)
                        {
                            listFiles.Add(ToLeaveDayFilesInfo(o));
                        }
                        return true;
                    });
                    return listFiles;
                }
                return new List<HRRequestLeaveDayFilesInfo>();
            }
            catch (Exception)
            {
                return new List<HRRequestLeaveDayFilesInfo>();
            }
        }

        public static HRRequestLeaveDayFilesInfo ToLeaveDayFilesInfo(JToken image)
        {
            try
            {
                return new HRRequestLeaveDayFilesInfo()
                {
                    HRRequestLeaveDayFileGUID = (Guid)GuidHelper.Parse(image["guid"].ToString()),
                    HRRequestLeaveDayFileImage = GetImage(image["thumbSizeUrl"].ToString())
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool AddImageLeaveDay(List<String> paths, int requestLeaveDayID)
        {
            if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ApiBaseUrl"]))
                return false;

            ApiClientHelper.Login(BOSApp.CurrentUsersInfo.ADUserName, BOSApp.CurrentUsersInfo.ADPassword);
            var client = new RestClient(ConfigurationManager.AppSettings["ApiBaseUrl"]);
            var request = new RestRequest("/employee/leavedayrequest/addimages", Method.POST);
            request.AddHeader("Authorization", GetAuth());
            request.AlwaysMultipartFormData = true;
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddParameter("requestLeaveDayId", requestLeaveDayID, ParameterType.RequestBody);
            paths.ForEach(o => request.AddFileBytes("ImageFiles", File.ReadAllBytes(o), Path.GetFileName(o), "image/jpg"));
            var response = client.Execute(request);
            if (response.ErrorException == null && response.StatusCode == HttpStatusCode.OK)
                return true;

            return false;
        }

        public static bool DeleteImageLeaveDay(List<String> paths, int requestLeaveDayID)
        {
            if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ApiBaseUrl"]))
                return false;

            ApiClientHelper.Login(BOSApp.CurrentUsersInfo.ADUserName, BOSApp.CurrentUsersInfo.ADPassword);
            var client = new RestClient(ConfigurationManager.AppSettings["ApiBaseUrl"]);
            var request = new RestRequest("/employee/leavedayrequest/requestLeaveDayId", Method.POST);
            request.AddHeader("Authorization", GetAuth());
            request.AlwaysMultipartFormData = true;
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddParameter("requestLeaveDayId", requestLeaveDayID, ParameterType.RequestBody);
            paths.ForEach(o => request.AddFileBytes("ImageFiles", File.ReadAllBytes(o), Path.GetFileName(o), "image/jpg"));
            var response = client.Execute(request);
            if (response.ErrorException == null && response.StatusCode == HttpStatusCode.OK)
                return true;

            return false;
        }
    }
}
