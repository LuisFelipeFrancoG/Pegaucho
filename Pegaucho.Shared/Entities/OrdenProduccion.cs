using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegaucho.Shared.Entities
{
    public class OrdenProduccion
    {
        public string Id { get; set; }

        [Display(Name = "Número Orden")]
        [Required]
        [MaxLength(10)]
        public int numeroOrden { get; set; }

        [Display(Name = "Fecha de Ingreso")]
        [Required]
        public DateTime fechaIngreso { get; set; }

        [Display(Name = "Fecha Programada")]
        [Required]
        public DateTime fechaProgramada { get; set; }

        [Display(Name = "Estado de Orden")]
        [Required]
        public EstadoOrden estado { get; set; }

        [Display(Name = "Cantidad Programada")]
        [Required]
        [MaxLength(10)]
        public int cantidadProgramada { get; set; }

        [Display(Name = "Tiempo Estimado en Minutos")]
        [Required]
        [MaxLength(10)]
        public int tiempoEstimadoMin    { get; set; }

        [Display(Name = "Maquinaria")]
        [Required]
        [MaxLength(30)]
        public  string maquinaria { get; set; }

        [Display(Name = "Creado por")]
        [Required]
        [MaxLength(10)]
        public int creadoPor { get; set; }


    }
}
