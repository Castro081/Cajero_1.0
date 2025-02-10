using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }  
        public string Direccion { get; set; } 
        public string Telefono { get; set; }  
        public string Correo { get; set; }
        public string NumeroTarjeta { get; set; }
        public string Pin { get; set; }
        public int Id_Tipo { get; set; }
        public int SaldoActual { get; set; }
        public int MontoMaximo { get; set; }
        public bool PrimerInicio { get; set; }
        public bool Estado { get; set; }

        public TipoUsuario TipoUsuario { get; set; }
        public int IdCuenta { get; set; }
    }
}