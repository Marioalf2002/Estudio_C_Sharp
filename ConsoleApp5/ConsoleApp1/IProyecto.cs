public interface IProyecto
{
    void AgregarTarea(ITarea tarea);
    int CalcularPrioridadTotal();
    List<ITarea> ObtenerTareas();
}