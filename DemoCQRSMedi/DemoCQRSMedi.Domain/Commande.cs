using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCQRSMedi.Domain
{
    public class Commande
    {
        public Guid Id { get; set; }
        public double Montant { get; set; }
        public DateTime Date { get; set; }
        public int Numero { get; set; }

    }
}
