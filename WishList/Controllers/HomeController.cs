using System;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWishList.Controllers
{
    public class HomeController : Controller
    {
        #region Actions
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Error()
        {
            return View("Error");
        }

        #endregion
    }
}