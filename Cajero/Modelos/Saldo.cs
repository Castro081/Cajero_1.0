using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero.Modelos
{
    public class Saldo
    {
        public int Id { get; set; }
        public int SaldoDisponible { get; set; }
        public int Limite { get; set; }
        public int IdCajero { get; set; }
        public DateTime FechaSaldo { get; set; }
    }

}
