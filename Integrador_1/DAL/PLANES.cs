//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Integrador_1.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PLANES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PLANES()
        {
            this.PLANES_OBRA_SOCIAL = new HashSet<PLANES_OBRA_SOCIAL>();
        }
    
        public int id_plan { get; set; }
        public string nom_plan { get; set; }
        public Nullable<bool> req_coseg { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLANES_OBRA_SOCIAL> PLANES_OBRA_SOCIAL { get; set; }
    }
}