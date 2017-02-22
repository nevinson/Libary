using Nevinson.Libary.Data.Models;
using System.Collections.Generic;

namespace Nevinson.Libary.Data
{
    public interface IStatus
    {
        IEnumerable<Status> GetAll();
        Status Get(int id);
        void Add(Status newStatus);
    }
}
