using Microsoft.AspNetCore.Mvc;
using NLayer.Data;
using NLayer.Data.Models;
using NLayer.Data.Repositories;
using NLayer.Service;

namespace NLayer.API.Controllers {
  public class BaseController<TEntity, TRepository> : ControllerBase
        where TEntity : class
        where TRepository : IRepository<TEntity> {

    private readonly BaseService<TEntity> baseService;
    private UnitOfWork unitOfWork;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TEntity>>> Get() {
      return (await baseService.Get());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TEntity>> Get(int id) {
      var entity = await baseService.Get(id);
      if (entity == null) {
        return NotFound();
      }
      return entity;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, TEntity entity) {
      await baseService.Put(id, entity);
      return Ok();
    }

    // POST: api/[controller]
    [HttpPost]
    public async Task<ActionResult<TEntity>> Post(TEntity entity) {
      await baseService.Post(entity);
      return null; //CreatedAtAction("Get", new { id = entity.Id }, entity);
    }

    // DELETE: api/[controller]/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<TEntity>> Delete(int id) {
      var entity = await baseService.Delete(id);
      if (entity == null) {
        return NotFound();
      }
      return entity;
    }
  }
}