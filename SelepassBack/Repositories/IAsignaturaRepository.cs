using SelepassBack.Models;

namespace SelepassBack.Repositories
{
    public interface IAsignaturaRepository
    {
        Asignatura GetById(int id);
        List<Asignatura> GetAll();
        void Add(Asignatura asignatura);
        void Update(Asignatura asignatura);
        void Delete(int id);
    }
}
