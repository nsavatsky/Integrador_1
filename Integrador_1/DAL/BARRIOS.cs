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
    
    public partial class BARRIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BARRIOS()
        {
            this.EMPLEADOS = new HashSet<EMPLEADOS>();
            this.PACIENTES = new HashSet<PACIENTES>();
        }
    
        public int id_barrio { get; set; }
        public string nom_barrio { get; set; }
        public Nullable<int> id_localidad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADOS> EMPLEADOS { get; set; }
        public virtual LOCALIDADES LOCALIDADES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PACIENTES> PACIENTES { get; set; }

      public override string ToString()
      {
         return $"{nom_barrio}, {LOCALIDADES.nom_localidad}, {LOCALIDADES.PROVINCIAS.nom_provincia}";
      }
   }
}
