using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class CommentRepository : ICommentRepository
    {
        ITIContext _context;
        public CommentRepository(ITIContext context)
        {
            _context = context;
        }

        public void Delete(Comment obj)
        {
            _context.comments.Remove(obj);
        }

        public List<Comment> GetAll()
        {
            return _context.comments.ToList();
        }

        public Comment GetById(int id)
        {
            return _context.comments.Where(c => c.Id == id).FirstOrDefault();
        }

        public void insert(Comment obj)
        {
            _context.comments.Add(obj);
        }

        public void Update(Comment obj)
        {
            _context.comments.Update(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
