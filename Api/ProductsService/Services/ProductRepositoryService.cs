#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductService.Models;
#endregion

/// <summary>
/// Namespace to handle product related operations
/// </summary>
namespace ProductService.Services
{
    /// <summary>Repositoru service class to handle product related operations</summary>
    /// <seealso cref="ProductsRepositoryService.Services.IProductService" />
    public class ProductsRepositoryService : IProductRepositoryService
    {
        /// <summary>The product context</summary>
        private readonly ProductRepository _productRepo;
        public ProductsRepositoryService(ProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        /// <summary>To Gets all products.</summary>
        /// <param name="owner">The owner.</param>
        /// <returns></returns>
        public List<ProductItem> GetAllProducts(string owner)
        {
            List<ProductItem> products = new List<ProductItem>();
            try
            {
                _productRepo.GetAllProducts(owner);
            }
            //Not using any exception variable as not performing any operation on exception
            //Thus left as (Exception)
            catch (Exception)
            {
                //To do(Not doing for Hands on excercise) : Log service level exception and throw appropriate exception code               
            }
            return products;
        }
        /// <summary>Adds the new product item.</summary>
        /// <param name="NewProduct">The new product.</param>
        /// <returns></returns>
        public async Task<ProductItem> AddProductItem(ProductItem NewProduct)
        {
            try
            {
                _productRepo.AddProductItem(NewProduct);
            }
            //Not using any exception variable as not performing any operation on exception
            //Thus left as (Exception)
            catch (Exception)
            {
                //To do(Not doing for Hands on excercise) : Log service level exception and throw appropriate exception code               
            }
            return NewProduct;
        }
    }
}
