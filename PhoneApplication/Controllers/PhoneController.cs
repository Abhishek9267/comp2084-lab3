using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneApplication.Models;

namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {
            var Phonelist = new List<Phone>
            {
                new Phone { PhoneID = 0, PhoneName = "Galaxy S10", MSRP=34533, ScreenSize= 43, DateReleased = new DateTime(2020,01,23), Manufacturer = "Samsung" },
                new Phone { PhoneID = 1, PhoneName = "Oppo f7", MSRP=34533, ScreenSize= 43, DateReleased = new DateTime(2020,01,23), Manufacturer = "oppo"},
                new Phone { PhoneID = 2, PhoneName = "Model 10", MSRP=34533, ScreenSize= 43, DateReleased  =new DateTime(2020,01,23), Manufacturer = "Apple"}
            };
            return View(Phonelist);
           
        }
    }
}