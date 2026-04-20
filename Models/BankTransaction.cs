using System.ComponentModel.DataAnnotations;

namespace EasyExpenseTracker.Models
{
    public class BankTransaction
    {
        public int Id { get; set; }

        public DateOnly TransactionDate { get; set; }

        public decimal Amount { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool IsIncome { get; set; }

        public string Category { get; set; } = "Uncategorized";

        public bool IsFixedCost { get; set; }

        public string UserId { get; set; } = string.Empty;
    }
}