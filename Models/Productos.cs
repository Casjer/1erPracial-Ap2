using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _1erParcial.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage =("es obligatorio introducir una descripcion"))]
        public string Descripcion { get; set; }
        public int Existencia { get; set; }

        [Range(minimum:10, maximum:1000000)]
        public double Costo { get; set; }
        public double Inventaria { get; set; }
    }
}
