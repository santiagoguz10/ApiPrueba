using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPrueba.Entities
{
    public class Casa
    {
        [Key]
        public int Id { get; set; }
        public string Nombre_Casa { get; set; }
    }
}
