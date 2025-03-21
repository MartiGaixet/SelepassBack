using SelepassBack.Models;
using SelepassBack.Repositories;

namespace SelepassBack.Services
{
    public class AvisoService : IAvisoService
    {
        private readonly IAvisoRepository _avisoRepository;

        public AvisoService(IAvisoRepository avisoRepository) => _avisoRepository = avisoRepository;

        public Aviso GetAviso(int id) => _avisoRepository.GetById(id);

        public List<Aviso> GetAllAvisos() => _avisoRepository.GetAll();

        public void CreateAviso(Aviso aviso) => _avisoRepository.Add(aviso);

        public void UpdateAviso(Aviso aviso) => _avisoRepository.Update(aviso);

        public void DeleteAviso(int id) => _avisoRepository.Delete(id);
    }

}
