using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BOSERP.Utilities
{
    class NetHttp
    {
        private const string _errorMessage = "Error retrieving response.  Check inner details for more info.";
        private readonly string _baseUrl = "";
        public NetHttp(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public T Get<T>(string path, IDictionary<string, string> header)
        {
            var json = string.Empty;
            try
            {
                var client = new RestClient();
                client.BaseUrl = new Uri(_baseUrl + path);

                Func<RestRequest> requestFunc = () =>
                {
                    var request = new RestRequest(Method.GET);
                    if (header != null)
                        foreach (var item in header)
                            request.AddHeader(item.Key, item.Value);
                    return request;
                };

                var response = client.Execute(requestFunc());
                if (response.ErrorException != null)
                {
                    var ex = new ApplicationException(_errorMessage, response.ErrorException);
                    throw ex;
                }


                json = response.Content;

                var result = JsonConvert.DeserializeObject<T>(json);

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(GetType() + "-" + ex);
                throw ex;
            }
        }
    }
}
