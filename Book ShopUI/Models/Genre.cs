using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Book_ShopUI.Models
{
    [Table("Genre")]

    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string GenreName { get; set; }
        //one Genre can have multiple Books
        // one to many relation
       public List<Book> Books { get; set; }




    }
}
