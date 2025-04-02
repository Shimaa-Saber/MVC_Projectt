using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class UserRepository:IUserRepository
    {
        MVCProjectContext _context;
        public UserRepository(MVCProjectContext context)
        {
            _context = context;
        }

        public void Delete(User obj)
        {
            _context.Remove(obj);
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
           return _context.Users.Where(u => u.Id == id).FirstOrDefault();
        }

        public void insert(User obj)
        {
            _context.Users.Add(obj);
        }

        public void Update(User obj)
        {
            _context.Users.Update(obj);
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
