using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BorrowLend.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Item name")]
        public string ItemName { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Borrower name must contain only letters.")]
        public string Borrower { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Lender name must contain only letters.")]
        public string Lender { get; set; }
    }

}
