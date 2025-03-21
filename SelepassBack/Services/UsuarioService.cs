using SelepassBack.Models;
using SelepassBack.Repositories;

namespace SelepassBack.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository) => _usuarioRepository = usuarioRepository;

        public Usuario GetUsuario(int id) => _usuarioRepository.GetById(id);

        public List<Usuario> GetAllUsuarios() => _usuarioRepository.GetAll();

        public void CreateUsuario(Usuario usuario) => _usuarioRepository.Add(usuario);

        public void UpdateUsuario(Usuario usuario) => _usuarioRepository.Update(usuario);

        public void DeleteUsuario(int id) => _usuarioRepository.Delete(id);
    }
}
