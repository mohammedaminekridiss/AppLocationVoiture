//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppLocationVoiture.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tarif
    {
        public int IdTarif { get; set; }
        public int IdVoiture { get; set; }
        public string JourSemaine { get; set; }
        public Nullable<int> Semaine { get; set; }
        public Nullable<decimal> TarifTtc { get; set; }
    
        public virtual Voiture Voiture { get; set; }
    }
}
