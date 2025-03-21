using SelepassBack.Models;

namespace SelepassBack.Repositories
{
    public class ExamenRepository : IExamenRepository
    {
        private readonly Context _context;

        public ExamenRepository(Context context) => _context = context;

        public Examen GetById(int id) => _context.Examenes.Find(id);

        public List<Examen> GetAll() => _context.Examenes.ToList();

        public void Add(Examen examen)
        {
            _context.Examenes.Add(examen);
            _context.SaveChanges();
        }

        public void Update(Examen examen)
        {
            _context.Examenes.Update(examen);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var examen = _context.Examenes.Find(id);
            if (examen != null)
            {
                _context.Examenes.Remove(examen);
                _context.SaveChanges();
            }
        }
    }
}
