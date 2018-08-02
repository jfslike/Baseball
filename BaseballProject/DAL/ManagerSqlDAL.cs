using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BaseballProject.Models;

namespace BaseballProject.DAL
{
    public class ManagerSqlDAL : IManagerDAL
    {
        private readonly string connectionString;

        public ManagerSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Manager> GetAllManagers()
        {
            IList<Manager> managers = new List<Manager>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"SELECT * FROM managers ORDER BY last_name ASC;";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        Manager manager = new Manager();

                        manager.LastName = Convert.ToString(reader["last_name"]);
                        manager.FirstName = Convert.ToString(reader["first_name"]);
                        manager.TeamName = Convert.ToString(reader["team_name"]);

                        managers.Add(manager);
                    }

                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            return managers;
        }


    }
}
