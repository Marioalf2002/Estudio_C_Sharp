using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Proyecto : IProyecto
    {
        List<ITarea> lista = new List<ITarea>();

        public List<ITarea> Lista { get => lista; set => lista = value; }

        public void AgregarTarea(ITarea tarea)
        {
            Lista.Add(tarea);
        }

        public int CalcularPrioridadTotal()
        {

            int prioridadTotal = 0;
            foreach (var tarea in Lista)
            {
                prioridadTotal += tarea.ObtenerPrioridad();
            }
            return prioridadTotal;
        }

        public List<ITarea> ObtenerTareas() // Implementamos el método de la interfaz
        {
            return Lista;
        }
    }
}
