using Microsoft.AspNetCore.Mvc;

namespace CoreWebProfilApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
