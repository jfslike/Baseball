using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BaseballProject.Models;

namespace BaseballProject.DAL
{
    public class PlayerSqlDAL : IPlayerDAL
    {

        private readonly string connectionString;

        public PlayerSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        

        public IList<Player> GetAllPlayers()
        {
            IList<Player> players = new List<Player>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();


                    string sql = @"SELECT * FROM players ORDER BY last_name ASC;";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        Player player = new Player();

                        player.PlayerId = Convert.ToInt32(reader["player_id"]);
                        player.LastName = Convert.ToString(reader["last_name"]);
                        player.FirstName = Convert.ToString(reader["first_name"]);
                        player.Position = Convert.ToString(reader["position"]);
                        player.TeamName = Convert.ToString(reader["team_name"]);
                        player.UniformNumber = Convert.ToInt32(reader["uniform_number"]);

                        players.Add(player);
                    }

                }

            }
            catch(SqlException ex)
            {
                throw ex;
            }
            return players;
                
        }
    }
}
