using SelepassBack.Models;
using SelepassBack.Repositories;

namespace SelepassBack.Services
{
    public class AsignaturaService : IAsignaturaService
    {
        private readonly AsignaturaRepository _asignaturaRepository;

        public AsignaturaService(AsignaturaRepository asignaturaRepository)
        {
            _asignaturaRepository = asignaturaRepository;
        }

        // Obtener asignatura por Id
        public Asignatura GetById(int id)
        {
            return _asignaturaRepository.GetById(id);
        }

        // Obtener todas las asignaturas
        public List<Asignatura> GetAll()
        {
            return _asignaturaRepository.GetAll();
        }

        // Agregar una nueva asignatura
        public void Add(Asignatura asignatura)
        {
            _asignaturaRepository.Add(asignatura);
        }

        // Actualizar una asignatura existente
        public void Update(Asignatura asignatura)
        {
            _asignaturaRepository.Update(asignatura);
        }

        // Eliminar asignatura por Id
        public void Delete(int id)
        {
            _asignaturaRepository.Delete(id);
        }
    }
}
