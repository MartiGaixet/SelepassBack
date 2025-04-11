using SelepassBack.Models;

namespace SelepassBack.Services
{
    public interface IAsignaturaService
    {
        Asignatura GetById(int id);

        // Obtener todas las asignaturas
        List<Asignatura> GetAll();

        // Agregar una nueva asignatura
        void Add(Asignatura asignatura);

        // Actualizar una asignatura existente
        void Update(Asignatura asignatura);

        // Eliminar asignatura por Id
        void Delete(int id);
    }
}
