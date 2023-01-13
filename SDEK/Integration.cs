using SDEK.Models;
using System.Net.Http;
using System.Text;
using System.Xml.XPath;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;
using System.Runtime.InteropServices.JavaScript;
using System;
using System.Web;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using System.Security.Principal;
using Newtonsoft.Json;

namespace SDEK
{
    public class Integration
    {
        static string url = "https://api.edu.cdek.ru/v2/";
        public static async Task<AuthResponseDTO> Auth(AuthDTO model) 
        {
            HttpClient client = new HttpClient();

            var parameters = new Dictionary<string, string> { 
                { "grant_type", model.grant_type },
                {"client_id", model.client_id},
                {"client_secret",  model.client_secret}    
            };
            var postData = new FormUrlEncodedContent(parameters);
            using (HttpResponseMessage result = client.PostAsync("https://api.edu.cdek.ru/v2/oauth/token?parameters", postData).Result)
            {
                string resultJson = result.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<AuthResponseDTO>(resultJson);
            }
        }

        public static async Task<ResponeDTO> RegOrder(OrderDTO model, string token) 
        {

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            using StringContent postData = new(
                JsonConvert.SerializeObject(new 
                {
                    tariff_code = model.Tariff_code,
                    shipment_point = model.Shipment_point,
                    sender = model.Sender,
                    recipient = model.Recipient,
                    to_location = model.ToLocation,
                    services = model.Services,
                    packages = model.Packages
                }),
                Encoding.UTF8,
                "application/json");

            using (HttpResponseMessage result = client.PostAsync("https://api.edu.cdek.ru/v2/orders", postData).Result)
            {
                string resultJson = result.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<ResponeDTO>(resultJson);
            }
        }


        public static async Task<OrderInfoResponseDTO> GetOrderInfoByUuid(string id, string token) 
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var response =  client.GetAsync("https://api.edu.cdek.ru/v2/orders/" + id).Result;
            string resultJson = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<OrderInfoResponseDTO>(resultJson);

        }

        public static async Task<ResponeDTO> DeleteOrder(string id, string token) 
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var response = client.DeleteAsync("https://api.edu.cdek.ru/v2/orders/" + id).Result;
            var resultJson = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<ResponeDTO>(resultJson);
        }

        public static async Task<List<OfficeResponseDTO>> GetOffices(OfficesSearchParams searchParams, string token) 
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            var builder = new UriBuilder("https://api.edu.cdek.ru/v2/deliverypoints");
            builder.Port = -1;
            var query = HttpUtility.ParseQueryString(builder.Query);
            if (searchParams.take_only != null)
            {
                query["take_only"] = searchParams.take_only == true ? "1" : "0";
            }
            if (searchParams.have_cashless != null)
            {
                query["have_cashless"] = searchParams.have_cashless == true ? "1" : "0";
            }
            if (searchParams.have_cash != null)
            {
                query["have_cash"] = searchParams.have_cash == true ? "1" : "0";
            }
            if (searchParams.allowed_cod != null)
            {
                query["allowed_cod"] = searchParams.allowed_cod == true ? "1" : "0";
            }
            if (searchParams.is_dressing_room != null)
            {
                query["is_dressing_room"] = searchParams.is_dressing_room == true ? "1" : "0";
            }
            if (searchParams.is_handout != null)
            {
                query["is_handout"] = searchParams.is_handout == true ? "1" : "0";
            }
            if (searchParams.is_reception != null)
            {
                query["is_reception"] = searchParams.is_reception == true ? "1" : "0";
            }
            query["postal_code"] = searchParams.postal_code.ToString();
            query["city_code"] = searchParams.city_code.ToString();
            query["type"] = searchParams.type;
            query["country_code"] = searchParams.country_code;
            query["region_code"] = searchParams.region_code.ToString();
            query["weight_max"] = searchParams.weight_max.ToString();
            query["weight_min"] = searchParams.weight_min.ToString();
            builder.Query = query.ToString();
            string url = builder.ToString();


            var response = client.GetAsync(url).Result;
            string resultJson = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<OfficeResponseDTO>>(resultJson);
        }


        public static async Task<ResponeDTO> RefusalReg(string id, string token) 
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            var response =  client.PostAsync("https://api.edu.cdek.ru/v2/orders/" + id + "/refusal", null).Result;
            var resultJson = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<ResponeDTO>(resultJson);
        }

        public static async Task<ResponeDTO> OrderUpdate(OrderDTO model,string token) 
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);


             using StringContent postData = new(
                JsonConvert.SerializeObject(new
                {
                    //uuid = "72753031-f9e6-4488-83de-ae2a92ae9900",
                    //comment = "1111111111"
                    uuid = model.uuid,
                    comment = model.comment,
                    tariff_code = model.Tariff_code,
                    shipment_point = model.Shipment_point,
                    sender = model.Sender,
                    recipient = model.Recipient,
                    to_location = model.ToLocation,
                    services = model.Services,
                    packages = model.Packages
                }),
                Encoding.UTF8,
                "application/json");

            var response = client.PatchAsync("https://api.edu.cdek.ru/v2/orders", postData).Result;
            Console.WriteLine(response);
            var resultJson = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<ResponeDTO>(resultJson);

        }
    }
}