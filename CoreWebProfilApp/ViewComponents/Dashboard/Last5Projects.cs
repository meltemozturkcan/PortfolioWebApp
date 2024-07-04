using Microsoft.AspNetCore.Mvc;

namespace CoreWebProfilApp.ViewComponents.Dashboard
{
    public class Last5Projects:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
