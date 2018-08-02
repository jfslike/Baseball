using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseballProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace BaseballProject.Controllers
{
    public class TeamController : Controller
    {
        private ITeamDAL teamDal;
        public TeamController(ITeamDAL teamDal)
        {
            this.teamDal = teamDal;
        }
        
        public IActionResult Teams()
        {
            var teams = teamDal.GetAllTeams();
            return View(teams);
        }
        

     

      



    }
}