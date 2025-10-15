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
        public int Id  { get; set; }

        [Display(Name = "Nombre del Producto")]
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Display(Name = "Descripcion del Producto")]
        [Required]
        [MaxLength(200)]
        public string Descripcion { get; set; }

        [Display(Name = "Unidad de Medida del Producto")]
        [Required]
        [MaxLength(20)]
        public string UnidadMedida { get; set; }

        [Display(Name = "Costo Unitario del Producto")]
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "El costo unitario debe ser un número positivo.")]
        public double CostoUnitario { get; set; }

}
}
