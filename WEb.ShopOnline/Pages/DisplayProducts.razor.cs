using Microsoft.AspNetCore.Components;
using ShopOnline.Modes.DTOs;

namespace WEb.ShopOnline.Pages
{
    public partial class DisplayProducts
    {

        [Parameter]
        public ProductDTO Product { get; set; }
    }
}
