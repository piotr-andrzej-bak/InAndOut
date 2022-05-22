using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InAndOut.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nazwa wydatku")]
        [Required]
        public string ExpenseName { get; set; }

        [DisplayName("Kwota")]
        [Required]
        [Range(1,int.MaxValue, ErrorMessage = "Kwota musi być wyższa niż 0!")]
        public int Amount { get; set; }


        [DisplayName("ExpensesCategory")]
        public int ExpensesCategoryId { get; set; }

        [ForeignKey("ExpensesCategoryId")]
        [DisplayName("Kategoria wydatku")]
        public virtual ExpensesCategory ExpensesCategory { get; set; }
    }
}
