using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreWebProfilApp.Controllers
{
    public class Experience2Controller : Controller
    {
        ExperianceManager experienceManager = new ExperianceManager(new EfExperianceDal());
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult ListExperience()
    {
        var values = JsonConvert.SerializeObject(experienceManager.TGetList());
        return Json(values);
    }
    [HttpPost]
    public IActionResult AddExperience(Experiance p)
    {
        experienceManager.TAdd(p);
        var values = JsonConvert.SerializeObject(p);
        return Json(values);
    }
    public IActionResult GetById(int ExprerienceID)
    {
        var v = experienceManager.TGetByID(ExprerienceID);
        var values = JsonConvert.SerializeObject(v);
        return Json(values);
    }
    public IActionResult DeleteExperience(int id)
    {
        var v = experienceManager.TGetByID(id);
        experienceManager.TDelete(v);
        return NoContent();
    }
    public IActionResult UpdateExperince(Experiance p)
    {
        var v = experienceManager.TGetByID(p.ExperianceID);
        experienceManager.TUpdate(v);
        var values = JsonConvert.SerializeObject(p);
        return Json(values);
    }
}
}
