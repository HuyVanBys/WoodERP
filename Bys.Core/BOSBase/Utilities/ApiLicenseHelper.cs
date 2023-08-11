using BOSCommon;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Configuration;
using System.Net;

namespace BOSERP.Utilities
{
    public class ApiLicenseHelper
    {
        public const string ApiLicenseUrl = "http://license.highnote.vn/api/v2/";

        public static int CheckLicense(string userName, ref string messageError)
        {
            try
            {
                string projectCode = ConfigurationManager.AppSettings["ProjectCode"];
                string ipAddress = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
                string pcName = System.Environment.MachineName.Replace("/", "-");
                string strRequest = string.Format("/license/{0}/{1}/{2}/{3}", projectCode, userName, ipAddress, pcName);
                
                var client = new RestClient(ApiLicenseUrl);
                var request = new RestRequest(strRequest, Method.GET);
                var response = client.Execute(request);
                if (response.ErrorException == null && response.StatusCode == HttpStatusCode.OK)
                {
                    var content = (JObject)JsonConvert.DeserializeObject(response.Content);
                    JToken result = (JToken)JsonConvert.DeserializeObject(content["Data"].ToString());
                    License license = ToLicense(result);
                    messageError = license.Message;
                    return license.IsActive ? (int)LicenseStatus.Active : (int)LicenseStatus.Inactive;
                }
                return (int)LicenseStatus.NoConnecttion;
            }
            catch (Exception ex)
            {
                return (int)LicenseStatus.NoConnecttion;
            }
        }

        public static License ToLicense(JToken license)
        {
            return new License()
            {
                IsActive = Convert.ToBoolean(license["IsActive"].ToString()),
                WorkingMode = license["WorkingMode"].ToString(),
                TransactionTime = license["TransactionTime"].ToString(),
                Message = license["Message"].ToString(),
            };
        }
    }

    public class License
    {
        public bool IsActive { get; set; }

        public string WorkingMode { get; set; }

        public string TransactionTime { get; set; }

        public string Message { get; set; }
    }
}
