using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero.Modelos
{
    public class InicioSesion
    {
        public int Id { get; set; }
        public string Cuenta { get; set; }
        public DateTime FechaInicio { get; set; }
        public int Id_Cajero { get; set; }

    }
}
