using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class DecorRepository : IDecorRepository
    {
        ITIContext _context;
        public DecorRepository(ITIContext context)
        {
            _context = context;
        }

        public void Delete(Decor obj)
        {
            _context.decors.Remove(obj);
        }

        public List<Decor> GetAll()
        {
            return _context.decors.ToList();
        }

        public Decor GetById(int id)
        {
            return _context.decors.Where(d => d.Id == id).FirstOrDefault();
        }

        public void insert(Decor obj)
        {
            _context.decors.Add(obj);
        }

        public void Update(Decor obj)
        {
            _context.decors.Update(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
