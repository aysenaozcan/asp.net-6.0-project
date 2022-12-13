using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcBlogProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm=new CategoryManager(new EfCategoryRepository()); 
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values); 
        }
    }
}
