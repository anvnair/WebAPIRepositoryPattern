#region Namespaces
using Microsoft.EntityFrameworkCore;
using ProductService.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
#endregion

/// <summary>
/// Namespace to hold Product Item 
/// </summary>
namespace ProductService.Models
{
    public class ProductRepository : ProductAppRepository<ProductItem, ProductContext>
    {
        private IProductRepositoryService _productService;

        public ProductRepository(ProductContext context, IProductRepositoryService ProductService) : base(context)
        {
            _productService = ProductService;
        }

        /// <summary>To Gets all products.</summary>
        /// <param name="owner">The owner.</param>
        /// <returns></returns>
        public override List<ProductItem> GetAllProducts(string owner)
        {
            List<ProductItem> products = new List<ProductItem>();
            try
            {
                var options = new DbContextOptionsBuilder<ProductContext>()
             .UseInMemoryDatabase(databaseName: "ProductsDB")
             .Options;
                using (var context = new ProductContext(options))
                {
                    products = context.Products.Where(t => t.Owner == owner).ToList();
                }
            }
            //Not using any exception variable as not performing any operation on exception
            //Thus left as (Exception)
            catch (Exception)
            {
                //To do(Not doing for Hands on excercise) : Log service level exception and throw appropriate exception code               
            }
            return products;
        }

        public async override Task<ProductItem> AddProductItem(ProductItem NewProduct)
        {
            var options = new DbContextOptionsBuilder<ProductContext>()
       .UseInMemoryDatabase(databaseName: "ProductsDB")
       .Options;
            using (var context = new ProductContext(options))
            {
                //Anish:  Need to be implemented with DTO object using Automapper for mapping to user model
                context.Products.Add(new ProductItem { Owner = NewProduct.Owner, Title = NewProduct.Title });
                await context.SaveChangesAsync();
            }
            return NewProduct;
        }
    }
}
