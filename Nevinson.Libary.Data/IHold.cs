using Nevinson.Libary.Data.Models;
using System.Collections.Generic;

namespace Nevinson.Libary.Data
{
    public interface IHold
    {
        IEnumerable<AssetType> GetAll();
        AssetType Get(int id);
        void Add(AssetType newType);
    }
}
