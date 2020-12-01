using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTest.Models
{
    public class EnrollOrder
    {
#nullable enable
        //public int id { get; set; }
        public int StudentId { get; set; }
        public int UniversityId { get; set; }
        //public string? Degree { get; set; }

        public Student? Student { get; set; }
        public University? University { get; set; }

    }
}
