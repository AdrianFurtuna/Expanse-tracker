using System.ComponentModel.DataAnnotations.Schema;

namespace Expanse_tracker.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        //Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
