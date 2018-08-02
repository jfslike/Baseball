using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseballProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace BaseballProject.Controllers
{
    public class PlayerController : Controller
    {
        private IPlayerDAL playerDal;
        public PlayerController(IPlayerDAL playerDal)
        {
            this.playerDal = playerDal;
        }




        public IActionResult Players()
        {
            var players = playerDal.GetAllPlayers();
            return View(players);
        }

        


    }
}