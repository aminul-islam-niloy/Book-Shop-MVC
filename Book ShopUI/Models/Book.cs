using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_ShopUI.Models
{
    [Table("Book")]

    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? BookName { get; set; }
        public string? Image { get; set; }

        public double Price { get; set; }   

        //we will connect the Genere table with id
        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; } // Book can have only one Genre

        public List<OrderDetail> OrderDetail { get; set;}
        public List<CartDetail> CartDetail { get; set; }
         

    }
}
