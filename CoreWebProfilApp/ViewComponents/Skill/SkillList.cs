using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebProfilApp.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillManager skillmanager = new SkillManager(new EfSkillDal());
        public IViewComponentResult Invoke()
        {
            var values = skillmanager.TGetList();
            return View(values);
        }
    }
}
