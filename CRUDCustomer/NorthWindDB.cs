using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDCustomer
{
    internal class NorthWindDB
    {
        private string connectionString = "Data source=LAPTOP-ARIEL;Initial catalog=Northwind;User=sa;Password=1234;";
        public bool Ok()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public string getConnection() { return connectionString; }
    }
}
