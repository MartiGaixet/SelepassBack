using SelepassBack.Models;

namespace SelepassBack.Services
{
    public interface IExamenService
    {
        Examen GetExamen(int id);
        List<Examen> GetAllExamenes();
        void CreateExamen(Examen examen);
        void UpdateExamen(Examen examen);
        void DeleteExamen(int id);
    }
}
