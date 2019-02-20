using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            string TimeOfDay;

            if (hour < 12)
            {
                TimeOfDay = "Good Morning";
            }
            else if (hour < 18)
            {
                TimeOfDay = "Good Afternoon";
            }
            else
            {
                TimeOfDay = "Good Evening";
            }

            ViewBag.Greeting = TimeOfDay;

            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }
    }
}