using Microsoft.AspNetCore.Mvc;
using NLayer.Data.Models;
using NLayer.Data.Repositories;
using NLayer.Service;

namespace NLayer.API.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class CategoryController : BaseController<Category, CategoryRepository> {
    private  CategoryService categoryService;
    public CategoryController(CategoryService categoryService) : base(categoryService) {
      this.categoryService = categoryService;
    }
  }
}
