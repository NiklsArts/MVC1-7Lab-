using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }


        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest)
        {
            // Нужно отправить данные нового гостя no электронной почте 
            // организатору вечеринки.
            if (ModelState.IsValid)
                return View("Thanks", guest);
            else
                return View();

        }
    }
}