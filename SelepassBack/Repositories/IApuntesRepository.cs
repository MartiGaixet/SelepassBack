using SelepassBack.Models;

namespace SelepassBack.Repositories
{
    public interface IApuntesRepository
    {
        Apuntes GetById(int id);
        List<Apuntes> GetAll();
        void Add(Apuntes apuntes);
        void Update(Apuntes apuntes);
        void Delete(int id);
    }
}
