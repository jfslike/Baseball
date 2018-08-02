using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseballProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace BaseballProject.Controllers
{
    public class StadiumController : Controller
    {

        private IStadiumDAL stadiumDal;
        public StadiumController(IStadiumDAL stadiumDal)
        {
            this.stadiumDal = stadiumDal;
        }

        public IActionResult Stadiums()
        {
            var stadiums = stadiumDal.GetAllStadiums();

            return View(stadiums);
        }
    }
}