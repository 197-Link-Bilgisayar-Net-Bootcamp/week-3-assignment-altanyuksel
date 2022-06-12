using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Data {
  public class UnitOfWork {
    private readonly AppDBContext _dbContext;
    public UnitOfWork(AppDBContext dbContext) {
      _dbContext = dbContext;
    }
    public async Task Commit() {
      await _dbContext.SaveChangesAsync();
    }
  }
}