using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ListaDeTareas
    {
        private List<IProyecto> lista = new List<IProyecto>();

        public void AgregarProyecto(IProyecto proyecto)
        {
            lista.Add(proyecto);
        }

        public int CalcularPrioridadTotalDeTodasLasTareas()
        {
            int prioridadTotal = 0;
            foreach (var proyecto in lista)
            {
                prioridadTotal += proyecto.CalcularPrioridadTotal();
            }
            return prioridadTotal;
        }

        public IEnumerable<IProyecto> ObtenerProyectos()
        {
            return lista;
        }

        public override string ToString()
        {
            return $"Prioridad total de todas las tareas en todos los proyectos: {CalcularPrioridadTotalDeTodasLasTareas()}";
        }
    }
}
