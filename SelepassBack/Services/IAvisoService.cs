using SelepassBack.Models;

namespace SelepassBack.Services
{
    public interface IAvisoService
    {
        Aviso GetAviso(int id);
        List<Aviso> GetAllAvisos();
        void CreateAviso(Aviso aviso);
        void UpdateAviso(Aviso aviso);
        void DeleteAviso(int id);
    }

}
