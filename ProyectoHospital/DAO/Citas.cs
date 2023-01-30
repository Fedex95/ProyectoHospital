using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHospital.DAO
{
    public class Citas
    {
        public string medico { get; set; }
        public DateTime fechaAtencion { get; set; } 
        public string horaCita { get; set; }
    }
}
