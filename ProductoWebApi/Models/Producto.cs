using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductoWebApi.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Ubicacion { get; set; }
        public decimal Precio { get; set; }
        public decimal Stock { get; set; }
    }
}
