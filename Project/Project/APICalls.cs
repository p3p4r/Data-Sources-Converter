using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Project
{
    class APICalls
    {
        public bool isValidUrl(string url)
        {
            try
            {
                //Creating the HttpWebRequest
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                //Setting the Request method HEAD, you can also use GET too.
                request.Timeout = 15000;
                request.Method = "GET";
                //Getting the Web Response.
                
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                //Returns TRUE if the Status code == 200
                response.Close();
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                //Any exception will returns false.
                return false;
            }
        }

        public string GetFromApi(string url)
        {
            if (isValidUrl(url))
            {
                try
                {
                    HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(url));

                    WebReq.Method = "GET";

                    HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();
                    string jsonString;
                    using (Stream stream = WebResp.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
                    {
                        StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                        jsonString = reader.ReadToEnd();
                    }
                    
                    return jsonString;

                }catch(Exception) { return "";  }
            }
            return "";
           
        }

        public string JsonToApi(string outputUrl, string json)
        {
            //Regex.Replace(inputUrl, @"\s", "");
            Regex.Replace(outputUrl, @"\s", "");

            if (json.Length == 0)
            {
                return "No Data has been received.";
            }

            if (outputUrl.Length == 0)
                return "Url output is not valid.";
            

            var jObj = JObject.Parse(json);

            //var t = JsonConvert.DeserializeObject(json);

            // Get Pameters  
            var firstKey = jObj.First.Path;

            if (firstKey == "data")
            {
                jObj = (JObject)jObj.SelectToken(firstKey);
            }

            var client = new HttpClient();
            var pairs = new List<KeyValuePair<string, string>>();

            foreach (var kvp in jObj.Cast<KeyValuePair<string, JToken>>().ToList())
            {
                var key = kvp.Key;
                var value = kvp.Value;

                pairs = new List<KeyValuePair<string, string>>
                    {
                        new KeyValuePair<string, string>(key, value.ToString()),
                    };
            }
            var content = new FormUrlEncodedContent(pairs);

            var response = client.PostAsync(outputUrl.ToString(), content).Result;

            if (!response.IsSuccessStatusCode) // Onerror 
            { 
                return "An Error Occurred!";
            }

            return "Sent to the endpoint successfully!";
        }
    }
}
