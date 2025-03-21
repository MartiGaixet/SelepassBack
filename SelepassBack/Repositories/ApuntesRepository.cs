using SelepassBack.Models;

namespace SelepassBack.Repositories
{
    public class ApuntesRepository : IApuntesRepository
    {
        private readonly Context _context;

        public ApuntesRepository(Context context) => _context = context;

        public Apuntes GetById(int id) => _context.Apuntes.Find(id);

        public List<Apuntes> GetAll() => _context.Apuntes.ToList();

        public void Add(Apuntes apuntes)
        {
            _context.Apuntes.Add(apuntes);
            _context.SaveChanges();
        }

        public void Update(Apuntes apuntes)
        {
            _context.Apuntes.Update(apuntes);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var apuntes = _context.Apuntes.Find(id);
            if (apuntes != null)
            {
                _context.Apuntes.Remove(apuntes);
                _context.SaveChanges();
            }
        }
    }
}
