using NLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Data.Repositories {
  public interface IRepository<TEntity> where TEntity : class {
    Task<List<TEntity>> GetAll();
    Task<TEntity> Get(int i);
    Task<TEntity> Add(TEntity entity);
    Task<TEntity> Update(TEntity entity);
    Task<TEntity> Delete(int id);
  }
}
