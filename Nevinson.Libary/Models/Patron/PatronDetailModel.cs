﻿using Nevinson.Libary.Data.Models;
using System;
using System.Collections.Generic;

namespace Nevinson.Libary.Models.Patron
{
    public class PatronDetailModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int LibraryCardId { get; set; }
        public string Address { get; set; }
        public DateTime MemberSince { get; set; }
        public string Gender { get; set; }
        public string Telephone { get; set; }
        public string HomeLibrary { get; set; }
        public decimal OverdueFees { get; set; }
        public IEnumerable<Checkout> AssetsCheckedOut { get; set; }
        public IEnumerable<CheckoutHistory> CheckoutHistory { get; set; }
        public IEnumerable<Hold> Holds { get; set; }
    }
}
