using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPrueba.Entities
{
    public class Solicitud_Ingreso
    {
        [Key]
        public int Id { get; set; }

        [RegularExpression("([AaBbOo]|[Aa] [Bb])", ErrorMessage = "Solo se permiten letras")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El nombre es obligatorio")]
        [StringLength(20, ErrorMessage = "El nombre es demasiado largo")]
        public string Nombre { get; set; }

        [RegularExpression("([AaBbOo]|[Aa] [Bb])", ErrorMessage = "Solo se permiten lwtras")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El apellido es obligatorio")]
        [StringLength(20, ErrorMessage = "El apellido es demasiado largo")]
        public string Apellido { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número es obligatorio")]
        [StringLength(10, ErrorMessage = "El número es demasiado largo")]
        public string Identificacion { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número es obligatorio")]
        [StringLength(2, ErrorMessage = "El número es demasiado largo")]
        public string Edad { get; set; }

        [Required]
        public int Id_Casa { get; set; }

    }
}
