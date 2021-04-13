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
    
    public partial class PACIENTES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PACIENTES()
        {
            this.HISTORIAS_CLINICAS = new HashSet<HISTORIAS_CLINICAS>();
        }
    
        public int id_paciente { get; set; }
        public string nom_paciente { get; set; }
        public string apellido { get; set; }
        public Nullable<int> tipo_doc { get; set; }
        public Nullable<long> nro_doc { get; set; }
        public string calle { get; set; }
        public Nullable<int> nro_dom { get; set; }
        public string email { get; set; }
        public Nullable<long> telefono { get; set; }
        public Nullable<int> id_barrio { get; set; }
        public Nullable<int> id_obra_social { get; set; }
        public Nullable<int> id_genero { get; set; }
    
        public virtual BARRIOS BARRIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORIAS_CLINICAS> HISTORIAS_CLINICAS { get; set; }
        public virtual OBRAS_SOCIALES OBRAS_SOCIALES { get; set; }
        public virtual TIPOS_DOC TIPOS_DOC { get; set; }
        public virtual GENEROS GENEROS { get; set; }

      public override string ToString()
      {
         return $"Id: {id_paciente}\n" +
            $"Nombre: {nom_paciente}\n" +
            $"Apellido: {apellido}\n" +
            $"TipoDoc: {TIPOS_DOC.desc_tipo_doc}\n" +
            $"NroDoc: {nro_doc}\n" +
            $"Genero: {GENEROS.desc_genero}\n" +
            $"ObraSocial: {OBRAS_SOCIALES.nombre}\n" +
            $"Calle: {calle}\n" +
            $"NroCalle: {nro_dom}\n" +
            $"Barrio: {BARRIOS.ToString()}\n" +
            $"Telefono: {telefono}\n" +
            $"Email: {email}";
      }

   }
}
