using Microsoft.EntityFrameworkCore;
using NLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Data.Repositories {
  public abstract class Repository<TEntity> : IRepository<TEntity>
      where TEntity : class {

    private readonly DbSet<TEntity> _dbSet;
    public Repository(AppDBContext context) {
      _dbSet = context.Set<TEntity>();
    }

    public async Task<TEntity> Add(TEntity entity) {
      await _dbSet.AddAsync(entity);
      return entity;
    }

    public async Task<TEntity> Delete(int id) {
      var entity = await _dbSet.FindAsync(id);
      if (entity == null) {
        return entity;
      }
      _dbSet.Remove(entity);
      return entity;
    }

    public async Task<TEntity> Get(int id) {
      return await _dbSet.FindAsync(id);
    }

    public async Task<List<TEntity>> GetAll() {
      return await _dbSet.ToListAsync();
    }

    public async Task<TEntity> Update(TEntity entity) {
      //context.Entry(entity).State = EntityState.Modified;
      //await context.SaveChangesAsync();
      return entity;
    }
  }
}