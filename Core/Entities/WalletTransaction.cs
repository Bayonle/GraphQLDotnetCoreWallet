using GraphqlWallets.Core.Enums;

namespace GraphqlWallets.Core.Entities
{
    public class WalletTransaction
    {
        public long Id { get; set; }
        public decimal Amount { get; set; }
        public string Reference { get; set; }
        public TransactionType Type { get; set; }
        public EntryType Entry { get; set; }
    }
}