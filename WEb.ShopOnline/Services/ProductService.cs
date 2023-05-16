using ShopOnline.Modes.DTOs;
using System.Net.Http.Json;
using WEb.ShopOnline.Services.Contracts;

namespace WEb.ShopOnline.Services
{
    public class ProductService :IProductService
    {
        private readonly HttpClient _httpClient;
        public ProductService(HttpClient httpClient)
        { 
            _httpClient = httpClient;
            
            
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            try
            {
                var reponse = await this._httpClient.GetAsync("api/Product/Items");

                if (reponse.IsSuccessStatusCode)
                {
                    if (reponse.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<ProductDTO>();
                    }
                    return await reponse.Content.ReadFromJsonAsync<IEnumerable<ProductDTO>>();
                }
                else
                {
                    var message = await reponse.Content.ReadAsStringAsync();
                    throw new Exception($"Http status code: {reponse.StatusCode} message: {message}");
                }
                //var reponse = await _httpClient.GetFromJsonAsync<IEnumerable<ProductDTO>>("api/Product/Items");
                //return reponse; 
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
