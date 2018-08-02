using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseballProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace BaseballProject.Controllers
{
    public class ManagerController : Controller
    {

        private IManagerDAL managerDal;
        public ManagerController(IManagerDAL managerDal)
        {
            this.managerDal = managerDal;
        }
        public IActionResult Managers()
        {
            var managers = managerDal.GetAllManagers();
            return View(managers);
        }
    }
}