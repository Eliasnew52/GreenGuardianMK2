using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenGuardianMK2
{
    public class DataSender
    {
        private SqlCommand Query;
        GreenGuardianMK2.DBAccess Cnn = new GreenGuardianMK2.DBAccess();


        public bool STATS_UPDATE(int ID, string Stats)
        {
            Cnn.Conexion.Open();
            Query = new SqlCommand();
            Query.Connection = Cnn.Conexion;
            Query.CommandText = "STATS_UPDATE";
            Query.CommandType = CommandType.StoredProcedure;

            Query.Parameters.Add(new SqlParameter("@Device_ID", SqlDbType.Int)).Value = ID;
            Query.Parameters.Add(new SqlParameter("@STATS",SqlDbType.NVarChar)).Value = Stats;

            int i = Query.ExecuteNonQuery();
            Cnn.Conexion.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
