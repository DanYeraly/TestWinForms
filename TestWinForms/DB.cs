using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWinForms
{
    class DB
    {
        SqlConnection connect = new SqlConnection(@"Data source=HOME-PC; Initial Catalog=WinForm;Integrated Security=True");

        public void openConnection()
        {
            if (connect.State==System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        public void closeConnection()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return connect;
        }



    }
}
