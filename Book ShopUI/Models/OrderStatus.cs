using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_ShopUI.Models
{
    [Table("OrderStatus")]
    public class OrderStatus
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? StatusName { get; set; }    

    }
}
