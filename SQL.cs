using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TournamentManager
{
    class SQL
    {
        static SqlConnection conn;

        public static List<object>[] GetPlayersAndTeams()
        {
            return Select(@"SELECT players.id, players.name, teams.id, teams.name, FROM players
  JOIN playersteams ON ( players.id = playersteams.player_id)
  JOIN teams ON ( teams.id = playersteams.team_id)", 4);
        }

        static void Connect()
        {
            try
            {
                string dir = Directory.GetCurrentDirectory();
                string s = Properties.Settings.Default.databaseConnectionString;
                string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + dir + @"\database.mdf;Integrated Security=True";
                //MessageBox.Show(s);
                conn = new SqlConnection(s);
                conn.Open();
            }

            catch
            {
                conn.Close();
                conn.Dispose();
            }
        }

        internal static Dictionary<int, string> GetPlayers()
        {
            return Select2<int, string>("select id, name from players", "id", "name");
        }

        public static Dictionary<int, string> GetTeams()
        {
            return Select2<int, string>("select id, name from teams", "id", "name");
        }

        public static List<object>[] GetTournaments()
        {
            return Select(@"select tournaments.id, tournaments.name, tournaments.begin_date, tournaments.end_date, tournaments.game_id, games.name from tournaments
                JOIN games on (games.id = tournaments.game_id)",
                6);
        }

        static Dictionary<TKey, TValue> Select2<TKey, TValue>(string text, string key, string value)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(text, conn);
            Dictionary<TKey, TValue> ret = new Dictionary<TKey, TValue>();
            try
            {
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            TKey k  = (TKey)reader[0];
                            //int index = reader.GetOrdinal(key);
                            //TKey k = (TKey)reader.GetValue(index);
                            //index = reader.GetOrdinal(value);
                            TValue v = (TValue)reader[1];
                            ret.Add(k, v);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                Disconnect();
            }
            return ret;
        }

        static List<object>[] Select(string text, int count)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(text, conn);
            List<object>[] ret = new List<object>[count];
            for (int i = 0; i < count; ++i)
                ret[i] = new List<object>();
            try
            {
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < count; ++i)
                            {
                                //int index = reader.GetOrdinal(name[i]);
                                //object element = reader.GetValue(index);
                                ret[i].Add(reader[i]);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                Disconnect();
            }
            return ret;
        }

        internal static Dictionary<int, string> GetPlayerTeams(int playerID)
        {
            return Select2<int, string>(@"SELECT teams.id, teams.name FROM teams
JOIN playersteams ON (teams.id = playersteams.team_id)
WHERE playersteams.player_id = " + playerID.ToString(), "teams.id", "teams.name");
        }

        internal static Dictionary<int, string> GetTeamPlayers(int teamID)
        {
            return Select2<int, string>(@"SELECT players.id, players.name FROM players
JOIN playersteams ON (players.id = playersteams.player_id)
WHERE playersteams.team_id = " + teamID.ToString(), "players.id", "players.name");
        }    

        internal static Dictionary<int, string> GetTournamentTeams(int tournamentID)
        {
            return Select2<int, string>(@"SELECT teams.id, teams.name FROM teams
JOIN tournamentsteams ON (teams.id = tournamentsteams.team_id)
WHERE tournamentsteams.tournament_id = " + tournamentID.ToString(), "teams.id", "teams.name");
        }

        internal static List<object>[] GetMatches(int tournamentID)
        {
            return Select(@"SELECT matches.id, matches.team1score, matches.team2score, matches.team1_id, team1.name,
matches.team2_id, team2.name, matchformats.id, matchformats.name, matchcategories.id, matchcategories.name FROM matches
JOIN matchformats ON (matchformats.id = matches.match_format_id)
JOIN teams team1 ON (matches.team1_id = team1.id)
JOIN teams team2 ON (matches.team2_id = team2.id)
JOIN matchcategories ON (matches.match_category_id = matchcategories.id)
WHERE matches.tournament_id = " + tournamentID.ToString(), 11);
        }

        static void Disconnect()
        {
            conn.Close();
            conn.Dispose();
        }

        public static bool AddPlayer(string name)
        {
            return ExecuteNonQuery("insert into players (name) values (@sub);", name, "@sub");
        }

        static bool ExecuteNonQuery(string text, string str, string sub)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(text, conn);
            cmd.Parameters.Add(new SqlParameter(sub, str));
            //cmd.Parameters[sub].Value = str;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                Disconnect();
            }
            return true;
        }

    }
}
