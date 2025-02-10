using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero.Modelos
{
    public class Modificacion
    {
        public int Id { get; set; }
        public string usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoModificacion { get; set; }
    }
}
