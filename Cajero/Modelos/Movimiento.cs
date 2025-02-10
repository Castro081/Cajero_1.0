using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero.Modelos
{
    public class Movimiento
    {
        public int Id { get; set; }
        public int IdCajero { get; set; }
        public int IdUsuario { get; set; }
        public string Operacion { get; set; }
        public string Fecha { get; set; }
    }
}
