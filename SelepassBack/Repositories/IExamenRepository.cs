using SelepassBack.Models;

namespace SelepassBack.Repositories
{
    public interface IExamenRepository
    {
        Examen GetById(int id);
        List<Examen> GetAll();
        void Add(Examen examen);
        void Update(Examen examen);
        void Delete(int id);
    }
}
