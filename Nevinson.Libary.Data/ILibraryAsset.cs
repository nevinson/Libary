﻿using Nevinson.Libary.Data.Models;
using System.Collections.Generic;

namespace Nevinson.Libary.Data
{
    public interface ILibraryAsset
    {
        IEnumerable<LibraryAsset> GetAll();
        LibraryAsset Get(int id);
        void Add(LibraryAsset newAsset);
        string GetAuthorOrDirector(int id);
        string GetDeweyIndex(int id);
        string GetType(int id);
        string GetTitle(int id);
        string GetIsbn(int id);
        LibraryBranch GetCurrentLocation(int id);
        LibraryCard GetLibraryCardByAssetId(int id);
    }
}
