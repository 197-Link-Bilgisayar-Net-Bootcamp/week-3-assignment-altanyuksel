using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service {
  public interface IService<TEntity> where TEntity : class {
    public Task<List<TEntity>> Get();
    Task<TEntity> Get(int id);
    Task<TEntity> Put(int id, TEntity entity);
    Task<TEntity> Post(TEntity entity);
    public Task<TEntity> Delete(int id);
  }
}
