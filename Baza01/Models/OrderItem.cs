using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Baza01.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public int MovieId { get; set; }
        [ForeignKey("MovieID")]
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Movie Movie { get; set; }
        public Order Order { get; set; }
    }
}
