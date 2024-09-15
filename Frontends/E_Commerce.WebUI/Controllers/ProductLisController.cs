using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.WebUI.Controllers
{
    public class ProductLisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
