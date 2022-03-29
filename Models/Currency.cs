using System.ComponentModel.DataAnnotations;

namespace SelfCheckoutMachine.Models
{
    public class Currency
    {
        [Key]
        public int Id { get; set; }

        public int Unit { get; set; }

        public int Amount { get; set; }
    }
}
