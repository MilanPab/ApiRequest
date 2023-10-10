using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WpfLibrary
{
    public class Class1
    {
        private HttpClient httpClient;
        public Class1()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.fyers.in/");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer YourAccessToken");
        }
        public async Task PlaceOrder(string symbol, string side, int quantity)
        {
            var orderRequest = new
            {
                Symbol = symbol,
                Side = side,
                Quantity = quantity,              
            };          
            var jsonOrderRequest = JsonConvert.SerializeObject(orderRequest);
            var content = new StringContent(jsonOrderRequest, Encoding.UTF8, "application/json");          
            HttpResponseMessage response = await httpClient.PostAsync("place-order-endpoint", content);

            if (response.IsSuccessStatusCode)
            {
                
            }
            else
            {  
                //  logging the error or throw an exception
            }
        }
    }
}
