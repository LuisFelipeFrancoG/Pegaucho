using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegaucho.Shared.Entities
{
    public class TareaEjecucion
    {
        public string Id { get; set; }

        [Display(Name = "Inicio")]
        [Required]
        public DateTime inicio { get; set; }

        [Display(Name = "Fin")]
        [Required]
        public DateTime fin { get; set; }

        [Display(Name = "Cantidad Producida")]
        [Required]
        [MaxLength(10)]
        public int cantidadProducida { get; set; }

        [Display(Name = "Descripcion")]
        [Required]
        [MaxLength(200)]
        public string descripcion { get; set; }

        [Display(Name = "Estado de la Tarea")]
        [Required]
        [MaxLength(200)]
        public EstadoTarea estado { get; set; }
    }
}
