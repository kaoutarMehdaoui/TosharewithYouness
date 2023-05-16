using shopOnline.Api.Models;
using ShopOnline.Modes.DTOs;

namespace Api.ShopOnline.Extension
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductDTO> ConvertToDto(this IEnumerable<Product>products,IEnumerable<ProductCategory> productCategories )
        {

            return (from Product in products join ProductCategory in productCategories on Product.CategoryId equals ProductCategory.Id 
                    
                    select new ProductDTO
                        { Id=Product.Id,
                         Name=Product.Name,
                         Description=Product.Description,
                         ImageURL=Product.ImageURL,
                         Price = (decimal)Product.Price,
                         Qty= Product.qte,
                        
                         CategoryId=ProductCategory.Id,
                         CategoryName=ProductCategory.Name,


                        }
                    ).ToList();
        }
    }
}
