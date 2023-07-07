using ClassWithParameters;
using PortfolioBlazor.Interfaces;

namespace PortfolioBlazor.Services
{
    public class ServiceProducts : IProduct
    {
        private readonly HttpClient _httpClient;
        public ServiceProducts(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        //Jeszcze się dowiedzieć po co te to tutaj no:
        public async Task<IEnumerable<Products>> GetProducts()
        {
            return await _httpClient.GetFromJsonAsync<Products[]>("api/product/getProducts");
        }
    }
}
