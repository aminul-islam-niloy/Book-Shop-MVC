﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_ShopUI.Models
{
    [Table("Order")]
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        [Required]
        public int OrderStatusId { get; set; }

        public bool IsDeleted { get; set; }= false; 

        //many to one
        public OrderStatus OrderStatus { get; set; }
        //one to many
        public List<OrderDetail> OrderDetail { get; set; }
    }
}
