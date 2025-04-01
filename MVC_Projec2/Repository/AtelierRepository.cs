using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class AtelierRepository : IAtelierRepository
    {
        ITIContext _context;
        public AtelierRepository(ITIContext context)
        {
            _context = context;
        }

        public void Delete(Atelier obj)
        {
            _context.ateliers.Remove(obj);
        }

        public List<Atelier> GetAll()
        {
            return _context.ateliers.ToList();
        }

        public Atelier GetById(int id)
        {
            return _context.ateliers.Where(a => a.Id == id).FirstOrDefault();
        }

        public void insert(Atelier obj)
        {
            _context.ateliers.Add(obj);
        }

        public void Update(Atelier obj)
        {
            _context.ateliers.Update(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
