using Newtonsoft.Json;
using OnlineShoppingClient.Models;
using System.Net.Http.Headers;

namespace OnlineShoppingClient.Services
{
    public class FavouriteServices:IFavouriteServices
    {
        public void Add(Favourite favourite)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //set restAPI Address
                    client.BaseAddress = new Uri("http://localhost:5213/");
                    //converting model data to json
                    var contentData = new StringContent(JsonConvert.SerializeObject(favourite), System.Text.Encoding.UTF8, "application/json");
                    //calling api Router
                    HttpResponseMessage response = client.PostAsync("api/Favourite/Add", contentData).Result;

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
                        client.DeleteAsync($"api/Favourite/Delete/{id}").Result;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Favourite> GetAll()
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
                    HttpResponseMessage response = client.GetAsync("api/Favourite/GetAll").Result;
                    List<Favourite> favourites = JsonConvert.DeserializeObject<List<Favourite>>(response.Content.ReadAsStringAsync().Result);
                    return favourites;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
