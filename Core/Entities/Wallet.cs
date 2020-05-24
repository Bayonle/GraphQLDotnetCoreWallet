using System;
using System.Collections.Generic;
using GraphqlWallets.Core.Enums;

namespace GraphqlWallets.Core.Entities
{
    public class Wallet
    {
        public long Id { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public DateTime Created { get; set; }
        public WalletStatus Status { get; set; }
        public ICollection<WalletTransaction> Transactions { get; set; }

        public Wallet()
        {
            Transactions = new List<WalletTransaction>();
        }
    }
}