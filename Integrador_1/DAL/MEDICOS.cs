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
    
    public partial class MEDICOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEDICOS()
        {
            this.PROCEDIMIENTOS = new HashSet<PROCEDIMIENTOS>();
        }
    
        public int id_medico { get; set; }
        public Nullable<int> id_especialidad { get; set; }
        public Nullable<long> matricula { get; set; }
        public Nullable<int> id_usuario { get; set; }
    
        public virtual ESPECIALIDADES ESPECIALIDADES { get; set; }
        public virtual USUARIOS USUARIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROCEDIMIENTOS> PROCEDIMIENTOS { get; set; }
    }
}
