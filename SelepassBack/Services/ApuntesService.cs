using SelepassBack.Models;
using SelepassBack.Repositories;

namespace SelepassBack.Services
{
    public class ApuntesService : IApuntesService
    {
        private readonly IApuntesRepository _apuntesRepository;

        public ApuntesService(IApuntesRepository apuntesRepository) => _apuntesRepository = apuntesRepository;

        public Apuntes GetApuntes(int id) => _apuntesRepository.GetById(id);

        public List<Apuntes> GetAllApuntes() => _apuntesRepository.GetAll();

        public void CreateApuntes(Apuntes apuntes) => _apuntesRepository.Add(apuntes);

        public void UpdateApuntes(Apuntes apuntes) => _apuntesRepository.Update(apuntes);

        public void DeleteApuntes(int id) => _apuntesRepository.Delete(id);
    }
}
