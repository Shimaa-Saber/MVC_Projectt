using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class HallRepository : IHallRepository
    {
        ITIContext _context;
        public HallRepository(ITIContext context)
        {
            _context = context;
        }

        public void Delete(Hall obj)
        {
            _context.halls.Remove(obj);
        }

        public List<Hall> GetAll()
        {
           return _context.halls.ToList();
        }

        public Hall GetById(int id)
        {
            return _context.halls.Where(h => h.Id == id).FirstOrDefault();
        }

        public void insert(Hall obj)
        {
            _context.halls.Add(obj);
        }

        public void Update(Hall obj)
        {
            _context.halls.Update(obj);
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
