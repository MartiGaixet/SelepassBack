using SelepassBack.Models;

namespace SelepassBack.Services
{
    public interface IApuntesService
    {
        Apuntes GetApuntes(int id);
        List<Apuntes> GetAllApuntes();
        void CreateApuntes(Apuntes apuntes);
        void UpdateApuntes(Apuntes apuntes);
        void DeleteApuntes(int id);
    }
}
