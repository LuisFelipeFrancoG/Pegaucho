using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegaucho.Shared.Entities
{
    public class Incidente
    {
        public string Id { get; set; }

        [Display(Name = "Descripcion")]
        [Required]
        [MaxLength(200)]
        public string descripcion { get; set; }

        [Display(Name = "Fecha")]
        [Required]
        public DateTime fecha { get; set; }

        [Display(Name = "Severidad")]
        [Required]
        [MaxLength(20)]
        public DateTime severidad { get; set; }
    }
}
