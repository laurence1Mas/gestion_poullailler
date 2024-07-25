using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_poullailler.Classes.clsConnection
{
    class Connexion
    {
        SqlConnection con;
        public SqlConnection DBConnect()
        {
            try
            {
                string strConnectionString = "Server=DESKTOP-HTI1CR5;Database=db_gestion_poullailler;User Id=SA;Password=laure";
                con = new SqlConnection(strConnectionString);
                con.Open();

                return con;
            }
            catch (SqlException )
            {
                return null;
            }
        }
    }
}
