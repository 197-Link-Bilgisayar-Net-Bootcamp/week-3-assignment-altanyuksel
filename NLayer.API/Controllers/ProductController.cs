using Microsoft.AspNetCore.Mvc;
using NLayer.Data;
using NLayer.Data.Models;
using NLayer.Data.Repositories;
using NLayer.Service;

namespace NLayer.API.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class ProductController : BaseController<Product, ProductRepository> {
    private readonly ProductService productService;
    private readonly UnitOfWork unitOfWork;

    public ProductController(ProductService productService, UnitOfWork unitOfWork) : base(productService, unitOfWork) {
      this.productService = productService;
      this.unitOfWork = unitOfWork;
    }
  }
}