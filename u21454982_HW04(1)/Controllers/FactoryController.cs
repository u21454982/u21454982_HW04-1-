using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21454982_HW04_1_.ViewModels;

namespace u21454982_HW04_1_.Controllers
{
    public class FactoryController : Controller
    {
        // GET: Factory
        public ActionResult Index()
        {
            List<FactoryViewModel> Factories = GetTestData();
            return View(Factories);
        }
        private List<FactoryViewModel> GetTestData()
        {
            List<FactoryViewModel> Factories = new List<FactoryViewModel>();
            FactoryViewModel Fact1 = new FactoryViewModel("Darrian", "Cloete", 23, "Little", "None");
            FactoryViewModel Fact2 = new FactoryViewModel("Ruben", "Marx", 21, "Little", "Few");
            FactoryViewModel Fact3 = new FactoryViewModel("Milan", "Lombaard", 25, "Average", "A lot");
            FactoryViewModel Fact4 = new FactoryViewModel("Mia", "de Cock", 20, "Average", "Average");
            FactoryViewModel Fact5 = new FactoryViewModel("Rone", "Myburgh", 20, "A lot", "Average");
            Factories.Add(Fact1);
            Factories.Add(Fact2);
            Factories.Add(Fact3);
            Factories.Add(Fact4);
            Factories.Add(Fact5);
            return Factories;
        }
    }
}