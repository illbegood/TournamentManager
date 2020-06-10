using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager
{
    public class DBConnection

    {

        private SqlConnection conn;

        public DBConnection()

        {
            //constructor

        }
    
        ~DBConnection()

        {
            //destructor
            conn = null;

        }

        public void Disconnect()

        {

            conn.Close();

        }

        public string ConnectToDatabase()

        {
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\proger777\c#\TournamentManager\database.mdf;Integrated Security=True");
                conn.Open();
                return "Connected";

            }

            catch (SqlException e)

            {
                conn.Close();
                conn = null;
                return e.Message;

            }

        }

    }
}
