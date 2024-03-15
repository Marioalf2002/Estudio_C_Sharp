using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_h1
{
    public class Producto
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string cantidad { get; set; }
        public string precio { get; set; }

        public Producto(string _codigo, string _nombre, string _cantidad, string _precio) 
        {
            codigo = _codigo;
            nombre = _nombre;
            cantidad = _cantidad;
            this.precio = _precio;
        }
    }
}
