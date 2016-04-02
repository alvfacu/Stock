using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Adapter
    {
        SqlConnection _sqlconn;

        public SqlConnection Sqlconn
        {
            get
            {
                return _sqlconn;
            }

            set
            {
                _sqlconn = value;
            }
        }

        public void OpenConnection()
        {
            string cadena = "Data Source=FACUNDO-PC;Initial Catalog=Raul;Integrated Security=True";
            SqlConnection SqlConn = new SqlConnection(cadena);
            Sqlconn.Open();
        }

        public void CloseConnection()
        {
            Sqlconn.Close();
            Sqlconn = null;
        }
    }
}
