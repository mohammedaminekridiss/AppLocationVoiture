using AppLocationVoiture.DAL;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AppLocationVoiture.BLL
{
    public class OptionsService
    {
        public static readonly OptionsService Instance = new OptionsService();

        public List<Options> GetAllOptions()
        {
            List<Options> options = new List<Options>();
            using (var db = new LocationDBEntities())
            {
                 options = db.Options.ToList();
            }
            return options;
        }

        public void AddOption(Options option)
        {
            using (var db = new LocationDBEntities())
            {
                db.Options.Add(option);
                db.SaveChanges();
            }
        }

        public void DeleteOption(int optionId)
        {
            using (var db = new LocationDBEntities())
            {
                var option = db.Options.FirstOrDefault(o => o.IdOption == optionId);
                if (option != null)
                {
                    db.Options.Remove(option);
                    db.SaveChanges();
                }
            }
        }

        public void UpdateOption(Options _option)
        {
            using (var db = new LocationDBEntities())
            {
                var option = db.Options.FirstOrDefault(o => o.IdOption == _option.IdOption);
                option.PrixTTC = _option.PrixTTC;
                option.Description = _option.Description;
                option.Libelle = _option.Libelle;
                db.SaveChanges();
            }
        }
    }
}
