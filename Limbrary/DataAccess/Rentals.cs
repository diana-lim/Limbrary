using System;
using System.Collections.Generic;

namespace Limbrary
{
    public partial class Rentals
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? ChildrensBooks { get; set; }
        public int? AdultBooks { get; set; }
        public int? TotalBooks { get; set; }
        public decimal? TotalCost { get; set; }
    }
}
