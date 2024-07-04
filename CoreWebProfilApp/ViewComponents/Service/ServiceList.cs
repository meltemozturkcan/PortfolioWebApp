using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebProfilApp.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
       ServiceManager servicemanager = new ServiceManager(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = servicemanager.TGetList();
            return View(values);
        }
    }
}
