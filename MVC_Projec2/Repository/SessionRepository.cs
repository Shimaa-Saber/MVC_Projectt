﻿using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class SessionRepository:ISessionRepository
    {
        ITIContext _context;
        public SessionRepository(ITIContext context)
        {
            _context = context;
        }

        public void Delete(Session obj)
        {
            _context.sessions.Remove(obj);
        }

        public List<Session> GetAll()
        {
            return _context.sessions.ToList();
        }

        public Session GetById(int id)
        {
            return _context.sessions.Where(s => s.Id == id).FirstOrDefault();
        }

        public void insert(Session obj)
        {
            _context.sessions.Add(obj);
        }

        public void Update(Session obj)
        {
            _context.sessions.Update(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
