using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BaseballProject.Models;

namespace BaseballProject.DAL
{
    public class StadiumSqlDAL : IStadiumDAL
    {
        private readonly string connectionString;

        public StadiumSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public IList<Stadium> GetAllStadiums()
        {
            IList<Stadium> stadiums = new List<Stadium>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"SELECT * FROM stadiums ORDER BY name ASC;";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        Stadium stadium = new Stadium();

                        stadium.Name = Convert.ToString(reader["name"]);
                        stadium.City = Convert.ToString(reader["city"]);
                        stadium.State = Convert.ToString(reader["state"]);
                        stadium.TeamName = Convert.ToString(reader["team_name"]);
                        stadium.Capacity = Convert.ToInt32(reader["capacity"]);
                        stadium.YearBuilt = Convert.ToInt32(reader["year_built"]);

                        stadiums.Add(stadium);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }

            return stadiums;
        }
    }
}
