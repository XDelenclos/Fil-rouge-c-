//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fournisseur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fournisseur()
        {
            this.Vend = new HashSet<Vend>();
        }
    
        public int ID_Fournisseur { get; set; }
        public string Nom_Fournisseur { get; set; }
        public string Nom_Contact_Fournisseur { get; set; }
        public string Adresse_Fournisseur { get; set; }
        public string Code_Postal_Forunisseur { get; set; }
        public string Ville_Forunisseur { get; set; }
        public string No_Telephone_Fournisseur { get; set; }
        public string No_Fax_Fournisseur { get; set; }
        public string Mail_Fournisseur { get; set; }
        public Nullable<bool> Importateur { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vend> Vend { get; set; }
    }
}
