using Newtonsoft.Json;
using OnlineShoppingClient.Models;
using System.Net.Http.Headers;

namespace OnlineShoppingClient.Services
{
    public class ProductServices:IProductServices
    {
        public void Add(Product product)
        {
            try
            {

                using (HttpClient client = new HttpClient())
                {
                    //set restAPI Address
                    client.BaseAddress = new Uri("http://localhost:5213/");
                    //converting model data to json
                    var contentData = new StringContent(JsonConvert.SerializeObject(product), System.Text.Encoding.UTF8, "application/json");
                    //calling api Router
                    HttpResponseMessage response = client.PostAsync("api/Product/Add", contentData).Result;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(string id)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //set rest api address
                    client.BaseAddress = new Uri("http://localhost:5213/");
                    //calling the api router
                    HttpResponseMessage response =
                        client.DeleteAsync($"api/Product/Delete/{id}").Result;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Product> GetAll()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //set rest api address
                    client.BaseAddress = new Uri("http://localhost:5213/");
                    //set content type to application/json
                    MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                    client.DefaultRequestHeaders.Accept.Add(contentType);
                    HttpResponseMessage response = client.GetAsync("api/Product/GetAll").Result;
                    List<Product> products = JsonConvert.DeserializeObject<List<Product>>(response.Content.ReadAsStringAsync().Result);
                    return products;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Product GetProduct(string id)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //set rest api address
                    client.BaseAddress = new Uri("http://localhost:5213/");
                    //set content type to application/json
                    MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                    client.DefaultRequestHeaders.Accept.Add(contentType);
                    HttpResponseMessage response = client.GetAsync($"api/Product/GetProduct/{id}").Result;
                    Product product = JsonConvert.DeserializeObject<Product>(response.Content.ReadAsStringAsync().Result);
                    return product;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Product product)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5213/");
                    var contentData = new StringContent(JsonConvert.SerializeObject(product),
                        System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PutAsync("api/Product/Update", contentData).Result;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        
    }
}
