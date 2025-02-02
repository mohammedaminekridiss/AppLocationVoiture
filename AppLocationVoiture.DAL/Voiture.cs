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
    
    public partial class Voiture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Voiture()
        {
            this.AgenceRestitution = new HashSet<AgenceRestitution>();
            this.Location = new HashSet<Location>();
            this.Tarif = new HashSet<Tarif>();
            this.Assurance = new HashSet<Assurance>();
            this.Options = new HashSet<Options>();
        }
    
        public int IdVoiture { get; set; }
        public int IdCategorie { get; set; }
        public int IdAgence { get; set; }
        public string NomCommercial { get; set; }
        public Nullable<int> NombrePlaces { get; set; }
        public Nullable<int> NombrePortes { get; set; }
        public string BoiteVitesse { get; set; }
        public Nullable<int> Autonomie { get; set; }
        public Nullable<int> CapaciteCoffre { get; set; }
        public string Carburant { get; set; }
        public Nullable<int> NombreChevaux { get; set; }
        public Nullable<int> KilometrageParDefaut { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DateSortie { get; set; }
        public Nullable<System.DateTime> DateCreation { get; set; }
        public Nullable<System.DateTime> DateModification { get; set; }
        public Nullable<bool> Active { get; set; }
        public string ImageURL { get; set; }
    
        public virtual Agence Agence { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgenceRestitution> AgenceRestitution { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Location> Location { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tarif> Tarif { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assurance> Assurance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Options> Options { get; set; }
    }
}
