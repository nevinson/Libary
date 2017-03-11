using Nevinson.Libary.Data.Models;
using System;

namespace Nevinson.Libary.Models.Catalog
{
    public class AssetCheckinModel
    {
        public LibraryCard LibraryCard { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime DateCheckedOut { get; set; }
        public decimal FeesCharged { get; set; }
        public int DaysOverDue { get; set; }
    }
}
