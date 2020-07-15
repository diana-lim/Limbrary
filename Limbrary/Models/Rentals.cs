using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Limbrary.Models
{
    public class Rentals
    {
        public int Order_Id { get; set; }
        public int Customer_Id { get; set; }
        public int Childrens_Books { get; set; }
        public int Adult_Books { get; set; }
        public int Total_Books { get; set; }
        public int Total_Cost { get; set; }

    }
}
