using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ProyectoHospital.DAO
{
    public class ClienteDAO
    {
        public string cadenaConexion = "Server=DESKTOP-F; database=Proyecto; integrated security =true";
       public int guardar (Cliente cliente)
        {
            SqlConnection conexion =new SqlConnection(cadenaConexion);
            string sql = "insert into Clientes(numCedula, nombres, apellidos, fechaNacimiento, crearContraseña) " +
                "values(@numCedula, @nombres, @apellidos, @fechaNacimiento, @crearContraseña)";
            SqlCommand comando = new SqlCommand(sql, conexion);

            conexion.Open();
            comando.Parameters.Add(new SqlParameter("@numCedula", cliente.numCedula));
            comando.Parameters.Add(new SqlParameter("@nombres", cliente.nombres));
            comando.Parameters.Add(new SqlParameter("@apellidos", cliente.apellidos));
            comando.Parameters.Add(new SqlParameter("@fechaNacimiento", cliente.fechaNacimiento));
            comando.Parameters.Add(new SqlParameter("@crearContraseña", cliente.crearContraseña));

            int resultado = comando.ExecuteNonQuery();
            conexion.Close();   
            return resultado;
        }
    }
}
