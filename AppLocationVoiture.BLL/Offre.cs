using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLocationVoiture.DAL;

namespace AppLocationVoiture.BLL
{
    public class Offre
    {
        public Voiture Voiture { get; set; }
        public decimal PrixJourTtc { get; set; }

        public decimal PrixTotalTtc { get; set; }
    }
}
