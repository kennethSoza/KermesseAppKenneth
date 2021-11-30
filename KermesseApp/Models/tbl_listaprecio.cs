//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KermesseApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;


    public partial class tbl_listaprecio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_listaprecio()
        {
            this.tbl_listaprecio_det = new HashSet<tbl_listaprecio_det>();
        }

        public int id_listaprecio { get; set; }
        [Display(Name = "Kermesse")]
        [Required(ErrorMessage = "Seleccione una kermesse valida")]
        public int id_kermesse { get; set; }
        [Display(Name = "Nombre de la lista de precio")]
        [Required(ErrorMessage = "Digite un nombre para la lista de precio")]
        [StringLength(100, ErrorMessage = "El límite de caracteres es de 100")]
        public string nombre { get; set; }
        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Digite una descripcion para la lista de precio")]
        [StringLength(200, ErrorMessage = "El límite de caracteres es de 200")]
        public string descripcion { get; set; }
        public int estado { get; set; }
        public tbl_listaprecio_det detalle { get; set; }
        public List<tbl_listaprecio_det> listaprecio_Dets { get; set; }
        public virtual tbl_kermesse tbl_kermesse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_listaprecio_det> tbl_listaprecio_det { get; set; }
    }
}
