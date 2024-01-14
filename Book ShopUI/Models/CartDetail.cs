using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_ShopUI.Models
{
    [Table("CartDetail")]
    public class CartDetail
    {
        public int Id { get; set; }
        [Required]
        public int ShoppintCartId { get; set; }   
        
        public int BookId { get; set; }
        [Required]
        public int Quantity { get; set; }   

        //many to one relation
        public Book Book { get; set; }
        public ShoppingCart ShoppingCart { get; set; }



    }
}
