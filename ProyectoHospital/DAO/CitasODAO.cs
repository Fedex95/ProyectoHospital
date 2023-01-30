using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHospital.DAO
{
    public class CitasODAO
    {
        public string cadenaConexion2 = "Server=DESKTOP-F; database=Proyecto; integrated security =true";
        public int aceptar(Citas citas)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion2);
            string sql = "insert into sacarCitaO(medico, fechaAtencion, horaCita) " +
                "values(@medico, @fechaAtencion, @horaCita)";
            SqlCommand comando = new SqlCommand(sql, conexion);

            conexion.Open();
            comando.Parameters.Add(new SqlParameter("@medico", citas.medico));
            comando.Parameters.Add(new SqlParameter("@fechaAtencion", citas.fechaAtencion));
            comando.Parameters.Add(new SqlParameter("@horaCita", citas.horaCita));
            int resultado = comando.ExecuteNonQuery();
            conexion.Close();
            return resultado;
        }

    }
}
