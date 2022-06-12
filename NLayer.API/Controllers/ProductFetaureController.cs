using Microsoft.AspNetCore.Mvc;
using NLayer.Data.Models;
using NLayer.Data.Repositories;
using NLayer.Service;

namespace NLayer.API.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class ProductFeatureController : BaseController<ProductFeature, ProductFeatureRepository> {
    private readonly ProductFeatureService productFeatureService;
    public ProductFeatureController(ProductFeatureService productFeatureService) : base(productFeatureService) {
      this.productFeatureService = productFeatureService;
    }
  }
}