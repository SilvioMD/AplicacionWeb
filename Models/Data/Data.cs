using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace WebLogin.Models.Data
{
    public static class Data
    {

        public static DataTable Query(string sql, List<SqlParameter> parametros, CommandType tipo, string conexion)
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;

            try
            {
                SqlCommand cmd = new SqlCommand(sql, new SqlConnection(conexion))
                {
                    CommandType = tipo
                };
                foreach (var p in parametros)
                {
                    cmd.Parameters.Add(p);
                }

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                cmd.Connection.Close();
            }
            catch(Exception e) {

                dt.Columns.Add("error");
                dt.Columns.Add(e.Message);
            }

            return dt;
        }
    }
}