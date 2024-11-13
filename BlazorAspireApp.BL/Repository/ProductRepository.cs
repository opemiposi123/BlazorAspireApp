using BlazorAspireApp.Database.DataContext;
using BlazorAspireApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorAspireApp.BL.Repository
{
    public class ProductRepository(AppDbContext dbContext) : IProductRepository
    {
        public Task<List<ProductModel>> GetProducts()
        {
            return dbContext.Products.ToListAsync();
        }

        public Task<ProductModel> GetProduct(int id)
        {
            return dbContext.Products.FirstOrDefaultAsync(n => n.ID == id);
        }

        public async Task<ProductModel> CreateProduct(ProductModel productModel)
        {
            dbContext.Products.Add(productModel);
            await dbContext.SaveChangesAsync();
            return productModel;
        }
        public async Task UpdateProduct(ProductModel productModel)
        {
            dbContext.Entry(productModel).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
        }
        public Task<bool> ProductModelExists(int id)
        {
            return dbContext.Products.AnyAsync(e => e.ID == id);
        }
        public async Task DeleteProduct(int id)
        {
            var product = dbContext.Products.FirstOrDefault(n => n.ID == id);
            dbContext.Products.Remove(product);
            await dbContext.SaveChangesAsync();
        }
    }
}
