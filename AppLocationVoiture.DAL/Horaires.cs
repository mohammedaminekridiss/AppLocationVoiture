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
    
    public partial class Horaires
    {
        public int IdAgence { get; set; }
        public string Jour { get; set; }
        public System.TimeSpan HeureOuverture { get; set; }
        public System.TimeSpan HeureFermeture { get; set; }
    
        public virtual Agence Agence { get; set; }
    }
}
