using SelepassBack.Models;

namespace SelepassBack.Repositories
{
    public interface IAvisoRepository
    {
        Aviso GetById(int id);
        List<Aviso> GetAll();
        void Add(Aviso aviso);
        void Update(Aviso aviso);
        void Delete(int id);
    }
}
