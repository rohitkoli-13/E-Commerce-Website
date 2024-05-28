using Newtonsoft.Json;
using OnlineShoppingClient.Models;
using System.Net.Http.Headers;

namespace OnlineShoppingClient.Services
{
    public class YourOrdersServices : IYourOrdersServices
    {
        public void Delete(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                //set rest api address
                client.BaseAddress = new Uri("http://localhost:5258/");
                //calling the api router
                HttpResponseMessage response =
                    client.DeleteAsync($"api/YourOrders/Delete/{id}").Result;
            }
        }

        public List<YourOrders> GetAllyourOrders()
        {
            using (HttpClient client = new HttpClient())
            {
                //set rest api address
                client.BaseAddress = new Uri("http://localhost:5258/");
                //set content type to application/json
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("api/YourOrders/GetAllyourOrders").Result;
                List<YourOrders> yourorders = JsonConvert.DeserializeObject<List<YourOrders>>(response.Content.ReadAsStringAsync().Result);
                return yourorders;
            }
        }

        public YourOrders GetYourOrderById(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                //set rest api address
                client.BaseAddress = new Uri("http://localhost:5258/");
                //set content type to application/json
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync($"api/YourOrders/GetYourOrderById/{id}").Result;
                YourOrders yourorders = JsonConvert.DeserializeObject<YourOrders>(response.Content.ReadAsStringAsync().Result);
                return yourorders;
            }
        }
        public void Add(YourOrders order)
        {
            using (HttpClient client = new HttpClient())
            {
                //set rest api address
                client.BaseAddress = new Uri("http://localhost:5258/");
                //converting model data to json
                var contentData = new StringContent(JsonConvert.SerializeObject(order), System.Text.Encoding.UTF8, "application/json");
                //calling the api router
                HttpResponseMessage response = client.PostAsync("api/Admin/Register", contentData).Result;
            }
        }
    }
}
