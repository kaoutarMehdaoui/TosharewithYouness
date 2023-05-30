using Microsoft.AspNetCore.Components;
using ShopOnline.Modes.DTOs;
using System.Collections.Immutable;
using WEb.ShopOnline.Services.Contracts;

namespace WEb.ShopOnline.Pages
{
    public class ProductAdds : ComponentBase
    {
        [Inject]
        public IProductService _productService { get; set; }
        public IEnumerable<ProductDTO> ProductFromApi { get; set; } = new List<ProductDTO>();

        protected override async Task OnInitializedAsync()
        {
            ProductFromApi = (await _productService.GetProducts()).ToList();


        }
        protected IOrderedEnumerable<IGrouping<string,ProductDTO>> GetGroupedProductsByCategory() 
        {
            var  result = from product in ProductFromApi group product by product.CategoryName into probyCatGroup orderby probyCatGroup.Key select  probyCatGroup ;
            return result;
        }
        protected string GetCategoryName(IGrouping<string, ProductDTO> product)
        {
             

             string categoryName = product.FirstOrDefault(ct=>ct.CategoryName== product.Key).CategoryName;
            return categoryName;
            

        }
    }
}
