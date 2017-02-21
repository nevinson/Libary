using Nevinson.Libary.Data.Models;
using System.Collections.Generic;

namespace Nevinson.Libary.Data
{
    public interface ILibraryCard
    {
        IEnumerable<LibraryCard> GetAll();
        LibraryCard Get(int id);
        void Add(LibraryCard newCard);
    }
}
