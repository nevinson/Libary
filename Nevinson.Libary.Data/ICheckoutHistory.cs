using Nevinson.Libary.Data.Models;
using System.Collections.Generic;

namespace Nevinson.Libary.Data
{
    public interface ICheckoutHistory
    {
        IEnumerable<CheckoutHistory> GetAll();
        IEnumerable<CheckoutHistory> GetForAsset(LibraryAsset asset);
        IEnumerable<CheckoutHistory> GetForCard(LibraryCard card);
        CheckoutHistory Get(int id);
        void Add(CheckoutHistory newCheckoutHistory);
    }
}
