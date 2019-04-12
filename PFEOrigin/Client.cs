//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PFEOrigin
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.DocumentsClients = new HashSet<DocumentsClient>();
            this.RendezVous = new HashSet<RendezVou>();
        }
    
        public int id { get; set; }
        public string CIN { get; set; }
        public string nomCli { get; set; }
        public string prenom { get; set; }
        public Nullable<System.DateTime> DateNaissance { get; set; }
        public string addressCli { get; set; }
        public Nullable<int> Tel { get; set; }
        public string sex { get; set; }
        public string Assurer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentsClient> DocumentsClients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RendezVou> RendezVous { get; set; }
    }
}
