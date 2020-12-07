using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    class Facture
    {
        public string Client { get; set; }
        public int Numero { get; set; }
        public DateTime DateEmission { get; set; }
        public DateTime DateReception { get; set; }
        public float MontantDu { get; set; }
        public float MontantRegle { get; set; }

    }
}
