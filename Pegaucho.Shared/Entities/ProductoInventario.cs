using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegaucho.Shared.Entities
{
    public class ProductoInventario
    {
        private int Id  { get; set; }

        [Display(Name = "Nombre del Producto")]
        [Required]
        [MaxLength(50)]
        private string Nombre { get; set; }

        [Display(Name = "Descripcion del Producto")]
        [Required]
        [MaxLength(200)]
        private string Descripcion { get; set; }

        [Display(Name = "Unidad de Medida del Producto")]
        [Required]
        [MaxLength(20)]
        private string UnidadMedida { get; set; }

        [Display(Name = "Costo Unitario del Producto")]
        [Required]
        [MaxLength(100)]
        private double CostoUnitario { get; set; }

}
}
