using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebProfilApp.ViewComponents.Experiance
{
    public class ExperienceList : ViewComponent
    {
        ExperianceManager experienceManager = new ExperianceManager(new EfExperianceDal());

        public IViewComponentResult Invoke()
        {
            var values = experienceManager.TGetList();
            return View(values);
        }
    }
}
