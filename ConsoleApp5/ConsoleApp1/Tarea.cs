using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Tarea : ITarea
    {
        string descripcion = string.Empty;
        int prioridad = 0;

        public Tarea(string descripcion, int prioridad)
        {
            this.Descripcion = descripcion;
            this.Prioridad = prioridad;
        }

        public Tarea() { }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Prioridad { get => prioridad; set => prioridad = value; }

        public string ObtenerDescripcion()
        {
            return Descripcion;
        }

        public int ObtenerPrioridad()
        {
            return Prioridad;
        }
    }
}
