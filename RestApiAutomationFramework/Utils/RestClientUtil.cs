using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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
        public static T Post<T>(string resource,string payload)
        {
            var response = RestClient.Execute
                (
                    CreateRequest(resource, Method.Post)
                    .AddJsonBody(payload)
                );
            var responseBody = response.Content;
            return JsonConvert.DeserializeObject<T>(responseBody);
        }

        public static RestRequest CreateRequest(string resource, Method method)
        {
            if(_RestRequest== null)
            {
                return new RestRequest(resource, method);
            }
            else
            {
                return _RestRequest;
            }
        }


        // delte
        public static bool Delete(string resource, HttpStatusCode expectedStatusCode)
        {

            var resposne = RestClient.Execute
                (
                    CreateRequest(resource, Method.Delete)
                );

                return resposne.StatusCode.Equals(expectedStatusCode);
        }


        public static string[] GetPost(string resource)
        {
            var response = RestClient.Execute
                (
                    CreateRequest(resource, Method.Get)
                );
            var responseBody = response.Content;
            return JsonConvert.DeserializeObject<string[]>(responseBody);
        }

        //public static string[] GetPost(string resource)
        //{
        //    var response = RestClient.Execute
        //        (
        //            CreateRequest(resource, Method.Get)
        //        );
        //    var responseBody = response.Content;
        //    return JsonConvert.SerializeObject<string[]>(responseBody);
        //}


        //update
    }
}
