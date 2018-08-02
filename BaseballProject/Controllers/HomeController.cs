using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BaseballProject.Models;
using BaseballProject.DAL;

namespace BaseballProject.Controllers
{
    public class HomeController : Controller
    {
        BaseballSQLDAL dal = new BaseballSQLDAL(@"Data Source =.\sqlexpress; Initial Catalog = Baseball; Integrated Security = True");

        // constructor to allow dependency injection
        private IPlayerDAL playerDal;
        public HomeController(IPlayerDAL playerDal)
        {
            this.playerDal = playerDal;
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Players()
        {
            var players = playerDal.GetAllPlayers();

            return View(players);
        }



        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
