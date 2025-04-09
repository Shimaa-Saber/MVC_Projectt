using Microsoft.EntityFrameworkCore;
using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class AtelierRepository : IAtelierRepository
    {
        MVCProjectContext _context;
        public AtelierRepository(MVCProjectContext context)
        {
            _context = context;
        }

        public void Delete(Atelier obj)
        {
            _context.Ateliers.Remove(obj);
        }

        public List<Atelier> GetAll()
        {
            return _context.Ateliers.ToList();
        }

        public Atelier GetById(int id)
        {
            return _context.Ateliers.Where(a => a.Id == id).FirstOrDefault();
        }

        public IEnumerable<Atelier> SearchByName(string name)
        {
            return _context.Ateliers

                .Where(s => s.Name.Contains(name))
                .AsNoTracking()
                .ToList();
        }

        public void insert(Atelier obj)
        {
            _context.Ateliers.Add(obj);
        }

        public void Update(Atelier obj)
        {
            _context.Ateliers.Update(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
