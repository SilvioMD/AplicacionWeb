using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WebLogin.Models.Entity;


namespace WebLogin.Models.Action
{
    public static class UsuarioA
    {

        public static UsuarioE Get(string name)
        {
            //llamar la entidad usuario; que contiene los campos de la base de datos
            UsuarioE u = new UsuarioE();
            //se guarda la cedena de conexion con la base de datos 
            string Conexion = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            //agregar los comandos
            List<SqlParameter>  parametros = new List<SqlParameter>
            {
                new SqlParameter("name", name)
            };
            //cadena de la consulta
            string sql = "SELECT TOP 1 * FROM TblUsuario WHERE Usuario like @name";


            //crear data table para almacenar los datos
            _ = new DataTable();
            DataTable dt = Data.Data.Query(sql, parametros, CommandType.Text, Conexion);

            if (dt.Rows.Count > 0 )
            {
                u.Id = Convert.ToInt32(dt.Rows[0]["IdUsuario"].ToString());
                u.Cedula = dt.Rows[0]["Cedula"].ToString();
                u.Nombre = dt.Rows[0]["Nombres"].ToString();
                u.Apellidos = dt.Rows[0]["Apellidos"].ToString();
                u.Usuario = dt.Rows[0]["Usuario"].ToString();
                u.Contraseña = dt.Rows[0]["Contraseña"].ToString();
            }
            
            return u;
        }
            
    }
}