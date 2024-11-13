﻿using BlazorAspireApp.BL.Repository;
using BlazorAspireApp.Models.Entities;

namespace BlazorAspireApp.BL.Services
{
    public class ProductService(IProductRepository productRepository) : IProductService
    {
        public Task<ProductModel> CreateProduct(ProductModel productModel)
        {
            return productRepository.CreateProduct(productModel);
        }

        public Task<ProductModel> GetProduct(int id)
        {
            return productRepository.GetProduct(id);
        }

        public Task<List<ProductModel>> GetProducts()
        {
            return productRepository.GetProducts();
        }

        public Task<bool> ProductModelExists(int id)
        {
            return productRepository.ProductModelExists(id);
        }

        public Task UpdateProduct(ProductModel productModel)
        {
            return productRepository.UpdateProduct(productModel);
        }
        public Task DeleteProduct(int id)
        {
            return productRepository.DeleteProduct(id);
        }
    }
}
