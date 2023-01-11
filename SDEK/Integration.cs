using SDEK.Models;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System.Xml.XPath;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;
using System.Web.Mvc;
using System.Web.WebPages;
using System.Runtime.InteropServices.JavaScript;
using System;

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
                //string jsonString = JsonSerializer.Serialize<WeatherForecast>(weatherForecast);
                return JsonSerializer.Deserialize<AuthResponseDTO>(resultJson);
            }
        }

        public static async Task RegOrder(OrderDTO model, string token) 
        {

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            using StringContent postData = new(
                JsonSerializer.Serialize(new 
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
                Console.WriteLine($"{resultJson}");
            }
        }


        public static async Task GetOrderInfoByUuid(string id, string token) 
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var response =  client.GetAsync("https://api.edu.cdek.ru/v2/orders/" + id).Result;
            Console.WriteLine(await response.Content.ReadAsStringAsync());

        }

        public static async Task DeleteOrder(string id, string token) 
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var response = client.DeleteAsync("https://api.edu.cdek.ru/v2/orders/" + id).Result;
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }

        public static async Task GetAllOffices(/*OfficesDTO model,*/string token) 
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var response = client.GetAsync("https://api.edu.cdek.ru/v2/deliverypoints").Result;
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }

        public static async Task RefusalReg(string id, string token) 
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            var response = await client.PostAsync("https://api.edu.cdek.ru/v2/orders/" + id + "/refusal", null);
        }

        public static async Task OrderUpdate(OrderDTO model,string token) 
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);


            using StringContent postData = new(
                JsonSerializer.Serialize(new
                {
                    uuid = model.uuid,
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

            var response = client.PatchAsync("https://api.edu.cdek.ru/v2/orders", postData);
            Console.WriteLine($"{response}");

        }
    }
}