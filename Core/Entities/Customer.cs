using System;
using System.Collections.Generic;

namespace GraphqlWallets.Core.Entities
{
    public class Customer
    {
        public long Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Registered { get; set; }
        public ICollection<Wallet> Wallets { get; set; }

        public Customer()
        {
            Registered = DateTime.Now;
            Wallets = new List<Wallet>();
        }
    }
}