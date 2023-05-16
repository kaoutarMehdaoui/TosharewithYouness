using ShopOnline.Modes.DTOs;

namespace WEb.ShopOnline.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProducts();


    }
}
