using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21454982_HW04_1_.ViewModels;

namespace u21454982_HW04_1_.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            List<AdminViewModel> Admins = GetTestData();
            return View(Admins);
        }
        private List<AdminViewModel> GetTestData()
        {
            List<AdminViewModel> Admins = new List<AdminViewModel>();
            AdminViewModel Admin1 = new AdminViewModel("Rainier", "Grey", 19,  "Little", "A lot");
            AdminViewModel Admin2 = new AdminViewModel("Stefan", "Klopper", 24,  "Little", "A lot" );
            AdminViewModel Admin3 = new AdminViewModel("Ivan", "Naude", 21,  "Average", "A lot" );
            AdminViewModel Admin4 = new AdminViewModel("JJ", "Bench", 18,  "Little", "Average" );
            AdminViewModel Admin5 = new AdminViewModel("Lisa", "Venter", 18,  "A lot", "Average");
            Admins.Add(Admin1);
            Admins.Add(Admin2);
            Admins.Add(Admin3);
            Admins.Add(Admin4);
            Admins.Add(Admin5);
            return Admins;
        }
    }
}