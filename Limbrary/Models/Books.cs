using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Limbrary.Models
{
    public class Books
    {
        public  int Book_Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Age_Group { get; set; }
        public string In_Stock { get; set; }
    }
}
