using Microsoft.AspNetCore.Mvc;

namespace Divyesh_Sir.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
