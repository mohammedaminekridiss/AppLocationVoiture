using System;
using System.Collections.Generic;
using AppLocationVoiture.DAL;
using System.Linq;
using System.Data.Entity;
namespace AppLocationVoiture.BLL
{
    public class LocationService
    {
        public static readonly LocationService Instance = new LocationService();
        public int CreerLocation(int IdVoiture, int IdClient, DateTime DateDebut, DateTime DateRestitution, int IdAgenceRestitution, decimal TotalTTC)
        {
            return 0;
        }
        public int AjouterOption(int IdLocation, int IdOption)
        { return 0; }


        public List<Agence> RechercherAgences()
        {
            List<Agence> agences = new List<Agence>();
            using (var db = new LocationDBEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                agences = db.Agence.ToList();
            }
            return agences;
        }


    }
}


