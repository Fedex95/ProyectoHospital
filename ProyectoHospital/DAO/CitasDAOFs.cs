using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHospital.DAO
{
    public class CitasDAOFs
    {
        public string cadenaConexion2 = "Server=DESKTOP-F; database=Proyecto; integrated security =true";
        public int aceptar(Citas citas)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion2);
            string sql = "insert into sacarCitaFs(numCedula2, nombres2, apellidos2, medico, fechaAtencion) " +
                "values(@numCedula2, @nombres2, @apellidos2, @medico, @fechaAtencion)";
            SqlCommand comando = new SqlCommand(sql, conexion);

            conexion.Open();
            comando.Parameters.Add(new SqlParameter("@numCedula2", citas.numCedula2));
            comando.Parameters.Add(new SqlParameter("@nombres2", citas.nombres2));
            comando.Parameters.Add(new SqlParameter("@apellidos2", citas.apellidos2));
            comando.Parameters.Add(new SqlParameter("@medico", citas.medico));
            comando.Parameters.Add(new SqlParameter("@fechaAtencion", citas.fechaAtencion));
            int resultado = comando.ExecuteNonQuery();
            conexion.Close();
            return resultado;
        }

    }
}