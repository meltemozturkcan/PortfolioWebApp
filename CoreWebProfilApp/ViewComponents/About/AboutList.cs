using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebProfilApp.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
        AboutManager aboutmanager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = aboutmanager.TGetList();
            return View(values);
        }
    }
}
