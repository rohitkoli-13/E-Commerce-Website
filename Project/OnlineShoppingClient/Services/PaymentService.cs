using Newtonsoft.Json;
using OnlineShoppingClient.Models;
using System.Net.Http.Headers;

namespace OnlineShoppingClient.Services
{
    public class PaymentService : IpaymentService
    {
        public void AddPayment(Payment payment)
        {
            using (HttpClient client = new HttpClient())
            {
                //set RestApi Address
                client.BaseAddress = new Uri("http://localhost:5213/");
                //converting model data to json

                var contentData = new StringContent(JsonConvert.SerializeObject(payment),
                     System.Text.Encoding.UTF8, "application/Json");
                //call the api router
                HttpResponseMessage response = client.PostAsync("api/Payment/AddPayment", contentData).Result;

            }
        }

        public List<Payment> GetAllPayments()
        {
            using (HttpClient client = new HttpClient())
            {
                //set RestApi Address
                client.BaseAddress = new Uri("http://localhost:5213/");
                //set content type to application/json

                MediaTypeWithQualityHeaderValue contentType =
                new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);//send content request type to APi
                HttpResponseMessage response = client.GetAsync("api/Payment/GetPayments").Result;

                List<Payment> payments = JsonConvert.DeserializeObject<List<Payment>>
                    (response.Content.ReadAsStringAsync().Result);
                return payments;
            }
        }
    }
}
