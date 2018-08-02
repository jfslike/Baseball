using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballProject.DAL
{
    public class BaseballSQLDAL
    {
        private readonly string connectionString;


        
        public BaseballSQLDAL(string connectionString)
        {
            this.connectionString = connectionString;

        }
    }
}
