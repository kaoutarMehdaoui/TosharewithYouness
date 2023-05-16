using Microsoft.AspNetCore.Components;
using ShopOnline.Modes.DTOs;
using WEb.ShopOnline.Services.Contracts;

namespace WEb.ShopOnline.Pages
{
    public partial class ProductAdds :ComponentBase
    {
        [Inject]
        public IProductService _productService { get; set; }
        public IEnumerable<ProductDTO> ProductFromApi { get; set; }=new List<ProductDTO>();

         protected override async Task OnInitializedAsync()
        {
            ProductFromApi = (await _productService.GetProducts()).ToList();
           

         }
    }
}
