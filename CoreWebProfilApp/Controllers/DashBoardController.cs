﻿using Microsoft.AspNetCore.Mvc;

namespace CoreWebProfilApp.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
