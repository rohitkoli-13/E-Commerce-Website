using Newtonsoft.Json;
using OnlineShoppingClient.Models;
using System.Net.Http.Headers;

namespace OnlineShoppingClient.Services
{
    public class OrderServices : IOrderServices
    {
        public void Delete(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                //set rest api address
                client.BaseAddress = new Uri("http://localhost:5258/");
                //calling the api router
                HttpResponseMessage response =
                    client.DeleteAsync($"api/Order/Delete/{id}").Result;
            }
        }

        public List<Order> GetAllOrders()
        {
            using (HttpClient client = new HttpClient())
            {
                //set rest api address
                client.BaseAddress = new Uri("http://localhost:5213/");
                //set content type to application/json
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("api/Order/GetAllOrders").Result;
                List<Order> orders = JsonConvert.DeserializeObject<List<Order>>(response.Content.ReadAsStringAsync().Result);
                return orders;
            }
        }

        public Order GetOrderById(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                //set rest api address
                client.BaseAddress = new Uri("http://localhost:5213/");
                //set content type to application/json
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync($"api/Order/GetOrderById/{id}").Result;
                Order orders = JsonConvert.DeserializeObject<Order>(response.Content.ReadAsStringAsync().Result);
                return orders;
            }
        }

        public void Update(Order order)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5213/");
                var contentData = new StringContent(JsonConvert.SerializeObject(order),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PutAsync($"api/Order/Update", contentData).Result;
            }
        }
        public void Add(Order order)
        {
            using (HttpClient client = new HttpClient())
            {
                //set rest api address
                client.BaseAddress = new Uri("http://localhost:5213/");
                //converting model data to json
                var contentData = new StringContent(JsonConvert.SerializeObject(order), System.Text.Encoding.UTF8, "application/json");
                //calling the api router
                HttpResponseMessage response = client.PostAsync("api/Admin/Register", contentData).Result;
            }
        }
    }
}
