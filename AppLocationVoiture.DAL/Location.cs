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
    
    public partial class Location
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Location()
        {
            this.Paiement = new HashSet<Paiement>();
        }
    
        public int IdLocation { get; set; }
        public int IdVoiture { get; set; }
        public int IdClient { get; set; }
        public Nullable<int> IdOption { get; set; }
        public System.DateTime DateHeureDebut { get; set; }
        public System.DateTime DateHeureRestitution { get; set; }
        public int IdAgenceRestitution { get; set; }
        public Nullable<decimal> TotalTtc { get; set; }
        public Nullable<int> IdPromotion { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Options Options { get; set; }
        public virtual Promotion Promotion { get; set; }
        public virtual Voiture Voiture { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paiement> Paiement { get; set; }
    }
}
