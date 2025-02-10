using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero.Modelos
{
    public class Transaccion
    {
        public int Id { get; set; }
        public int IdCuenta { get; set; }
        public string TipoTransaccion { get; set; }
        public int Monto { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public int IdCajero { get; set; }
    }
}
