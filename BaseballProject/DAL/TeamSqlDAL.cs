using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using BaseballProject.Models;

namespace BaseballProject.DAL
{
    public class TeamSqlDAL : ITeamDAL
    {

        private readonly string connectionString;

        public TeamSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Team> GetAllTeams()
        {

            IList<Team> teams = new List<Team>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"SELECT * FROM teams ORDER BY name ASC;";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        Team team = new Team();

                        team.Name = Convert.ToString(reader["name"]);
                        team.City = Convert.ToString(reader["city"]);
                        team.State = Convert.ToString(reader["state"]);
                        team.FoundedYear = Convert.ToInt32(reader["founded"]);

                        teams.Add(team);
                    }
                }

            }
            catch(SqlException ex)
            {
                throw ex;
            }
            return teams;
        }

    }
}
