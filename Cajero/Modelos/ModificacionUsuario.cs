using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero.Modelos
{
    public class ModificacionUsuario
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Fecha { get; set; }
        public string TipoModificacion { get; set; }
        public string DatoAnterior { get; set; }
        public string DatoActualizado { get; set; }
    }
}