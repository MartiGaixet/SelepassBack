using SelepassBack.Models;

namespace SelepassBack.Services
{
    public interface IUsuarioService
    {
        Usuario GetUsuario(int id);
        List<Usuario> GetAllUsuarios();
        void CreateUsuario(Usuario usuario);
        void UpdateUsuario(Usuario usuario);
        void DeleteUsuario(int id);
    }
}
