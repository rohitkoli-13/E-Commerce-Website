using Newtonsoft.Json;
using OnlineShoppingClient.Services;
using OnlineShoppingClient.Models;
using System.Net.Http.Headers;

namespace OnlineShoppingClient.Services
{
    public class CustomerServices : ICustomerServices
    {
      
        public void Delete(string Id)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5213/");
                    HttpResponseMessage response = client.DeleteAsync($"api/Customer/Delete/{Id}").Result;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public List<Customer> GetAll()
        {

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //set restAPI Address
                    client.BaseAddress = new Uri("http://localhost:5213/");
                    //set content type to application/json
                    MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");

                    HttpResponseMessage response = client.GetAsync("api/Customer/GetAll").Result;
                    List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(response.Content.ReadAsStringAsync().Result);
                    return customers;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public Customer GetCustomer(string id)
        {

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //set restAPI Address
                    client.BaseAddress = new Uri("http://localhost:5213/");
                    //set content type to application/json
                    MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");

                    HttpResponseMessage response = client.GetAsync($"api/Customer/GetCustomer/{id}").Result;
                    Customer customer = JsonConvert.DeserializeObject<Customer>(response.Content.ReadAsStringAsync().Result);
                    return customer;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Registraion(Customer customer)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //set restAPI Address
                    client.BaseAddress = new Uri("http://localhost:5213/");
                    //converting model data to json
                    var contentData = new StringContent(JsonConvert.SerializeObject(customer), System.Text.Encoding.UTF8, "application/json");
                    //calling api Router
                    HttpResponseMessage response = client.PostAsync("api/Customer/Registration", contentData).Result;

                }
            }
            catch (Exception)
            {

                throw;
            }
              

        }

        public void Update(Customer customer)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5213/");
                    var contentData = new StringContent(JsonConvert.SerializeObject(customer),
                        System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PutAsync("api/Customer/Update", contentData).Result;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Customer Validate(string email, string password)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //set restAPI Address
                    client.BaseAddress = new Uri("http://localhost:5213/");
                    //set content type to application/json
                    MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");

                    HttpResponseMessage response = client.GetAsync($"api/Customer/Validate/{email}/{password}").Result;
                    Customer customer = JsonConvert.DeserializeObject<Customer>(response.Content.ReadAsStringAsync().Result);
                    return customer;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
