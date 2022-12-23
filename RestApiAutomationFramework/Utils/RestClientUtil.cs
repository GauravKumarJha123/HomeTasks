using Newtonsoft.Json;
using RestSharp;
using System.Configuration;
using System.Net;

namespace RestApiAutomationFramework.Utils
{
    public class RestClientUtil
    {
        static RestClient _RestClient;
        static RestRequest _RestRequest;
        //post

        public static RestClient RestClient
        {
            get
            {
                if (_RestClient == null)
                {
                    return new RestClient(
                        ConfigurationManager.AppSettings["BaseUrl"].ToString());
                }
                else
                {
                    return _RestClient;
                }
            }
        }

        public static RestRequest CreateRequest(string resource, Method method)
        {
            if (_RestRequest == null)
            {
                return new RestRequest(resource, method);
            }
            else
            {
                return _RestRequest;
            }
        }

        public static T Post<T>(string resource, string payload)
        {
            var response = RestClient.Execute
                (
                    CreateRequest(resource, Method.Post)
                    .AddJsonBody(payload)
                );
            var responseBody = response.Content;
            return JsonConvert.DeserializeObject<T>(responseBody);
        }

        public static T Put<T>(string resource, string payload)
        {
            var response = RestClient.Execute
                (
                    CreateRequest(resource, Method.Put)
                    .AddJsonBody(payload)
                );
            var responseBody = response.Content;
            return JsonConvert.DeserializeObject<T>(responseBody);
        }

        public static T Patch<T>(string resource, string payload)
        {
            var response = RestClient.Execute
                (
                    CreateRequest(resource, Method.Patch)
                    .AddJsonBody(payload)
                );
            var responseBody = response.Content;
            return JsonConvert.DeserializeObject<T>(responseBody);
        }

        public static T Get<T>(string resource, string payload)
        {
            var response = RestClient.Execute
                (
                    CreateRequest(resource, Method.Get)
                );
            var responseBody = response.Content;
            return JsonConvert.DeserializeObject<T>(responseBody);
        }

        // delete
        public static bool Delete(string resource, HttpStatusCode expectedStatusCode)
        {
            var response = RestClient.Execute
                (
                    CreateRequest(resource, Method.Delete)
                );
            return response.StatusCode.Equals(expectedStatusCode);
        }

        // retrieve



        //update
    }
}
