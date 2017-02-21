using Nevinson.Libary.Data;
using Nevinson.Libary.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Nevinson.Libary.Service
{
    public class LibraryCardService : ILibraryCard
    {
        private LibraryDbContext _context; // private field to store the context.

        public LibraryCardService(LibraryDbContext context)
        {
            _context = context;
        }

        public void Add(LibraryCard newLibraryCard)
        {
            _context.Add(newLibraryCard);
            _context.SaveChanges();
        }

        public LibraryCard Get(int cardId)
        {
            return _context.LibraryCards.FirstOrDefault(p => p.Id == cardId);
        }

        IEnumerable<LibraryCard> ILibraryCard.GetAll()
        {
            return _context.LibraryCards;
        }
    }
}
