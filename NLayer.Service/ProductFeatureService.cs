using NLayer.Data.Models;
using NLayer.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service {
  public class ProductFeatureService : BaseService<ProductFeature> {
    private readonly IRepository<ProductFeature> _categoryRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ProductFeatureService(IRepository<ProductFeature> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork) {
      this._categoryRepository = repository;
      this._unitOfWork = unitOfWork;
    }
  }
}