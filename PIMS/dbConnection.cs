using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS
{
    internal class dbConnection
    {
        public string connectDb = "Server=localhost;Port=5432;User Id = postgres; Password=Miyaki_11;Database=PatientManagementSystem;";
        public NpgsqlConnection conn;

        public void Connect()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectDb))
                {
                    conn.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Connection failed!");
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
