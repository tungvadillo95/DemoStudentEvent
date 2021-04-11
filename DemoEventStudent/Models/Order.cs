using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEventStudent.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public ICollection<OrderDetail> OrderDetalis { get; set; }
    }
}
