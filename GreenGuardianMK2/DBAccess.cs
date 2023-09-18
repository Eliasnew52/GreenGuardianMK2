using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenGuardianMK2
{
    public class DBAccess
    {
        public string DB_URL = "SQL";
        public SqlConnection Conexion;
        public SqlCommand Query;

        public DBAccess()
        {
            Conectar();
        }

        public void Conectar()
        {
            Conexion = new SqlConnection(DB_URL);
        }

    }
}
