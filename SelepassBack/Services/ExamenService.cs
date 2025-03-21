using SelepassBack.Models;
using SelepassBack.Repositories;

namespace SelepassBack.Services
{
    public class ExamenService : IExamenService
    {
        private readonly IExamenRepository _examenRepository;

        public ExamenService(IExamenRepository examenRepository) => _examenRepository = examenRepository;

        public Examen GetExamen(int id) => _examenRepository.GetById(id);

        public List<Examen> GetAllExamenes() => _examenRepository.GetAll();

        public void CreateExamen(Examen examen) => _examenRepository.Add(examen);

        public void UpdateExamen(Examen examen) => _examenRepository.Update(examen);

        public void DeleteExamen(int id) => _examenRepository.Delete(id);
    }
}
