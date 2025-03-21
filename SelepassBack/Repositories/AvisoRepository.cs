using SelepassBack.Models;

namespace SelepassBack.Repositories
{
    public class AvisoRepository : IAvisoRepository
    {
        private readonly Context _context;

        public AvisoRepository(Context context) => _context = context;

        public Aviso GetById(int id) => _context.Avisos.Find(id);

        public List<Aviso> GetAll() => _context.Avisos.ToList();

        public void Add(Aviso aviso)
        {
            _context.Avisos.Add(aviso);
            _context.SaveChanges();
        }

        public void Update(Aviso aviso)
        {
            _context.Avisos.Update(aviso);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var aviso = _context.Avisos.Find(id);
            if (aviso != null)
            {
                _context.Avisos.Remove(aviso);


            }
