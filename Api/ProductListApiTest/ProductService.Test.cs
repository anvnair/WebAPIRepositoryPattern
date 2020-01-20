#region Namespaces
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using ProductService;
using ProductService.Commands;
using ProductService.Controllers;
using ProductService.Models;
using ProductService.Services;
#endregion

/// <summary>
/// Namespace to test Product list api
/// </summary>
namespace ProductListApiTest
{
    [TestFixture]
    /// <summary>Controller to test Product list api</summary>
    public class WhenProductServiceCalledFor
    {
        /// <summary>The mock product repository service</summary>
        private Mock<IProductRepositoryService> mockproductService = new Mock<IProductRepositoryService>();
        /// <summary>The user</summary>
        private ClaimsPrincipal user;
        private Mock<IMediator> mockMediator = new Mock<IMediator>();
        /// <summary>Setups this instance.</summary>
        [SetUp]
        public void Setup()
        {
            user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
                     {
                            new Claim(ClaimTypes.Name, "dummy name"),
                            new Claim(ClaimTypes.NameIdentifier, "1"),
                            new Claim("custom-claim", "dummy claim value"),
                     }, "mock"));
        }
        /// <summary>Gets the test asynchronous for all products</summary>
        [Test]
        public void AllProducts_Always_ReturnsProducts()
        {
            //Mock<IProductService> prodRepo = new Mock<IProductService>();
            //var mockSet = new Mock<DbSet<ProductItem>>();

            //var mockContext = new Mock<ProductContext>();
            //mockContext.Setup(m => m.Products).Returns(mockSet.Object);

            //var service = new ProductService.Services.ProductService(mockContext.Object);
            //service.GetAllProducts("");
            //mockSet.Verify(m => m.Add(It.IsAny<ProductItem>()), Times.Once());
            //mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        /// <summary>Gets the test asynchronous for all products</summary>
        [Test]
        public async Task AddNewProducts_Always_AddSuccessfully()
        {
            //Mock<IProductService> prodRepo = new Mock<IProductService>();
            //var mockSet = new Mock<ProductItem>();
            //var mockContext = new Mock<ProductContext>();
            //var service = new ProductService.Services.ProductService(mockContext.Object);
            //var res = await service.AddProductItem(mockSet.Object);

        }
    }


}
