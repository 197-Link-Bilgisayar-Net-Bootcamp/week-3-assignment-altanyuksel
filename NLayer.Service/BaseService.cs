using NLayer.Data.Models;
using NLayer.Data.Repositories;
using NLayer.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service {
  public abstract class BaseService<TEntity> : IService<TEntity> where TEntity : class {
    private readonly IRepository<TEntity> _repository;
    private readonly IUnitOfWork _unitOfWork;

    public BaseService(IRepository<TEntity> repository, IUnitOfWork unitOfWork) {
      _repository = repository;
      _unitOfWork = unitOfWork;
    }
    public async Task<List<TEntity>> Get() {
      return await _repository.GetAll();
    }
    public async Task<TEntity> Get(int id) {
      var entity = await _repository.Get(id);
      if (entity == null) {
        return null;
      }
      return entity;
    }
    public async Task<TEntity> Put(int id, TEntity entity) {
      //if (id != entity.Id) {
      //  return null;
      //}
      await _repository.Update(entity);
      return entity;
    }
    public async Task<TEntity> Post(TEntity entity) {
      await _repository.Add(entity);
      return entity;
    }
    public async Task<TEntity> Delete(int id) {
      var entity = await _repository.Delete(id);
      if (entity == null) {
        return null;
      }
      return entity;
    }
  }
}
