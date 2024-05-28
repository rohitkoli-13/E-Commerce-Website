using Newtonsoft.Json;
using OnlineShoppingClient.Models;
using System.Net.Http.Headers;

namespace OnlineShoppingClient.Services
{
    public class CategoryServices:ICategoryServices
    {
        public void Add(Category category)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //set restAPI Address
                    client.BaseAddress = new Uri("http://localhost:5213/");
                    //converting model data to json
                    var contentData = new StringContent(JsonConvert.SerializeObject(category), System.Text.Encoding.UTF8, "application/json");
                    //calling api Router
                    HttpResponseMessage response = client.PostAsync("api/Category/Add", contentData).Result;

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
                        client.DeleteAsync($"api/Category/Delete/{id}").Result;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Category> GetAll()
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
                    HttpResponseMessage response = client.GetAsync("api/Category/GetAll").Result;
                    List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(response.Content.ReadAsStringAsync().Result);
                    return categories;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Category GetCategory(string id)
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
                    HttpResponseMessage response = client.GetAsync($"api/Category/GetCategory/{id}").Result;
                    Category category = JsonConvert.DeserializeObject<Category>(response.Content.ReadAsStringAsync().Result);
                    return category;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Category category)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5213/");
                    var contentData = new StringContent(JsonConvert.SerializeObject(category),
                        System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PutAsync("api/Category/Update", contentData).Result;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
