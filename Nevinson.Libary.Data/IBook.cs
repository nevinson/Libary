using Nevinson.Libary.Data.Models;
using System.Collections.Generic;

namespace Nevinson.Libary.Data
{
    public interface IBook
    {
        IEnumerable<Book> GetAll();
        IEnumerable<Book> GetByAuthor(string author);
        IEnumerable<Book> GetByISBN(string isbn);
        Book Get(int id);
        void Add(Book newBook);
    }
}
