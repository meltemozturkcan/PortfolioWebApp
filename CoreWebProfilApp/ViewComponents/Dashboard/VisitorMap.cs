using Microsoft.AspNetCore.Mvc;

namespace CoreWebProfilApp.ViewComponents.Dashboard
{
    public class VisitorMap : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
