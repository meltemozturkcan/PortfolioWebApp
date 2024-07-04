using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebProfilApp.ViewComponents.Testimonial
{
    namespace Core_Proje.ViewComponents.Testimonial
    {
        public class TestimonialList : ViewComponent
        {
            TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());

            public IViewComponentResult Invoke()
            {
                var values = testimonialManager.TGetList();
                return View(values);
            }
        }
    }
}
