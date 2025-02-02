using System;
using System.Collections.Generic;
using System.Text;
using AppLocationVoiture.DAL;
using System.Data;
using System.Linq;
using System.Diagnostics;
using System.Globalization;
namespace AppLocationVoiture.BLL
{
    public class VoitureService

    {
        public static readonly VoitureService Instance = new VoitureService();

        public List<Offre> RechercherVoiture(int IdAgenceDepart, int IdAgenceRestitution, DateTime DateHeureDepart, DateTime DateHeureRetour)
        {
            List<Offre> offres = new List<Offre>();
            using (var db = new LocationDBEntities())
            {
                List<Voiture> voitures = db.Voiture.Include("Tarif").ToList();
                var nombre_jours = (DateHeureRetour - DateHeureDepart).TotalDays;

                foreach (var voiture in voitures)
                {

                    //var total = voiture.Tarif.Where(x => (int)DateHeureDepart.DayOfWeek == x.JourSemaine && GetWeekNumber(DateHeureDepart) == x.Semaine);
                    var tarif = voiture.Tarif.FirstOrDefault();
                    if (tarif != null)
                    {
                        var total = Convert.ToDouble(tarif.TarifTtc) * nombre_jours;
                        offres.Add(new Offre { Voiture = voiture, PrixTotalTtc = (decimal)total, PrixJourTtc = (decimal)tarif.TarifTtc });

                    }
                }
            }
            return offres;

        }
        public int GetWeekNumber(DateTime date)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(date,
            CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }
    }
}
