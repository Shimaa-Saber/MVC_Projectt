using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class MakeUpRepository : IMakeUpRepository
    {
        ITIContext _context;
        public MakeUpRepository(ITIContext context)
        {
            _context = context;
        }

        public void Delete(MakeUp_Service obj)
        {
            _context.makeUp_s.Remove(obj);
        }

        public List<MakeUp_Service> GetAll()
        {
            return _context.makeUp_s.ToList();
        }

        public MakeUp_Service GetById(int id)
        {
            return _context.makeUp_s.Where(m => m.Id == id).FirstOrDefault();
        }

        public void insert(MakeUp_Service obj)
        {
            _context.makeUp_s.Add(obj);
        }

        public void Update(MakeUp_Service obj)
        {
            _context.makeUp_s.Update(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
