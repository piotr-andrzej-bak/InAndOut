using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
    public class ExpensesCategory
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nazwa katgorii")]
        [Required]
        public string expensesCategory { get; set; }
    }
}
