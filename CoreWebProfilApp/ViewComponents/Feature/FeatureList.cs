

using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebProfilApp.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager featuremanager = new FeatureManager(new EfFeatureDal());       
        public IViewComponentResult Invoke()
        {
            var values=featuremanager.TGetList();
            return View(values);
        }
    }
}
