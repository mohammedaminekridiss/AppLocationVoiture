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
    
    public partial class Assurance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Assurance()
        {
            this.Voiture = new HashSet<Voiture>();
        }
    
        public int IdAssurance { get; set; }
        public string Libelle { get; set; }
        public Nullable<decimal> Franchise { get; set; }
        public Nullable<decimal> PrixTtc { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> DepotGarantie { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Voiture> Voiture { get; set; }
    }
}
