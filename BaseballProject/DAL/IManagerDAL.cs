using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseballProject.Models;

namespace BaseballProject.DAL
{
    public interface IManagerDAL
    {
        IList<Manager> GetAllManagers();

    }
}
