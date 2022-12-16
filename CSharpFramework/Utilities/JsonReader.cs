using AngleSharp.Text;
using MongoDB.Bson;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace UtilityClassLib.Utilities
{
    public class JsonReader
    {
        //public string[]? users { get; set; }
        //public string? pass { get; set; }
        //public string[]? firstName { get; set; }
        //public string[]? lastName { get; set; }
        //public string[]? zipCode { get; set; }
        public JsonReader() { 
        
        }    
            
      
        public string ExtractData(string tokenName)
        {
           var myJsonString = File.ReadAllText("Utilities/TestData.json");

           var jsonObject = JToken.Parse(myJsonString);
           return jsonObject.SelectToken(tokenName).Value<string>();
        }

        //private var myJsonStringh = File.ReadAllText("Utilities/TestData.json");
        //readonly TestDataClass? testData = JsonSerializer.Deserialize<TestDataClass>(myJsonStringh);
        public string[] UserDetails(string tokenName)
        {
            var myJsonString = File.ReadAllText("Utilities/TestData.json");

            var jsonObject = JToken.Parse(myJsonString);
            List<string> users = jsonObject.SelectTokens(tokenName).Values<string>().ToList();
            return users.ToArray();
        }


    }
}
