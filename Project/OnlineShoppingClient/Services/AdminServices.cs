using Newtonsoft.Json;
using OnlineShoppingClient.Models;
using System.Net.Http.Headers;

namespace OnlineShoppingClient.Services
{
    public class AdminServices:IAdminServices
    {
        public void Delete(string AdminId)
        {
            using (HttpClient client = new HttpClient())
            {
                //set rest api address
                client.BaseAddress = new Uri("http://localhost:5213/");
                //calling the api router
                HttpResponseMessage response =
                    client.DeleteAsync($"api/Admin/Delete/{AdminId}").Result;
            }
        }

        public Admin GetAdmin(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                //set rest api address
                client.BaseAddress = new Uri("http://localhost:5213/");
                //set content type to application/json
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync($"api/Admin/GetAdmin/{id}").Result;
                Admin admin = JsonConvert.DeserializeObject<Admin>(response.Content.ReadAsStringAsync().Result);
                return admin;
            }
        }

        public List<Admin> GetAllAdmin()
        {
            using (HttpClient client = new HttpClient())
            {
                //set rest api address
                client.BaseAddress = new Uri("http://localhost:5213/");
                //set content type to application/json
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("api/Admin/GetAllAdmins").Result;
                List<Admin> admins = JsonConvert.DeserializeObject<List<Admin>>(response.Content.ReadAsStringAsync().Result);
                return admins;
            }
        }

        public void Register(Admin admin)
        {
           
                using (HttpClient client = new HttpClient())
                {
                    //set restAPI Address
                    client.BaseAddress = new Uri("http://localhost:5213/");
                    //converting model data to json
                    var contentData = new StringContent(JsonConvert.SerializeObject(admin), System.Text.Encoding.UTF8, "application/json");
                    //calling api Router
                    HttpResponseMessage response = client.PostAsync("api/Admin/Register", contentData).Result;

                }
            
        }

        public void Update(Admin admin)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5213/");
                var contentData = new StringContent(JsonConvert.SerializeObject(admin),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PutAsync("api/Admin/Update", contentData).Result;
            }
        }

        public Admin Validate(string email, string pwd)
        {
            using (HttpClient client = new HttpClient())
            {
                //set rest api address
                client.BaseAddress = new Uri("http://localhost:5213/");
                //set content type to application/json
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync($"api/Admin/Validate/{email}/{pwd}").Result;
                Admin admin = JsonConvert.DeserializeObject<Admin>(response.Content.ReadAsStringAsync().Result);
                return admin;
            }
        }

    }
}
