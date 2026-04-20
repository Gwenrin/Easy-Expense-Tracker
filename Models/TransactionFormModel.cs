using System.ComponentModel.DataAnnotations;

namespace EasyExpenseTracker.Models
{
    public class TransactionFormModel
    {
        [Required]
        public DateOnly TransactionDate { get; set; } = DateOnly.FromDateTime(DateTime.Today);

        [Range(typeof(decimal), "0,01", "999999999")]
        public decimal Amount { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Category { get; set; } = "Uncategorized";

        public bool IsIncome { get; set; }

        public bool IsFixedCost { get; set; }
    }
}