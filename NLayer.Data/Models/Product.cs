using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Data.Models {
  public class Product {
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public double Stock { get; set; }
    public Category Category { get; set; }
    public int CategoryId { get; set; }
    public ProductFeature ProductFeature { get; set; }
  }
}
