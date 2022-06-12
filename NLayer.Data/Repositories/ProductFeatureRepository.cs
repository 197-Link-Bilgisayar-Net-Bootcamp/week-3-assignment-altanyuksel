using NLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Data.Repositories {
  public class ProductFeatureRepository : Repository<ProductFeature> {
    public ProductFeatureRepository(AppDBContext context) : base(context) {
    }
  }
}