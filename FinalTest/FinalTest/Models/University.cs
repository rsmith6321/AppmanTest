using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTest.Models
{
    public class University
    {
#nullable enable
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
#nullable disable
        public ICollection<EnrollOrder> EnrollOrders { get; set; }
    }
}
