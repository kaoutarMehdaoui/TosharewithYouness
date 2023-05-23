using Api.ShopOnline;
using Microsoft.EntityFrameworkCore;

using shopOnline.Api.Models;
using shopOnline.Api.Repositories.Contracts;

namespace shopOnline.Api.Repositories.Emplemention
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyContext _context;
        public ProductRepository(MyContext myContext)
        {
            _context = myContext;
        }

        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            return await _context.ProductCategories.ToListAsync();
        }

        public async Task<ProductCategory> GetCategory(int id)
        {
            ProductCategory CategoryFind = await _context.ProductCategories.FirstOrDefaultAsync(x => x.Id == id);


            return CategoryFind;


        }

        public async Task<Product> GetItem(int id)
        {
            Product item = await _context.Products.Include(p => p.ProductCategory).FirstOrDefaultAsync(x => x.Id == id);
            return item;


        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            return await _context.Products.Include(p => p.ProductCategory).ToListAsync();
        }
    }
}
