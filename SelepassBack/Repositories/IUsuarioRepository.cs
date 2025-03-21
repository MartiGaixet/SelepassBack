using SelepassBack.Models;

namespace SelepassBack.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario GetById(int id);
        List<Usuario> GetAll();
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int id);
    }
}
