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
    
    public partial class HISTORIAS_CLINICAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HISTORIAS_CLINICAS()
        {
            this.PROCEDIMIENTOS = new HashSet<PROCEDIMIENTOS>();
        }
    
        public int id_historia_clinica { get; set; }
        public Nullable<int> id_paciente { get; set; }
        public Nullable<System.DateTime> fecha_ingreso { get; set; }
    
        public virtual PACIENTES PACIENTES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROCEDIMIENTOS> PROCEDIMIENTOS { get; set; }
    }
}