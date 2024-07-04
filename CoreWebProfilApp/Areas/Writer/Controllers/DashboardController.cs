using DataAccessLayer.Concreate;

using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace CoreWebProfilApp.Areas.Writer.Controllers
{ 
[Area("Writer")]
public class DashboardController : Controller
{
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
    {
        var values = await _userManager.FindByNameAsync(User.Identity.Name);
        ViewBag.v = values.Name + " " + values.Surname;

            //Weather APi
            string api = "5b630dd921f7613392920c022e2736d5";
            string connection = " http://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //statistics
            Context c = new Context();
        ViewBag.v1 = c.WriterMessages.Where(x => x.Receiver == values.Email).Count();
        ViewBag.v2 = c.Announcements.Count();
        ViewBag.v3 = c.Users.Count();
        ViewBag.v4 = c.Skills.Count();
        return View();
    }
}
}
/*
 http://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=14ad2aba611dbef9c504b82a127794c5
 */