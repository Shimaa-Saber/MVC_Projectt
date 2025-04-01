using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class UserRepository:IUserRepository
    {
        ITIContext _context;
        public UserRepository(ITIContext context)
        {
            _context = context;
        }

        public void Delete(User obj)
        {
            _context.Remove(obj);
        }

        public List<User> GetAll()
        {
            return _context.users.ToList();
        }

        public User GetById(int id)
        {
           return _context.users.Where(u => u.Id == id).FirstOrDefault();
        }

        public void insert(User obj)
        {
            _context.users.Add(obj);
        }

        public void Update(User obj)
        {
            _context.users.Update(obj);
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
