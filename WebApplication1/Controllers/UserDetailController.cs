using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UserDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
