//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KisKer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AruKategoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AruKategoria()
        {
            this.AruKeszletek = new HashSet<AruKeszlet>();
        }
    
        public int AruKategoriaID { get; set; }
        public string AruKategoriaMegnevezes { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AruKeszlet> AruKeszletek { get; set; }
    }
}
