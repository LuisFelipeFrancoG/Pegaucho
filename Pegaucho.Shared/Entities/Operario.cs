using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegaucho.Shared.Entities
{
    public class Operario
    {
        public string Id { get; set; }

        [Display(Name = "Turno")]
        [Required]
        [MaxLength(10)]
        public string turno { get; set; }

        [Display(Name = "Habilidades")]
        [Required]
        [MaxLength(200)]
        public string habilidades { get; set; }
    }
}
