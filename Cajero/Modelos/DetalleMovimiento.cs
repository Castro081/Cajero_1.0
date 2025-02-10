using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero.Modelos
{
    public class DetalleMovimiento
    {
        public int Id { get; set; }
        public int IdMovimiento { get; set; }
        public int Billete { get; set; }
        public int cantidadBillete { get; set; }
    }
}
