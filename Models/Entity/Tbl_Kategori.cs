//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AracSatis.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Kategori
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Kategori()
        {
            this.Tbl_Arac = new HashSet<Tbl_Arac>();
        }
    
        public int KategoriID { get; set; }
        public string KategoriAD { get; set; }
        public string KategoriIMG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Arac> Tbl_Arac { get; set; }
    }
}
