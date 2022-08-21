using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21454982_HW04_1_.ViewModels;

namespace u21454982_HW04_1_.Controllers
{
    
        public class DriverController : Controller
        {
            // GET: Driver
            public ActionResult Index()
            {
                List<DriverViewModel> Drivers = GetTestData();
                return View(Drivers);
            }

            private List<DriverViewModel> GetTestData()
            {
                List<DriverViewModel> Drivers = new List<DriverViewModel>();
                DriverViewModel Driver1 = new DriverViewModel("Delano", "Opperman", "Driver", 20, "Little", 1);
                DriverViewModel Driver2 = new DriverViewModel("Giano", "Santos", "Driver", 18, "Little", 2);
                DriverViewModel Driver3 = new DriverViewModel("Sophie", "Roos", "Driver", 22, "Average", 4);
                DriverViewModel Driver4 = new DriverViewModel("Chrissie", "Ras", "Driver", 24, "Average", 4);
                DriverViewModel Driver5 = new DriverViewModel("Tom", "Davies", "Driver", 30, "Little", 12);
                Drivers.Add(Driver1);
                Drivers.Add(Driver2);
                Drivers.Add(Driver3);
                Drivers.Add(Driver4);
                Drivers.Add(Driver5);
                return Drivers;
            }
        }
    }