using System.ComponentModel.DataAnnotations;

namespace BorrowLend.Models
{
    public class Expense
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Името на покупката е задължително.")]
        public string ExpenseName { get; set; }

        [Required(ErrorMessage = "Сумата е задължителна.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Сумата трябва да е положително число.")]
        public decimal Amount { get; set; }
    }
}
