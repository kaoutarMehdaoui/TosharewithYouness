using System.ComponentModel.DataAnnotations.Schema;

namespace shopOnline.Api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }

        public double Price { get; set; }
        public int qte { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public ProductCategory ProductCategory { get; set; }



    }
}
