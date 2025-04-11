using SelepassBack.Models;

namespace SelepassBack.Repositories
{
    public class AsignaturaRepository : IAsignaturaRepository
    {
        private readonly Context _context;

        public AsignaturaRepository(Context context)
        {
            _context = context;
        }

        // Obtener asignatura por Id
        public Asignatura GetById(int id)
        {
            return _context.Asignaturas.Find(id);
        }

        // Obtener todas las asignaturas
        public List<Asignatura> GetAll()
        {
            return _context.Asignaturas.ToList();
        }

        // Agregar una nueva asignatura
        public void Add(Asignatura asignatura)
        {
            _context.Asignaturas.Add(asignatura);
            _context.SaveChanges();
        }

        // Actualizar una asignatura existente
        public void Update(Asignatura asignatura)
        {
            _context.Asignaturas.Update(asignatura);
            _context.SaveChanges();
        }

        // Eliminar asignatura por Id
        public void Delete(int id)
        {
            var asignatura = _context.Asignaturas.Find(id);
            if (asignatura != null)
            {
                _context.Asignaturas.Remove(asignatura);
                _context.SaveChanges();
            }
        }
    }
}

