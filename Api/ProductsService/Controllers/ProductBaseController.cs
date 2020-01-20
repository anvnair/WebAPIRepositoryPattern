#region Namespaces
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;
using System.Security.Claims;
using ProductService.Models;
using ProductService.Services;
using MediatR;
using ProductService.Commands;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

/// <summary>
/// Controller to handle products related actions
/// </summary>
namespace ProductService.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public abstract class ProductBaseController<TEntity, TRepository> : ControllerBase
          where TEntity : class, IEntity
          where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public ProductBaseController(TRepository repository)
        {
            this.repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }
    }
}
