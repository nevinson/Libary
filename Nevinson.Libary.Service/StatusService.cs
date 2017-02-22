using Nevinson.Libary.Data;
using Nevinson.Libary.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Nevinson.Libary.Service
{
    public class StatusService : IStatus
    {
        private LibraryDbContext _context; // private field to store the context.

        public StatusService(LibraryDbContext context)
        {
            _context = context;
        }

        public void Add(Status newStatus)
        {
            _context.Add(newStatus);
            _context.SaveChanges();
        }

        public Status Get(int id)
        {
            return _context.Statuses.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Status> GetAll()
        {
            return _context.Statuses;
        }
    }
}
