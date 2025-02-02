using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLocationVoiture.DAL;

namespace AppLocationVoiture.BLL
{
    public class AssuranceService
    {
        public static readonly AssuranceService Instance = new AssuranceService();

        public List<Assurance> RechercherAssurance()
        {
            List<Assurance> assurances = new List<Assurance>();
            using (var db = new LocationDBEntities())
            {
                assurances = db.Assurance.ToList();
            }
            return assurances;
        }
    }
}
