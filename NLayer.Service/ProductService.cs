using NLayer.Data;
using NLayer.Data.Models;
using NLayer.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service {
  public class ProductService {
    private readonly AppDBContext _context;
    private readonly Repository<Product> _productRepository;
    private readonly UnitOfWork _unitOfWork;

    public ProductService(AppDBContext context, Repository<Product> prodRepository, UnitOfWork unitOfWork) {
      _context = context;
      _productRepository = prodRepository;
      _unitOfWork = unitOfWork;
    }

    public async Task<List<Product>> Create(Product product) {
      await _productRepository.Add(product);
      _unitOfWork.Commit();
      return new List<Product> { product };
    }
  }
}