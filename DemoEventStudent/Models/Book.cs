using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEventStudent.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [MaxLength(200)]
        public string BookName { get; set; }
        public ICollection<OrderDetail> OrderDetalis { get; set; }
    }
}
