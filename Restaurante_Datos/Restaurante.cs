//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurante_Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Restaurante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Restaurante()
        {
            this.Ubicaciones = new HashSet<Ubicacione>();
        }
    
        public int Id_Restaurante { get; set; }
        public string Nombre { get; set; }
        public int Id_Categorias { get; set; }
        public Nullable<int> Id_Menu { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Menu Menu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ubicacione> Ubicaciones { get; set; }
    }
}
