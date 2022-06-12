using NLayer.Data.Models;
using NLayer.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service {
  public class CategoryService : BaseService<Category> {
    private readonly IRepository<Category> _categoryRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CategoryService(IRepository<Category> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork) {
      this._categoryRepository = repository;
      this._unitOfWork = unitOfWork;
    }
  }
}