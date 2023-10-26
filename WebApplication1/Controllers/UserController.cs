using Microsoft.AspNetCore.Mvc;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateUserViewModel());
        }
        [HttpPost]
        public IActionResult Create(CreateUserViewModel vm)
        {
            //stworzyć user z vm => przekieruj na index 

            return RedirectToAction(nameof(Index));
        }
    }
}
