using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Limbrary.Models
{
    public class Rental
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ChildrensBooks { get; set; }
        public int Books { get; set; }
        public int BookTotal { get; set; }
        public int OrderTotal { get; set; }

    }
}
